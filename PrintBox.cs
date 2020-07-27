using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppFInal
{
    public partial class PrintBox : Form
    {
        public PrintBox()
        {
            InitializeComponent();
        }

        private void PrintBox_Load(object sender, EventArgs e)
        {

            CheckForInternetConnection();
            if (CheckForInternetConnection() == false)
            {
                MessageBox.Show("Please check your internet and try again");
            }
            else if (CheckForInternetConnection() == true)
            {
                try
                {
                    PrintDocument prtdoc = new PrintDocument();
                    string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
                    foreach (String strPrinter in PrinterSettings.InstalledPrinters)
                    {
                        comboBox1.Items.Add(strPrinter);
                        if (strPrinter == strDefaultPrinter)
                        {
                            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(strPrinter);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    Console.WriteLine("alive");
                return true;
            }
            catch
            {
                Console.WriteLine("dead");
                return false;

            }

        }
    }
}