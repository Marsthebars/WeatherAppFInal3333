

    using System;  
    using System.Windows.Forms;  
    using System.Drawing.Printing;  
    public class Class1 : System.Windows.Forms.Form
{
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    public Form1()
    {
        comboBox1 = new ComboBox();
        label1 = new Label();
        label1.Location = new System.Drawing.Point(20, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(75, 20);
        label1.Text = "Select Printer";
        comboBox1.Location = new System.Drawing.Point(100, 10);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(150, 20);
        AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        ClientSize = new System.Drawing.Size(300, 100);
        Text = "Printers Sample";
        Controls.AddRange(new System.Windows.Forms.Control[] {
       this.label1, this.comboBox1
      });
        this.Load += new System.EventHandler(this.Form1_Load);
    }
   
    private void Form1_Load(object sender, System.EventArgs e)
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
