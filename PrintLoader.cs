/*using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WeatherAppFInal
{
    class PrintLoader
    {

        public void RetrieveData(ComboBox comboBox)
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
    }


}
}
*/