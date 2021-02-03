namespace PasswordManager.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginPw_Textbox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.title_Label = new System.Windows.Forms.Label();
            this.start_Label = new System.Windows.Forms.Label();
            this.downloadCloud_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginPw_Textbox
            // 
            this.loginPw_Textbox.Location = new System.Drawing.Point(133, 207);
            this.loginPw_Textbox.Name = "loginPw_Textbox";
            this.loginPw_Textbox.PasswordChar = '*';
            this.loginPw_Textbox.Size = new System.Drawing.Size(97, 22);
            this.loginPw_Textbox.TabIndex = 0;
            this.loginPw_Textbox.UseSystemPasswordChar = true;
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(133, 151);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(97, 50);
            this.login_Button.TabIndex = 1;
            this.login_Button.Text = "Log in";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // title_Label
            // 
            this.title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_Label.AutoSize = true;
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.Location = new System.Drawing.Point(52, 9);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(258, 64);
            this.title_Label.TabIndex = 2;
            this.title_Label.Text = "Welcome\r\nPassword Manager";
            this.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_Label
            // 
            this.start_Label.AutoSize = true;
            this.start_Label.Location = new System.Drawing.Point(12, 131);
            this.start_Label.Name = "start_Label";
            this.start_Label.Size = new System.Drawing.Size(361, 17);
            this.start_Label.TabIndex = 3;
            this.start_Label.Text = "Looks like it\'s the first time you start Password Manager.";
            this.start_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.start_Label.Visible = false;
            // 
            // downloadCloud_Button
            // 
            this.downloadCloud_Button.Enabled = false;
            this.downloadCloud_Button.Location = new System.Drawing.Point(133, 235);
            this.downloadCloud_Button.Name = "downloadCloud_Button";
            this.downloadCloud_Button.Size = new System.Drawing.Size(97, 56);
            this.downloadCloud_Button.TabIndex = 5;
            this.downloadCloud_Button.Text = "Download from cloud";
            this.downloadCloud_Button.UseVisualStyleBackColor = true;
            this.downloadCloud_Button.Visible = false;
            this.downloadCloud_Button.Click += new System.EventHandler(this.DownloadCloud_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.downloadCloud_Button);
            this.Controls.Add(this.start_Label);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.loginPw_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginPw_Textbox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Label start_Label;
        private System.Windows.Forms.Button downloadCloud_Button;
    }
}