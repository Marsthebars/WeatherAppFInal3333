using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppFInal
{
    public partial class DataEditorForm : Form
    {
        string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;

        public DataEditorForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Refresh();
        }

        private void DataEditorForm_Load(object sender, EventArgs e)
        {

            using (SqlConnection saConn = new SqlConnection(this.con_str))
            {
                saConn.Open();

                string query = "select City_name  from WeatherDataaa3";
                SqlCommand cmd = new SqlCommand(query, saConn);

                using (SqlDataReader saReader = cmd.ExecuteReader())
                {
                    while (saReader.Read())
                    {
                        string name = saReader.GetString(0);
                        comboBox1.Items.Add(name);
                    }
                }
                saConn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Refresh();
            owo();

        }

        void owo()
        {
            try
            {
                using (SqlConnection saConn = new SqlConnection(this.con_str))
                {
                    saConn.Open();

                    string query = "SELECT  City_name, Date_selected, Min_temp, Max_temp, Precipitation, humidity, windspeed " +
                     "FROM WeatherDataaa3 WHERE  City_name =('" + comboBox1.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, saConn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "ss");

                    dataGridView1.DataSource = ds.Tables["ss"]; ;
                    EditDGVUpdate();
                    saConn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void EditDGVUpdate()
        {
            dataGridView1.Update();
        }

        void DeleteFunc()
        {
            try
            {
                using (SqlConnection saConn = new SqlConnection(this.con_str))
                {
                    saConn.Open();
                    Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);


                    string query = " DELETE FROM WeatherDataaa3 WHERE id =('" + selectedRowCount + "')";
                    SqlCommand cmd = new SqlCommand(query, saConn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    da.Fill(ds, "ss");

                    dataGridView1.DataSource = ds.Tables["ss"]; ;
                    dataGridView1.Update();
                    saConn.Close();


                }
            }
            catch (Exception)
            {
                throw;
            }



        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            



            DeleteFunc();
            
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedRows[0].Index;
                MessageBox.Show("Test" + index);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row before trying to delete it ");

            }

        }

        private void bt_selection_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
    }
}
