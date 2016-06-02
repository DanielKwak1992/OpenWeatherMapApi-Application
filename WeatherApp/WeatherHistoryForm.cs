using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeatherApp
{
    public partial class WeatherHistoryForm : Form
    {
        //init data control and sql connection
        DataSet ds = new DataSet();
        SqlConnection cs1 = new SqlConnection(@"Data Source=Daniel-MSI;Initial Catalog=WeatherDatabase;User ID=sa;Password=1234");
        SqlDataAdapter da = new SqlDataAdapter();
        
        
        public WeatherHistoryForm()
        {
            InitializeComponent();
        }
        private void WeatherHistoryForm_Load(object sender, EventArgs e)
        {
            //update table on load
            tableupdate();
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            //update table every time a value is changed
            tableupdate();
        }

        public void tableupdate()
        {
            //run and execute select query with optional parameters
            string queryfilter = "SELECT (Name+', '+Country) as name,(convert(varchar, Lat) + '°, ' + convert(varchar, Lon) + '°') as coord, Updatetime,Temp, Tempmax, Tempmin, descrip, Clouds, Humidity, Pressure, Visibility, Winddeg, Windspeed FROM WeatherDatabase.dbo.City C INNER JOIN WeatherDatabase.dbo.Weather W ON C.Cityid = W.Cityid WHERE (@name IS NULL OR Name like @name) and (@temp is null or Temp = @temp) and (@tempmax is null or Tempmax = @tempmax) and (@tempmin is null or Tempmin = @tempmin) and (@descrip is null or descrip like @descrip) and (@clouds is null or Clouds = @clouds) and (@windspeed is null or Windspeed = @windspeed)";
            cs1.Open();
            da.SelectCommand = new SqlCommand(queryfilter, cs1);
            da.SelectCommand.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value =  checknull(nametextbox.Text.ToString());
            da.SelectCommand.Parameters.AddWithValue("@temp", SqlDbType.Float).Value = checkzero(tempnumeric.Value);
            da.SelectCommand.Parameters.AddWithValue("@tempmax", SqlDbType.Float).Value = checkzero(tempmaxnumeric.Value);
            da.SelectCommand.Parameters.AddWithValue("@tempmin", SqlDbType.Float).Value = checkzero(tempminnumeric.Value);
            da.SelectCommand.Parameters.AddWithValue("@descrip", SqlDbType.VarChar).Value = checknull(descriptextbox.Text.ToString());
            da.SelectCommand.Parameters.AddWithValue("@clouds", SqlDbType.Int).Value = checkzero(cloudsnumeric.Value);
            da.SelectCommand.Parameters.AddWithValue("@windspeed", SqlDbType.Int).Value = checkzero(windspeednumeric.Value);
            ds.Clear();
            da.Fill(ds);
            DG.DataSource = ds.Tables[0];

            cs1.Close();   
        }
        //check if textbox string is null and adds wildcards and returns DBnull if empty
        private object checknull(string target)
        {
            if (!string.IsNullOrWhiteSpace(target))
            {
                string str = "%" + target + "%";
                return str;
            }
            else
            {
                return DBNull.Value;
            }
        }
        //check if numericupdown is 0 and returns DBnull if 0
        private object checkzero(decimal target)
        {
            if (target != 0 )
            {
                return target;
            }
            else
            {
                return DBNull.Value;
            }
        }

        private void clrbutton_Click(object sender, EventArgs e)
        {
            nametextbox.Text = "";
            tempnumeric.Value = 0;
            tempminnumeric.Value = 0;
            tempmaxnumeric.Value = 0;
            descriptextbox.Text = "";
            cloudsnumeric.Value = 0;
            windspeednumeric.Value = 0;
        }
    }
}
