namespace WeatherAppFInal
{
    partial class LoginForm
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
            this.bt_Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LL_OpenRegForm = new System.Windows.Forms.LinkLabel();
            this.chbx_loginToggle = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(215, 131);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password ";
            // 
            // LL_OpenRegForm
            // 
            this.LL_OpenRegForm.AutoSize = true;
            this.LL_OpenRegForm.LinkColor = System.Drawing.Color.Black;
            this.LL_OpenRegForm.Location = new System.Drawing.Point(124, 171);
            this.LL_OpenRegForm.Name = "LL_OpenRegForm";
            this.LL_OpenRegForm.Size = new System.Drawing.Size(154, 13);
            this.LL_OpenRegForm.TabIndex = 5;
            this.LL_OpenRegForm.TabStop = true;
            this.LL_OpenRegForm.Text = "Click here to register a account";
            this.LL_OpenRegForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_OpenRegForm_LinkClicked);
            // 
            // chbx_loginToggle
            // 
            this.chbx_loginToggle.AutoSize = true;
            this.chbx_loginToggle.Location = new System.Drawing.Point(209, 108);
            this.chbx_loginToggle.Name = "chbx_loginToggle";
            this.chbx_loginToggle.Size = new System.Drawing.Size(46, 17);
            this.chbx_loginToggle.TabIndex = 6;
            this.chbx_loginToggle.Text = "user";
            this.chbx_loginToggle.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Forcastex";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 223);
            this.Controls.Add(this.chbx_loginToggle);
            this.Controls.Add(this.LL_OpenRegForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_Login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LL_OpenRegForm;
        private System.Windows.Forms.CheckBox chbx_loginToggle;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}