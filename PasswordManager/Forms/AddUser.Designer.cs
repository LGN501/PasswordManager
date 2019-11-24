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
            this.sites_TreeView = new System.Windows.Forms.TreeView();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.selectedSite_Label = new System.Windows.Forms.Label();
            this.addUser_Button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.generateRndPw_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sites_TreeView
            // 
            this.sites_TreeView.Location = new System.Drawing.Point(12, 12);
            this.sites_TreeView.Name = "sites_TreeView";
            this.sites_TreeView.Size = new System.Drawing.Size(148, 216);
            this.sites_TreeView.TabIndex = 2;
            this.sites_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Sites_TreeView_AfterSelect);
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(169, 59);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(164, 22);
            this.username_TextBox.TabIndex = 4;
            this.username_TextBox.Text = "Username";
            this.username_TextBox.GotFocus += new System.EventHandler(this.username_TextBox_GotFocus);
            this.username_TextBox.LostFocus += new System.EventHandler(this.username_TextBox_LostFocus);
            // 
            // selectedSite_Label
            // 
            this.selectedSite_Label.AutoSize = true;
            this.selectedSite_Label.Location = new System.Drawing.Point(166, 12);
            this.selectedSite_Label.Name = "selectedSite_Label";
            this.selectedSite_Label.Size = new System.Drawing.Size(93, 17);
            this.selectedSite_Label.TabIndex = 5;
            this.selectedSite_Label.Text = "Selected site:";
            // 
            // addUser_Button
            // 
            this.addUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_Button.Location = new System.Drawing.Point(339, 12);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(86, 216);
            this.addUser_Button.TabIndex = 9;
            this.addUser_Button.Text = "Confirm";
            this.addUser_Button.UseVisualStyleBackColor = true;
            this.addUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(169, 87);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(164, 22);
            this.password_TextBox.TabIndex = 11;
            this.password_TextBox.Text = "Password";
            this.password_TextBox.GotFocus += new System.EventHandler(this.password_TextBox_GotFocus);
            this.password_TextBox.LostFocus += new System.EventHandler(this.password_TextBox_LostFocus);
            this.password_TextBox.MouseHover += new System.EventHandler(this.password_Textbox_MouseHover);
            // 
            // generateRndPw_Button
            // 
            this.generateRndPw_Button.Location = new System.Drawing.Point(169, 182);
            this.generateRndPw_Button.Name = "generateRndPw_Button";
            this.generateRndPw_Button.Size = new System.Drawing.Size(164, 46);
            this.generateRndPw_Button.TabIndex = 12;
            this.generateRndPw_Button.Text = "Generate random password";
            this.generateRndPw_Button.UseVisualStyleBackColor = true;
            this.generateRndPw_Button.Click += new System.EventHandler(this.GenerateRndPw_Button_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 241);
            this.Controls.Add(this.generateRndPw_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.addUser_Button);
            this.Controls.Add(this.selectedSite_Label);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.sites_TreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView sites_TreeView;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.Label selectedSite_Label;
        private System.Windows.Forms.Button addUser_Button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button generateRndPw_Button;
    }
}