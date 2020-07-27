namespace WeatherAppFInal
{
    partial class Regform
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
            this.txt_RegisterPassword = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_RegisterPassword
            // 
            this.txt_RegisterPassword.Location = new System.Drawing.Point(27, 92);
            this.txt_RegisterPassword.Name = "txt_RegisterPassword";
            this.txt_RegisterPassword.Size = new System.Drawing.Size(198, 20);
            this.txt_RegisterPassword.TabIndex = 5;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(28, 51);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(198, 20);
            this.txt_Username.TabIndex = 4;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(150, 148);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // Regform
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_RegisterPassword);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.bt_Login);
            this.Name = "Regform";
            this.Load += new System.EventHandler(this.Regform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RegPassword;
        private System.Windows.Forms.TextBox txt_RegUserName;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Button pword;
        private System.Windows.Forms.TextBox txt_RegisterPassword;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button bt_Login;
    }
}