namespace WeatherAppFInal
{
    partial class DataEditorForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.weatherAppDataSet = new WeatherAppFInal.weatherAppDataSet();
            this.weatherAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.bt_deleteEntry = new System.Windows.Forms.Button();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_selection = new System.Windows.Forms.Button();
            this.bt_SaveEdit = new System.Windows.Forms.Button();
            this.bt_tempUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weatherAppDataSet
            // 
            this.weatherAppDataSet.DataSetName = "weatherAppDataSet";
            this.weatherAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weatherAppDataSetBindingSource
            // 
            this.weatherAppDataSetBindingSource.DataSource = this.weatherAppDataSet;
            this.weatherAppDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_deleteEntry
            // 
            this.bt_deleteEntry.Location = new System.Drawing.Point(13, 60);
            this.bt_deleteEntry.Name = "bt_deleteEntry";
            this.bt_deleteEntry.Size = new System.Drawing.Size(121, 23);
            this.bt_deleteEntry.TabIndex = 3;
            this.bt_deleteEntry.Text = "Delete entry";
            this.bt_deleteEntry.UseVisualStyleBackColor = true;
            this.bt_deleteEntry.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(12, 220);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(121, 23);
            this.bt_test.TabIndex = 4;
            this.bt_test.Text = "test";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_selection
            // 
            this.bt_selection.Location = new System.Drawing.Point(13, 191);
            this.bt_selection.Name = "bt_selection";
            this.bt_selection.Size = new System.Drawing.Size(121, 23);
            this.bt_selection.TabIndex = 5;
            this.bt_selection.Text = "button3";
            this.bt_selection.UseVisualStyleBackColor = true;
            this.bt_selection.Click += new System.EventHandler(this.bt_selection_Click);
            // 
            // bt_SaveEdit
            // 
            this.bt_SaveEdit.Location = new System.Drawing.Point(13, 89);
            this.bt_SaveEdit.Name = "bt_SaveEdit";
            this.bt_SaveEdit.Size = new System.Drawing.Size(121, 23);
            this.bt_SaveEdit.TabIndex = 6;
            this.bt_SaveEdit.Text = "Save edit";
            this.bt_SaveEdit.UseVisualStyleBackColor = true;
            // 
            // bt_tempUpdate
            // 
            this.bt_tempUpdate.Location = new System.Drawing.Point(13, 119);
            this.bt_tempUpdate.Name = "bt_tempUpdate";
            this.bt_tempUpdate.Size = new System.Drawing.Size(120, 23);
            this.bt_tempUpdate.TabIndex = 7;
            this.bt_tempUpdate.Text = "Force update";
            this.bt_tempUpdate.UseVisualStyleBackColor = true;
            // 
            // DataEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 300);
            this.Controls.Add(this.bt_tempUpdate);
            this.Controls.Add(this.bt_SaveEdit);
            this.Controls.Add(this.bt_selection);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.bt_deleteEntry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataEditorForm";
            this.Text = "DataEditorForm";
            this.Load += new System.EventHandler(this.DataEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAppDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource weatherAppDataSetBindingSource;
        private weatherAppDataSet weatherAppDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_deleteEntry;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Button bt_selection;
        private System.Windows.Forms.Button bt_SaveEdit;
        private System.Windows.Forms.Button bt_tempUpdate;
    }
}