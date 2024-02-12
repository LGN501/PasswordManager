namespace PasswordManager.Forms
{
    partial class ConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPassword));
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.ok_Button = new System.Windows.Forms.Button();
            this.operation_Label = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(12, 80);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(458, 22);
            this.password_Textbox.TabIndex = 0;
            this.password_Textbox.UseSystemPasswordChar = true;
            // 
            // ok_Button
            // 
            this.ok_Button.Location = new System.Drawing.Point(12, 108);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(226, 33);
            this.ok_Button.TabIndex = 2;
            this.ok_Button.Text = "Ok";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // operation_Label
            // 
            this.operation_Label.AutoSize = true;
            this.operation_Label.Location = new System.Drawing.Point(12, 9);
            this.operation_Label.Name = "operation_Label";
            this.operation_Label.Size = new System.Drawing.Size(198, 17);
            this.operation_Label.TabIndex = 3;
            this.operation_Label.Text = "Please re-enter app password";
            this.operation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(244, 108);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(226, 33);
            this.cancel_Button.TabIndex = 4;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.operation_Label);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.password_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "ConfirmPassword";
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.Label operation_Label;
        private System.Windows.Forms.Button cancel_Button;
    }
}