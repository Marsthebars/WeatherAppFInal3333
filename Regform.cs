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
    public partial class Regform : Form
    {
        string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;

        public Regform()
        {
            InitializeComponent();
        }
        private void CheckContactNumber()
        {

            DataSet myDataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(con_str))
            {

                // this code checks the sql data base to see if there is a user name that matches the one enterd 
                try
                {

                    connection.Open();
                  SqlCommand cm = new SqlCommand("", connection);
                    
                    cm.CommandText = "Select FROM  WHERE username=@UserName";
                    cm.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txt_Username.Text;

                    cm.ExecuteNonQuery();
                
                        // Whatever...





                    
                      // TODO: Convert to use paramerised Query 
                      string checkuser = "select count(*) from UserDataTable where UserName = @userName";

                    SqlCommand SLQcmd = new SqlCommand(checkuser, connection);

                    SLQcmd.Parameters.Add(new SqlParameter("@userName", txt_Username.Text));

                    string strAccessSelect = "select count(*) from UserLogin where username='" + txt_Username.Text + "'";
                    SqlDataAdapter Login_sqlDataAdapter = new SqlDataAdapter(SLQcmd);

                    connection.Open();
                    Login_sqlDataAdapter.Fill(myDataSet, "User");


                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                    return;
                }
                finally
                {
                    connection.Close();
                }
                DataTable dt = myDataSet.Tables[0];
                if (dt != null)
                {
                    if (int.Parse(dt.Rows[0][0].ToString()) > 0)
                    {
                        string err = "Contact Number Already exist..";
                        MessageBox.Show(err.ToString());
                        MessageBox.Show("exsists");
                    }
                    else if (int.Parse(dt.Rows[0][0].ToString()) < 0)
                    {
                        string err = "carry on..";
                        MessageBox.Show(err.ToString());
                        MessageBox.Show("doesnt");
                    }
                   
                }
            }
        }
        private void Regform_Load(object sender, EventArgs e)
        {

        }


        void passwordchecker()
        {
            string test = txt_RegPassword.TextLength.ToString();


            String password = test; // Substitute with the user input string
            PasswordScore passwordStrengthScore = PasswordAdvisor.CheckStrength(password);

            switch (passwordStrengthScore)
            {
                case PasswordScore.Blank:
                case PasswordScore.VeryWeak:
                case PasswordScore.Weak:
                    // Show an error message to the user
                    break;
                case PasswordScore.Medium:
                case PasswordScore.Strong:
                case PasswordScore.VeryStrong:
                    // Password deemed strong enough, allow user to be added to database etc
                    break;

            }
            MessageBox.Show(passwordStrengthScore.ToString());
        }



        private void pword_Click(object sender, EventArgs e)
        {

        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            CheckContactNumber();
        }
    }
}