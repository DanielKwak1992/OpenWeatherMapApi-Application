//Created and designed by Daniel Kwak for Euromoney
//<Daniel.Kwak.dk@gmail.com>
using System;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.IO;
namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //do api request & commit to database
            GetWeather(6544881, 3041563, 264371, 792680, 2950159, 2661552, 3060972, 2800866, 683506, 7284844, 618426, 2618425, 2964574, 658225, 703448, 2267057, 3196359, 2643741, 2960316, 3117735, 625144, 2993458, 524901, 146268, 3421319, 3143244, 2988507, 3193044, 3067696, 3413829, 456172, 6691831, 3168070, 3191281, 785842, 727011, 2673730, 588409, 3183875, 3042030, 2562305, 2761369, 593116, 756135, 6618983);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new v());
        }

        //gets data and saves to database
        static public void GetWeather(params int[] CityID)
        {
            //compile api string request
            string BaseUrl = "http://api.openweathermap.org/data/2.5/group?id=";
            string Param = "&units=metric&appid=f266f55e7ceb654bdf1bfe84fdb674c4";
            string result = string.Join(",", CityID);
            //request api
            WebClient wc = new WebClient();
            var json = wc.DownloadString(BaseUrl + result + Param);
            //deserialize jsondata using json.net
            var weatherObj = JsonConvert.DeserializeObject<WeatherData.RootObject>(json);

            //create new server connection
            SqlConnection cnn = new SqlConnection(@"Data Source=Daniel-MSI;Initial Catalog=WeatherDatabase;User ID=sa;Password=1234");

            cnn.Open();
            //check database for cities already recorded
            for (var i = 0; i < weatherObj.list.Count; i++)
            {
                //get city id from api
                int city = Convert.ToInt32(weatherObj.list[i].id);
                //query checks if current city exists
                string sqlC = "select * from [WeatherDatabase].[dbo].[City] where Cityid = @cityid;";
                SqlCommand cmd1 = new SqlCommand(sqlC, cnn);
                cmd1.Parameters.AddWithValue("@cityid", city);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                //reset sql query result
                int cityresult = 0;

                while (sdr1.Read())
                {
                    //if city is there -> check with cityresult
                    cityresult = Convert.ToInt32(sdr1["Cityid"]);
                }
                sdr1.Close();
                //insert cities that dont exit in database yet
                if (city != cityresult)
                {

                    string sqlci = "insert into [WeatherDatabase].[dbo].[City] values(@Cityid,@Country,@lat,@lon,@name); ";
                    using (SqlCommand cmdci = new SqlCommand(sqlci, cnn))
                    {
                        cmdci.Parameters.AddWithValue("@Cityid", weatherObj.list[i].id);
                        cmdci.Parameters.AddWithValue("@Country", weatherObj.list[i].sys.country);
                        cmdci.Parameters.AddWithValue("@lat", weatherObj.list[i].coord.lat);
                        cmdci.Parameters.AddWithValue("@lon", weatherObj.list[i].coord.lon);
                        cmdci.Parameters.AddWithValue("@name", weatherObj.list[i].name);
                        cmdci.ExecuteNonQuery();
                    }
                }
            }

            //check if city+date exists
            for (var i = 0; i < weatherObj.list.Count; i++)
            {
                var requestime = FromUnixTime(weatherObj.list[i].dt);
                string sqlC = " select * from WeatherDatabase.dbo.Weather where Updatetime= @updatetime and Cityid = @cityid";
                SqlCommand cmd1 = new SqlCommand(sqlC, cnn);
                cmd1.Parameters.AddWithValue("@updatetime", requestime);
                cmd1.Parameters.AddWithValue("@cityid", Convert.ToInt32(weatherObj.list[i].id));
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                //reset sql query result
                int cityresult = 0;
                while (sdr1.Read())
                {
                    cityresult = Convert.ToInt32(sdr1["Cityid"]);
                }
                sdr1.Close();
                //if no results commit new weather to database
                if (cityresult == 0)
                {
                    string sqlW = "insert into [WeatherDatabase].[dbo].[Weather] (Cityid,Sunrise, Sunset, temp, Tempmax,Tempmin,Clouds,Humidity,Pressure,Visibility,descrip,icon,id,main,Winddeg,Windspeed,Updatetime) values(@Cityid,@Sunrise,@Sunset,@temp,@Tempmax,@Tempmin,@Clouds,@Humidity,@Pressure,@Visibility,@descrip,@icon,@id,@main,@Winddeg,@Windspeed,@Updatetime); ";
                    using (SqlCommand cmd = new SqlCommand(sqlW, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Cityid", weatherObj.list[i].id);
                        cmd.Parameters.AddWithValue("@Sunrise", FromUnixTime(weatherObj.list[i].sys.sunrise));
                        cmd.Parameters.AddWithValue("@Sunset", FromUnixTime(weatherObj.list[i].sys.sunset));
                        cmd.Parameters.AddWithValue("@temp", weatherObj.list[i].main.temp);
                        cmd.Parameters.AddWithValue("@Tempmax", weatherObj.list[i].main.temp_max);
                        cmd.Parameters.AddWithValue("@Tempmin", weatherObj.list[i].main.temp_min);
                        cmd.Parameters.AddWithValue("@Clouds", weatherObj.list[i].clouds.all);
                        cmd.Parameters.AddWithValue("@Humidity", weatherObj.list[i].main.humidity);
                        cmd.Parameters.AddWithValue("@Pressure", weatherObj.list[i].main.pressure);
                        //if there is no visibility give null
                        if (weatherObj.list[i].visibility.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@Visibility", weatherObj.list[i].visibility);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Visibility", DBNull.Value);
                        }
                        cmd.Parameters.AddWithValue("@descrip", weatherObj.list[i].weather[0].description);
                        //find icon and commit image to database.
                        string iconpath = Environment.CurrentDirectory + @"\Images\" + weatherObj.list[i].weather[0].icon.ToString() + ".png";
                        byte[] stream = fileconvert(iconpath);
                        cmd.Parameters.AddWithValue("@icon", stream);
                        cmd.Parameters.AddWithValue("@id", weatherObj.list[i].weather[0].id);
                        cmd.Parameters.AddWithValue("@main", weatherObj.list[i].weather[0].main);
                        cmd.Parameters.AddWithValue("@Winddeg", weatherObj.list[i].wind.deg);
                        cmd.Parameters.AddWithValue("@Windspeed", weatherObj.list[i].wind.speed);
                        //convert from unix time to datetime
                        cmd.Parameters.AddWithValue("@Updatetime", FromUnixTime(weatherObj.list[i].dt));
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            cnn.Close();
        }

        static private DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        static private byte[] fileconvert(string filepath)
        {
            FileStream FS = new FileStream(filepath, FileMode.Open, FileAccess.Read); //create a file stream object  
            byte[] img = new byte[FS.Length]; //create a byte array with size of stream length
            FS.Read(img, 0, Convert.ToInt32(FS.Length));//read selected file stream in to byte array
            return img;
        }



    }
}
