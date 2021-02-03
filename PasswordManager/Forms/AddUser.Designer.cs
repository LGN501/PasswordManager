namespace PasswordManager.Forms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.addUser_Button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.generateRndPw_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(12, 12);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(164, 22);
            this.username_TextBox.TabIndex = 0;
            this.username_TextBox.Text = "Username";
            this.username_TextBox.GotFocus += new System.EventHandler(this.username_TextBox_GotFocus);
            this.username_TextBox.LostFocus += new System.EventHandler(this.username_TextBox_LostFocus);
            // 
            // addUser_Button
            // 
            this.addUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_Button.Location = new System.Drawing.Point(182, 13);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(86, 113);
            this.addUser_Button.TabIndex = 2;
            this.addUser_Button.Text = "Confirm";
            this.addUser_Button.UseVisualStyleBackColor = true;
            this.addUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(12, 40);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(164, 22);
            this.password_TextBox.TabIndex = 1;
            this.password_TextBox.Text = "Password";
            this.password_TextBox.GotFocus += new System.EventHandler(this.password_TextBox_GotFocus);
            this.password_TextBox.LostFocus += new System.EventHandler(this.password_TextBox_LostFocus);
            this.password_TextBox.MouseHover += new System.EventHandler(this.password_Textbox_MouseHover);
            // 
            // generateRndPw_Button
            // 
            this.generateRndPw_Button.Location = new System.Drawing.Point(12, 80);
            this.generateRndPw_Button.Name = "generateRndPw_Button";
            this.generateRndPw_Button.Size = new System.Drawing.Size(164, 46);
            this.generateRndPw_Button.TabIndex = 3;
            this.generateRndPw_Button.Text = "Generate random password";
            this.generateRndPw_Button.UseVisualStyleBackColor = true;
            this.generateRndPw_Button.Click += new System.EventHandler(this.GenerateRndPw_Button_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 144);
            this.Controls.Add(this.generateRndPw_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.addUser_Button);
            this.Controls.Add(this.username_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.Button addUser_Button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button generateRndPw_Button;
    }
}