using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppFInal
{
    public partial class WeatherDataEntry : Form
    {
        DateTime dateTimeE;
        string CityName;
        int maxTemp , preCip, Humidity, windSpeed;
        int minTemp;
        public WeatherDataEntry()
        {
            InitializeComponent();

        }
        string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;


        private void WeatherDataEntry_Load(object sender, EventArgs e)
        {
            using (SqlConnection saConn = new SqlConnection(this.con_str))
            {
                saConn.Open();

                string query = "select city from ZA_city_Data";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string name = saReader.GetString(0);
                        cmbx_CityList.Items.Add(name);
                    }
                }
                saConn.Close();
            }
        }

     

        private void txt_CityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTP_SelectedDateEntry_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_ClearData_Click(object sender, EventArgs e)
        {
            cmbx_CityList.Focus();

            /// date time
            DTP_SelectedDateEntry.Value = DateTime.Today;


            /// text boxes 
            txt_MinTemp.Clear();
            txt_MaxTemp.Clear();
            txt_Precip.Clear();
            txt_Humidity.Clear();
            Txt_windspeed.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        void Capdatamethod()
        {
            // code reference https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netframework-4.8
            // try pass is used in order to get the value from the  textboxes and uses the Out Keyword that holds the values in the varible
            // the boolean is used to ensure the user has enterd a value or not 
            // if a user has not enterd a value the coresponding lables foreground color will be changed to red 
             dateTimeE = DTP_SelectedDateEntry.Value;
            var datestring = dateTimeE.ToShortDateString();
            string badInput = datestring;

            bool DateT = DateTime.TryParse(badInput, out dateTimeE);
            if (!DateT)
            {
                //turns the lable red if nothing has been enterd into the textbox 

            }
            //adds the city name into the city varible 


            string myString = cmbx_CityList.Text;

            CityName = myString;
            if (CityName.Equals("")) // if a city has not been picked the lable will turned red 
            {
            }
            bool maxT = Int32.TryParse(txt_MaxTemp.Text, out maxTemp);
            if (!maxT)
            {
                //turns the lable red if nothing has been enterd into the textbox 

            }

            bool minT = Int32.TryParse(txt_MinTemp.Text, out minTemp);
            if (!minT)
            {
                //turns the lable red if nothing has been enterd into the textbox 

            }
            bool PreCip = Int32.TryParse(txt_Precip.Text, out preCip);
            if (!PreCip)
            {                //turns the lable red if nothing has been enterd into the textbox 
                lbl_Mintemp.ForeColor = Color.Red;

            }
            bool huMid = Int32.TryParse(txt_Humidity.Text, out Humidity);
            if (!huMid)
            {                //turns the lable red if nothing has been enterd into the textbox 


            }
            bool windSp = Int32.TryParse(Txt_windspeed.Text, out windSpeed);
            if (!windSp)
            {                //turns the lable red if nothing has been enterd into the textbox 

            }
        }
    
            private void button1_Click(object sender, EventArgs e)
        {


            Capdatamethod();
            try
            {
                using (SqlConnection ConOpen = new SqlConnection(con_str))
                {
                    string QInsert_weatherData = "INSERT into WeatherDataaa3 (City_name,Date_selected,Min_temp,Max_temp,Precipitation,humidity,windspeed) " +
                        "VALUES (@cityname,@selectedDate,@Mintemp,@Maxtemp,@Precipitation,@humidity,@windspeed)";

                    using (SqlCommand cmd_SubmitWeatherDataDB = new SqlCommand(QInsert_weatherData))
                    {
                        cmd_SubmitWeatherDataDB.Connection = ConOpen;

                        cmd_SubmitWeatherDataDB.Parameters.Add("@cityname", SqlDbType.VarChar, 30).Value = CityName;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@selectedDate", SqlDbType.DateTime, 30).Value = dateTimeE;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@Mintemp", SqlDbType.Int, 30).Value = minTemp;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@Maxtemp", SqlDbType.Int, 30).Value = maxTemp;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@Precipitation", SqlDbType.Int, 30).Value = preCip;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@humidity", SqlDbType.Int, 30).Value = Humidity;
                        cmd_SubmitWeatherDataDB.Parameters.Add("@windspeed", SqlDbType.Int, 30).Value = windSpeed;
                        ConOpen.Open();

                        cmd_SubmitWeatherDataDB.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
         

        }
    }
}