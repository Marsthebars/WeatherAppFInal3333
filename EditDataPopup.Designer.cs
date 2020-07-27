namespace WeatherAppFInal
{
    partial class EditDataPopup
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DGV_DisplayEditData = new System.Windows.Forms.DataGridView();
            this.cmbx_selectCityEdit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DisplayEditData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Bt_delete
            // 
            this.Bt_delete.Location = new System.Drawing.Point(25, 206);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(75, 23);
            this.Bt_delete.TabIndex = 3;
            this.Bt_delete.Text = "Delete ";
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // DGV_DisplayEditData
            // 
            this.DGV_DisplayEditData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DisplayEditData.Location = new System.Drawing.Point(181, 57);
            this.DGV_DisplayEditData.Name = "DGV_DisplayEditData";
            this.DGV_DisplayEditData.Size = new System.Drawing.Size(590, 342);
            this.DGV_DisplayEditData.TabIndex = 5;
            this.DGV_DisplayEditData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DisplayEditData_CellContentClick);
            // 
            // cmbx_selectCityEdit
            // 
            this.cmbx_selectCityEdit.FormattingEnabled = true;
            this.cmbx_selectCityEdit.Location = new System.Drawing.Point(13, 57);
            this.cmbx_selectCityEdit.Name = "cmbx_selectCityEdit";
            this.cmbx_selectCityEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbx_selectCityEdit.TabIndex = 6;
            this.cmbx_selectCityEdit.SelectedIndexChanged += new System.EventHandler(this.cmbx_selectCityEdit_SelectedIndexChanged);
            // 
            // EditDataPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbx_selectCityEdit);
            this.Controls.Add(this.DGV_DisplayEditData);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Bt_delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EditDataPopup";
            this.Text = "EditDataPopup";
            this.Load += new System.EventHandler(this.EditDataPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DisplayEditData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView DGV_DisplayEditData;
        private System.Windows.Forms.ComboBox cmbx_selectCityEdit;
    }
}