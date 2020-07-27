namespace WeatherAppFInal
{
    partial class WeatherDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherDataEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Mintemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_SelectedDateEntry = new System.Windows.Forms.DateTimePicker();
            this.txt_MinTemp = new System.Windows.Forms.TextBox();
            this.txt_MaxTemp = new System.Windows.Forms.TextBox();
            this.txt_Precip = new System.Windows.Forms.TextBox();
            this.txt_Humidity = new System.Windows.Forms.TextBox();
            this.Txt_windspeed = new System.Windows.Forms.TextBox();
            this.bt_SendDataToDatabase = new System.Windows.Forms.Button();
            this.cmbx_CityList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_ClearData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // lbl_Mintemp
            // 
            this.lbl_Mintemp.AutoSize = true;
            this.lbl_Mintemp.Location = new System.Drawing.Point(21, 27);
            this.lbl_Mintemp.Name = "lbl_Mintemp";
            this.lbl_Mintemp.Size = new System.Drawing.Size(70, 13);
            this.lbl_Mintemp.TabIndex = 2;
            this.lbl_Mintemp.Text = "Minium Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preciptitation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Windspeed";
            // 
            // DTP_SelectedDateEntry
            // 
            this.DTP_SelectedDateEntry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DTP_SelectedDateEntry.Location = new System.Drawing.Point(143, 76);
            this.DTP_SelectedDateEntry.Name = "DTP_SelectedDateEntry";
            this.DTP_SelectedDateEntry.Size = new System.Drawing.Size(200, 20);
            this.DTP_SelectedDateEntry.TabIndex = 7;
            this.DTP_SelectedDateEntry.ValueChanged += new System.EventHandler(this.DTP_SelectedDateEntry_ValueChanged);
            // 
            // txt_MinTemp
            // 
            this.txt_MinTemp.Location = new System.Drawing.Point(134, 27);
            this.txt_MinTemp.Name = "txt_MinTemp";
            this.txt_MinTemp.Size = new System.Drawing.Size(209, 20);
            this.txt_MinTemp.TabIndex = 9;
            // 
            // txt_MaxTemp
            // 
            this.txt_MaxTemp.Location = new System.Drawing.Point(134, 53);
            this.txt_MaxTemp.Name = "txt_MaxTemp";
            this.txt_MaxTemp.Size = new System.Drawing.Size(209, 20);
            this.txt_MaxTemp.TabIndex = 10;
            // 
            // txt_Precip
            // 
            this.txt_Precip.Location = new System.Drawing.Point(134, 79);
            this.txt_Precip.Name = "txt_Precip";
            this.txt_Precip.Size = new System.Drawing.Size(209, 20);
            this.txt_Precip.TabIndex = 11;
            // 
            // txt_Humidity
            // 
            this.txt_Humidity.Location = new System.Drawing.Point(134, 105);
            this.txt_Humidity.Name = "txt_Humidity";
            this.txt_Humidity.Size = new System.Drawing.Size(209, 20);
            this.txt_Humidity.TabIndex = 12;
            // 
            // Txt_windspeed
            // 
            this.Txt_windspeed.Location = new System.Drawing.Point(134, 131);
            this.Txt_windspeed.Name = "Txt_windspeed";
            this.Txt_windspeed.Size = new System.Drawing.Size(209, 20);
            this.Txt_windspeed.TabIndex = 13;
            // 
            // bt_SendDataToDatabase
            // 
            this.bt_SendDataToDatabase.Location = new System.Drawing.Point(159, 358);
            this.bt_SendDataToDatabase.Name = "bt_SendDataToDatabase";
            this.bt_SendDataToDatabase.Size = new System.Drawing.Size(199, 23);
            this.bt_SendDataToDatabase.TabIndex = 14;
            this.bt_SendDataToDatabase.Text = "add data to Database";
            this.bt_SendDataToDatabase.UseVisualStyleBackColor = true;
            this.bt_SendDataToDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbx_CityList
            // 
            this.cmbx_CityList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbx_CityList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbx_CityList.FormattingEnabled = true;
            this.cmbx_CityList.Location = new System.Drawing.Point(143, 36);
            this.cmbx_CityList.Name = "cmbx_CityList";
            this.cmbx_CityList.Size = new System.Drawing.Size(200, 21);
            this.cmbx_CityList.TabIndex = 15;
            this.cmbx_CityList.Text = "click here to select a town ";
            this.cmbx_CityList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Mintemp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_windspeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Humidity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Precip);
            this.groupBox1.Controls.Add(this.txt_MinTemp);
            this.groupBox1.Controls.Add(this.txt_MaxTemp);
            this.groupBox1.Location = new System.Drawing.Point(24, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbx_CityList);
            this.groupBox2.Controls.Add(this.DTP_SelectedDateEntry);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 152);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_ClearData
            // 
            this.bt_ClearData.Location = new System.Drawing.Point(158, 387);
            this.bt_ClearData.Name = "bt_ClearData";
            this.bt_ClearData.Size = new System.Drawing.Size(200, 23);
            this.bt_ClearData.TabIndex = 18;
            this.bt_ClearData.Text = "Clear Data from form";
            this.bt_ClearData.UseVisualStyleBackColor = true;
            this.bt_ClearData.Click += new System.EventHandler(this.bt_ClearData_Click);
            // 
            // WeatherDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(405, 420);
            this.Controls.Add(this.bt_ClearData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_SendDataToDatabase);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherDataEntry";
            this.Load += new System.EventHandler(this.WeatherDataEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Mintemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_SelectedDateEntry;
        private System.Windows.Forms.TextBox txt_MinTemp;
        private System.Windows.Forms.TextBox txt_MaxTemp;
        private System.Windows.Forms.TextBox txt_Precip;
        private System.Windows.Forms.TextBox txt_Humidity;
        private System.Windows.Forms.TextBox Txt_windspeed;
        private System.Windows.Forms.Button bt_SendDataToDatabase;
        private System.Windows.Forms.ComboBox cmbx_CityList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_ClearData;
    }
}