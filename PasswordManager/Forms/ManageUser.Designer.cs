namespace PasswordManager.Forms
{
    partial class ManageUser
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
            this.user_GroupBox = new System.Windows.Forms.GroupBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.changePw_Button = new System.Windows.Forms.Button();
            this.changeUsr_Button = new System.Windows.Forms.Button();
            this.showPw_Button = new System.Windows.Forms.Button();
            this.copyPw_Button = new System.Windows.Forms.Button();
            this.username_Label = new System.Windows.Forms.Label();
            this.user_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_GroupBox
            // 
            this.user_GroupBox.Controls.Add(this.delete_Button);
            this.user_GroupBox.Controls.Add(this.changePw_Button);
            this.user_GroupBox.Controls.Add(this.changeUsr_Button);
            this.user_GroupBox.Controls.Add(this.showPw_Button);
            this.user_GroupBox.Controls.Add(this.copyPw_Button);
            this.user_GroupBox.Enabled = false;
            this.user_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_GroupBox.Location = new System.Drawing.Point(139, 58);
            this.user_GroupBox.Name = "user_GroupBox";
            this.user_GroupBox.Size = new System.Drawing.Size(254, 272);
            this.user_GroupBox.TabIndex = 11;
            this.user_GroupBox.TabStop = false;
            // 
            // delete_Button
            // 
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(6, 225);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(243, 31);
            this.delete_Button.TabIndex = 9;
            this.delete_Button.Text = "Delete user";
            this.delete_Button.UseVisualStyleBackColor = true;
            // 
            // changePw_Button
            // 
            this.changePw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePw_Button.Location = new System.Drawing.Point(6, 21);
            this.changePw_Button.Name = "changePw_Button";
            this.changePw_Button.Size = new System.Drawing.Size(243, 31);
            this.changePw_Button.TabIndex = 6;
            this.changePw_Button.Text = "Change password";
            this.changePw_Button.UseVisualStyleBackColor = true;
            // 
            // changeUsr_Button
            // 
            this.changeUsr_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsr_Button.Location = new System.Drawing.Point(6, 58);
            this.changeUsr_Button.Name = "changeUsr_Button";
            this.changeUsr_Button.Size = new System.Drawing.Size(243, 31);
            this.changeUsr_Button.TabIndex = 7;
            this.changeUsr_Button.Text = "Change username (soon)";
            this.changeUsr_Button.UseVisualStyleBackColor = true;
            // 
            // showPw_Button
            // 
            this.showPw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPw_Button.Location = new System.Drawing.Point(6, 161);
            this.showPw_Button.Name = "showPw_Button";
            this.showPw_Button.Size = new System.Drawing.Size(243, 31);
            this.showPw_Button.TabIndex = 8;
            this.showPw_Button.Text = "Show password";
            this.showPw_Button.UseVisualStyleBackColor = true;
            // 
            // copyPw_Button
            // 
            this.copyPw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPw_Button.Location = new System.Drawing.Point(6, 124);
            this.copyPw_Button.Name = "copyPw_Button";
            this.copyPw_Button.Size = new System.Drawing.Size(243, 31);
            this.copyPw_Button.TabIndex = 3;
            this.copyPw_Button.Text = "Copy password to clipboard";
            this.copyPw_Button.UseVisualStyleBackColor = true;
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(573, 108);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(0, 17);
            this.username_Label.TabIndex = 12;
            // 
            // ManagaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.user_GroupBox);
            this.Name = "ManagaUser";
            this.Text = "ManagaUser";
            this.user_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox user_GroupBox;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button changePw_Button;
        private System.Windows.Forms.Button changeUsr_Button;
        private System.Windows.Forms.Button showPw_Button;
        private System.Windows.Forms.Button copyPw_Button;
        private System.Windows.Forms.Label username_Label;
    }
}