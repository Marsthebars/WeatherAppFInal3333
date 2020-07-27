namespace WeatherAppFInal
{
    partial class generateData
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weatherAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherAppDataSet = new WeatherAppFInal.weatherAppDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_EditData = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbx_CityPicker = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bt_UpdateDGV = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(283, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // weatherAppDataSetBindingSource
            // 
            this.weatherAppDataSetBindingSource.DataSource = this.weatherAppDataSet;
            this.weatherAppDataSetBindingSource.Position = 0;
            // 
            // weatherAppDataSet
            // 
            this.weatherAppDataSet.DataSetName = "weatherAppDataSet";
            this.weatherAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(328, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_EditData,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // TSMI_EditData
            // 
            this.TSMI_EditData.Name = "TSMI_EditData";
            this.TSMI_EditData.Size = new System.Drawing.Size(121, 22);
            this.TSMI_EditData.Text = "Edit Data";
            this.TSMI_EditData.Click += new System.EventHandler(this.TSMI_EditData_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.printToolStripMenuItem.Text = "Print ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.weatherAppDataSetBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(1, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 329);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.Location = new System.Drawing.Point(21, 169);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_StartDate.TabIndex = 0;
            // 
            // DTP_EndDate
            // 
            this.DTP_EndDate.Location = new System.Drawing.Point(21, 225);
            this.DTP_EndDate.Name = "DTP_EndDate";
            this.DTP_EndDate.Size = new System.Drawing.Size(200, 20);
            this.DTP_EndDate.TabIndex = 1;
            // 
            // cmbx_CityPicker
            // 
            this.cmbx_CityPicker.FormattingEnabled = true;
            this.cmbx_CityPicker.Location = new System.Drawing.Point(21, 78);
            this.cmbx_CityPicker.Name = "cmbx_CityPicker";
            this.cmbx_CityPicker.Size = new System.Drawing.Size(199, 21);
            this.cmbx_CityPicker.TabIndex = 2;
            this.cmbx_CityPicker.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select City you want to Query for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Two";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_UpdateDGV
            // 
            this.bt_UpdateDGV.Location = new System.Drawing.Point(3, 352);
            this.bt_UpdateDGV.Name = "bt_UpdateDGV";
            this.bt_UpdateDGV.Size = new System.Drawing.Size(98, 23);
            this.bt_UpdateDGV.TabIndex = 8;
            this.bt_UpdateDGV.Text = "Update DGV";
            this.bt_UpdateDGV.UseVisualStyleBackColor = true;
            this.bt_UpdateDGV.Click += new System.EventHandler(this.bt_UpdateDGV_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(47, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.bt_UpdateDGV);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.cmbx_CityPicker);
            this.panel2.Controls.Add(this.DTP_EndDate);
            this.panel2.Controls.Add(this.DTP_StartDate);
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 348);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // generateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "generateData";
            this.Text = "generateData";
            this.Load += new System.EventHandler(this.generateData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource weatherAppDataSetBindingSource;
        private weatherAppDataSet weatherAppDataSet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_EditData;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.DateTimePicker DTP_EndDate;
        private System.Windows.Forms.ComboBox cmbx_CityPicker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bt_UpdateDGV;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
    }
}