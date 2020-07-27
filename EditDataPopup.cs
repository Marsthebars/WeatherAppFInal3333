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
    public partial class EditDataPopup : Form
    {
        private string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;

        public EditDataPopup()
        {
            InitializeComponent();
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
          
                try
                {
                    using (SqlConnection con = new SqlConnection(con_str))
                    {
                        con.Open();
                    int index2 = DGV_DisplayEditData.SelectedRows[0].Index;
                    using (SqlCommand command = new SqlCommand
                        ("DELETE index2 FROM Weatherdataaa3 WHERE " + cmbx_selectCityEdit + '"', con))
                        {
                            command.ExecuteNonQuery();
                        }
                    DGV_DisplayEditData.Update();
                        con.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
            }

        private void EditDataPopup_Load(object sender, EventArgs e)
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
                        cmbx_selectCityEdit.Items.Add(name);
                    }
                }
                saConn.Close();
            }
        }

        private void DGV_DisplayEditData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbx_selectCityEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
