namespace PasswordManager.Forms
{
    partial class SetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPassword));
            this.newPw_Label = new System.Windows.Forms.Label();
            this.newPw_Textbox = new System.Windows.Forms.TextBox();
            this.setPw_Button = new System.Windows.Forms.Button();
            this.generateRndPw_Button = new System.Windows.Forms.Button();
            this.newPwRep_Textbox = new System.Windows.Forms.TextBox();
            this.newPwRep_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPw_Label
            // 
            this.newPw_Label.AutoSize = true;
            this.newPw_Label.Location = new System.Drawing.Point(149, 17);
            this.newPw_Label.Name = "newPw_Label";
            this.newPw_Label.Size = new System.Drawing.Size(99, 17);
            this.newPw_Label.TabIndex = 4;
            this.newPw_Label.Text = "New password";
            // 
            // newPw_Textbox
            // 
            this.newPw_Textbox.Location = new System.Drawing.Point(12, 12);
            this.newPw_Textbox.Name = "newPw_Textbox";
            this.newPw_Textbox.Size = new System.Drawing.Size(131, 22);
            this.newPw_Textbox.TabIndex = 0;
            this.newPw_Textbox.UseSystemPasswordChar = true;
            this.newPw_Textbox.MouseHover += new System.EventHandler(this.Password_Textbox_MouseHover);
            // 
            // setPw_Button
            // 
            this.setPw_Button.Location = new System.Drawing.Point(230, 78);
            this.setPw_Button.Name = "setPw_Button";
            this.setPw_Button.Size = new System.Drawing.Size(121, 32);
            this.setPw_Button.TabIndex = 2;
            this.setPw_Button.Text = "Set password";
            this.setPw_Button.UseVisualStyleBackColor = true;
            this.setPw_Button.Click += new System.EventHandler(this.SetPw_Button_Click);
            // 
            // generateRndPw_Button
            // 
            this.generateRndPw_Button.Location = new System.Drawing.Point(12, 78);
            this.generateRndPw_Button.Name = "generateRndPw_Button";
            this.generateRndPw_Button.Size = new System.Drawing.Size(212, 32);
            this.generateRndPw_Button.TabIndex = 3;
            this.generateRndPw_Button.Text = "Generate random password";
            this.generateRndPw_Button.UseVisualStyleBackColor = true;
            this.generateRndPw_Button.Click += new System.EventHandler(this.GenerateRndPw_Button_Click);
            // 
            // newPwRep_Textbox
            // 
            this.newPwRep_Textbox.Location = new System.Drawing.Point(12, 40);
            this.newPwRep_Textbox.Name = "newPwRep_Textbox";
            this.newPwRep_Textbox.Size = new System.Drawing.Size(131, 22);
            this.newPwRep_Textbox.TabIndex = 1;
            this.newPwRep_Textbox.UseSystemPasswordChar = true;
            this.newPwRep_Textbox.MouseHover += new System.EventHandler(this.Password_Textbox_MouseHover);
            // 
            // newPwRep_Label
            // 
            this.newPwRep_Label.AutoSize = true;
            this.newPwRep_Label.Location = new System.Drawing.Point(149, 43);
            this.newPwRep_Label.Name = "newPwRep_Label";
            this.newPwRep_Label.Size = new System.Drawing.Size(147, 17);
            this.newPwRep_Label.TabIndex = 10;
            this.newPwRep_Label.Text = "Repeat new password";
            // 
            // SetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 123);
            this.Controls.Add(this.newPwRep_Label);
            this.Controls.Add(this.newPwRep_Textbox);
            this.Controls.Add(this.generateRndPw_Button);
            this.Controls.Add(this.setPw_Button);
            this.Controls.Add(this.newPw_Textbox);
            this.Controls.Add(this.newPw_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 170);
            this.MinimumSize = new System.Drawing.Size(400, 170);
            this.Name = "SetPassword";
            this.Text = "Set Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newPw_Label;
        private System.Windows.Forms.TextBox newPw_Textbox;
        private System.Windows.Forms.Button setPw_Button;
        private System.Windows.Forms.Button generateRndPw_Button;
        private System.Windows.Forms.TextBox newPwRep_Textbox;
        private System.Windows.Forms.Label newPwRep_Label;
    }
}