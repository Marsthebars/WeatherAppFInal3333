using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeatherAppFInal
{
    public partial class LoginForm : Form
    {
        public bool state;
        public LoginForm()
        {
            InitializeComponent();
            
        }
        // storing the connection strng in the config file 

        string con_str = System.Configuration.ConfigurationManager.ConnectionStrings["connection_str"].ConnectionString;

        

       /// <summary>
       ///  login button for login 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void bt_Login_Click(object sender, EventArgs e)
        {
              
           SqlDataAdapter sda = new SqlDataAdapter
                ("SELECT COUNT(*) FROM UserLogin WHERE username='" + textBox1.Text 
                + "' AND password='" + textBox2.Text + "'", con_str);
            //createing a new virtual table to hold the data 
            DataTable dt = new DataTable(); 
            
            MessageBox.Show(dt.ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
               // opens the dashboard if the login is successfull 
                this.Hide();
                new MainDashboard().Show();
            }
            else
            {

                MessageBox.Show("Invalid username or password");
            }

        }
       
        private void LL_OpenRegForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Regform().Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.notifyIcon1.Icon = WeatherAppFInal.Properties.Resources.rainy_weather_256;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Form1 formpop = new Form1();
            formpop.StartPosition = FormStartPosition.Manual;
            formpop.Left = 1000;
            formpop.Top = 200;
            formpop.ShowDialog();
         
        }
    }
}
