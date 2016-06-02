//Created and designed by Daniel Kwak for Euromoney
//<Daniel.Kwak.dk@gmail.com>
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WeatherApp
{
    public partial class v : Form
    {
        //create data connection and data managment tools
        DataSet ds = new DataSet();
        SqlConnection cs = new SqlConnection(@"Data Source=Daniel-MSI;Initial Catalog=WeatherDatabase;User ID=sa;Password=1234");
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource tblNameBS = new BindingSource();
        public v()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //update gui on load
            guiupdate();
        }

        private void guiupdate()
        {
            //create and execute query for gui 
            string displaydataquery = "SELECT (Name+', '+Country) as name,(convert(varchar, Lat) + '°, ' + convert(varchar, Lon) + '°') as coord, Updatetime,Temp, Tempmax, Tempmin, descrip, Clouds, Humidity, Pressure, Visibility, Winddeg, Windspeed,icon FROM WeatherDatabase.dbo.City C INNER JOIN WeatherDatabase.dbo.Weather W ON C.Cityid = W.Cityid inner join (select Cityid,Max(updatetime) as maxdate from WeatherDatabase.dbo.Weather group by Cityid) J on c.Cityid=j.Cityid and w.Updatetime=j.maxdate;";
            da.SelectCommand = new SqlCommand(displaydataquery, cs);
            ds.Clear();
            da.Fill(ds);

            tblNameBS.DataSource = ds.Tables[0];
            //bind data to gui (labels)
            coordvalue.DataBindings.Add(new Binding("text", tblNameBS, "coord"));
            datevalue.DataBindings.Add(new Binding("text", tblNameBS, "UpdateTime"));
            Tempvalue.DataBindings.Add(new Binding("text", tblNameBS, "Temp"));
            temphighvalue.DataBindings.Add(new Binding("text", tblNameBS, "Tempmax"));
            templowvalue.DataBindings.Add(new Binding("text", tblNameBS, "Tempmin"));
            descriptionvalue.DataBindings.Add(new Binding("text", tblNameBS, "descrip"));
            Cloudvalue.DataBindings.Add(new Binding("text", tblNameBS, "Clouds"));
            humidityvalue.DataBindings.Add(new Binding("text", tblNameBS, "Humidity"));
            pressurevalue.DataBindings.Add(new Binding("text", tblNameBS, "Pressure"));
            visibilityvalue.DataBindings.Add(new Binding("text", tblNameBS, "Visibility"));
            winddegvalue.DataBindings.Add(new Binding("text", tblNameBS, "Winddeg"));
            windspeedvalue.DataBindings.Add(new Binding("text", tblNameBS, "Windspeed"));
            weatherpictureBox.DataBindings.Add(new Binding("Image", tblNameBS, "icon", true));
            //add autocomplete and bindng to combobox
            citycombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            citycombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            citycombobox.DisplayMember = "Name";
            citycombobox.ValueMember = "Name";
            citycombobox.DataSource = tblNameBS;
            addunits();
        }

        private void addunits()
        {
            Tempvalue.Text += "°C";
            temphighvalue.Text += "°C";
            templowvalue.Text += "°C";
            Cloudvalue.Text += "%";
            humidityvalue.Text += "%";
            pressurevalue.Text += " hPa";
            visibilityvalue.Text += " m";
            winddegvalue.Text += "°";
            windspeedvalue.Text += " m/s";
            datevalue.Text += " UTC";
        } 

        
        private void previousbutton_Click(object sender, EventArgs e)
        {
            tblNameBS.MovePrevious();
            addunits();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            tblNameBS.MoveNext();
            addunits();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //get api request and update gui every 30 mins
            Program.GetWeather(6544881, 3041563, 264371, 792680, 2950159, 2661552, 3060972, 2800866, 683506, 7284844, 618426, 2618425, 2964574, 658225, 703448, 2267057, 3196359, 2643741, 2960316, 3117735, 625144, 2993458, 524901, 146268, 3421319, 3143244, 2988507, 3193044, 3067696, 3413829, 456172, 6691831, 3168070, 3191281, 785842, 727011, 2673730, 588409, 3183875, 3042030, 2562305, 2761369, 593116, 756135, 6618983);
            guiupdate();
        }

        private void weatherhistorybutton_Click(object sender, EventArgs e)
        {
            //open weather history form
            WeatherHistoryForm f2 = new WeatherHistoryForm();
            f2.ShowDialog();
        }
       
    }
}

