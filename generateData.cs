using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace WeatherAppFInal
{
    public partial class generateData : Form
    {
        public generateData()
        {
            InitializeComponent();
        }

        private string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;




        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void testting()
        {
            if (DateComapre().Equals(true)) // valid date range selected
            {
                dataGridView1.Refresh();
                string startdate = DTP_StartDate.Value.Date.ToString();
                string EndDate = DTP_EndDate.Value.Date.ToString();
                string SelectedDateFromCMBX = cmbx_CityPicker.Text;
                string City_name = cmbx_CityPicker.SelectedItem.ToString();
                try
                {

                    using (SqlConnection con = new SqlConnection(con_str))
                    {
                        string ssss = ("SELECT * FROM WeatherDataaa3 WHERE City_name='" + City_name + "'");
                        SqlDataAdapter da = new SqlDataAdapter(ssss, con_str);
                           

                                DataSet ds = new DataSet();
                        con.Open();
                        da.Fill(ds, "Authors_table");
                        con.Close();
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Authors_table";
                    } }

                catch (Exception)
                {

                    throw;

                } }}

        private bool DateComapre()
        {
            // date time comparer
            DateTime startdate = DTP_StartDate.Value;
            DateTime EndDate = DTP_EndDate.Value;

            if (startdate > EndDate)
            {
                MessageBox.Show("Please Enter a Valid Date Range");
                DTP_StartDate.CalendarTitleBackColor = Color.Red;
                return false;
            }
            else if (startdate < EndDate)
            {
                return true;
            }
            if (startdate == EndDate)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        private void Form_onload()
        {
            using (SqlConnection saConn = new SqlConnection(this.con_str))
            {
                saConn.Open();

                string query = "SELECT DISTINCT  City_name FROM WeatherDataaa3";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string name = saReader.GetString(0);
                        cmbx_CityPicker.Items.Add(name);
                    }
                }
                saConn.Close();
            }
        }

        private void generateData_Load(object sender, EventArgs e)
        {
            Form_onload();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void highlightcells()
        {
            int minTemperature = dataGridView1.Rows.Cast<DataGridViewRow>().Min(r => Convert.ToInt32(r.Cells["Min Temp (°C)"].Value, CultureInfo.CurrentCulture));
            int maxTemperature = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["Max Temp (°C)"].Value, CultureInfo.CurrentCulture));
            int maxPrecip = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["Precipitation %"].Value, CultureInfo.CurrentCulture));
            int maxHumid = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["Humidity %"].Value, CultureInfo.CurrentCulture));
            int maxWndSpeed = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["Wind Speed (km/h)"].Value, CultureInfo.CurrentCulture));

            /*                int minTemperature1 = dataGridView3.Rows.Cast<DataGridViewRow>().Min(c => Convert.ToInt32(c.Cells["Min Temp (°C)"].Value));
                            int maxTemperature1 = dataGridView3.Rows.Cast<DataGridViewRow>().Max(c => Convert.ToInt32(c.Cells["Max Temp (°C)"].Value));
                            int maxPrecip1 = dataGridView3.Rows.Cast<DataGridViewRow>().Max(c => Convert.ToInt32(c.Cells["Precipitation %"].Value));
                            int maxHumid1 = dataGridView3.Rows.Cast<DataGridViewRow>().Max(c => Convert.ToInt32(c.Cells["Humidity %"].Value));
                            int maxWndSpeed1 = dataGridView3.Rows.Cast<DataGridViewRow>().Max(c => Convert.ToInt32(c.Cells["Wind Speed (km/h)"].Value));*/

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value, CultureInfo.CurrentCulture) == minTemperature)
                {
                    row.Cells[2].Style.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(row.Cells[3].Value, CultureInfo.CurrentCulture) == maxTemperature)
                {
                    row.Cells[3].Style.BackColor = Color.Red;
                }
                if (Convert.ToInt32(row.Cells[4].Value, CultureInfo.CurrentCulture) == maxPrecip)
                {
                    row.Cells[4].Style.BackColor = Color.Blue;
                }
                if (Convert.ToInt32(row.Cells[5].Value, CultureInfo.CurrentCulture) == maxHumid)
                {
                    row.Cells[5].Style.BackColor = Color.Green;
                }
                if (Convert.ToInt32(row.Cells[6].Value, CultureInfo.CurrentCulture) == maxWndSpeed)
                {
                    row.Cells[6].Style.BackColor = Color.Purple;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            /*  selectfromSQL();*/
            dataGridView1.Refresh();
            testting();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateComapre();
        }

        private void bt_UpdateDGV_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///Min_temp,Max_temp
            try
            {
                int temp;
                var MaxID2 = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Max(r => int.TryParse(r.Cells["Min_temp"].Value.ToString(), out temp) ?
                                       temp : 0);
                dataGridView1.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void TSMI_EditData_Click(object sender, EventArgs e)
        {
            new EditDataPopup().Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}