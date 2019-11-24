namespace PasswordManager.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.site_TreeView = new System.Windows.Forms.TreeView();
            this.selectedSite_Label = new System.Windows.Forms.Label();
            this.addSite_Button = new System.Windows.Forms.Button();
            this.copyPw_Button = new System.Windows.Forms.Button();
            this.addUser_Button = new System.Windows.Forms.Button();
            this.changePw_Button = new System.Windows.Forms.Button();
            this.changeUsr_Button = new System.Windows.Forms.Button();
            this.showPw_Button = new System.Windows.Forms.Button();
            this.generatePw_Button = new System.Windows.Forms.Button();
            this.user_GroupBox = new System.Windows.Forms.GroupBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.deleteSite_Button = new System.Windows.Forms.Button();
            this.user_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // site_TreeView
            // 
            this.site_TreeView.Location = new System.Drawing.Point(12, 37);
            this.site_TreeView.Name = "site_TreeView";
            this.site_TreeView.Size = new System.Drawing.Size(250, 353);
            this.site_TreeView.TabIndex = 0;
            this.site_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Site_TreeView_AfterSelect);
            // 
            // selectedSite_Label
            // 
            this.selectedSite_Label.AutoSize = true;
            this.selectedSite_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSite_Label.Location = new System.Drawing.Point(12, 9);
            this.selectedSite_Label.Name = "selectedSite_Label";
            this.selectedSite_Label.Size = new System.Drawing.Size(130, 25);
            this.selectedSite_Label.TabIndex = 1;
            this.selectedSite_Label.Text = "Selected site:";
            // 
            // addSite_Button
            // 
            this.addSite_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSite_Button.Location = new System.Drawing.Point(12, 396);
            this.addSite_Button.Name = "addSite_Button";
            this.addSite_Button.Size = new System.Drawing.Size(125, 41);
            this.addSite_Button.TabIndex = 2;
            this.addSite_Button.Text = "Add site";
            this.addSite_Button.UseVisualStyleBackColor = true;
            this.addSite_Button.Click += new System.EventHandler(this.AddSite_Button_Click);
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
            this.copyPw_Button.Click += new System.EventHandler(this.CopyPw_Button_Click);
            // 
            // addUser_Button
            // 
            this.addUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser_Button.Location = new System.Drawing.Point(12, 440);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(250, 41);
            this.addUser_Button.TabIndex = 5;
            this.addUser_Button.Text = "Add user";
            this.addUser_Button.UseVisualStyleBackColor = true;
            this.addUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
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
            this.changePw_Button.Click += new System.EventHandler(this.ChangePw_Button_Click);
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
            this.showPw_Button.Click += new System.EventHandler(this.ShowPw_Button_Click);
            // 
            // generatePw_Button
            // 
            this.generatePw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePw_Button.Location = new System.Drawing.Point(268, 315);
            this.generatePw_Button.Name = "generatePw_Button";
            this.generatePw_Button.Size = new System.Drawing.Size(254, 75);
            this.generatePw_Button.TabIndex = 9;
            this.generatePw_Button.Text = "Generate Random Password";
            this.generatePw_Button.UseVisualStyleBackColor = true;
            this.generatePw_Button.Click += new System.EventHandler(this.GeneratePw_Button_Click);
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
            this.user_GroupBox.Location = new System.Drawing.Point(268, 37);
            this.user_GroupBox.Name = "user_GroupBox";
            this.user_GroupBox.Size = new System.Drawing.Size(254, 272);
            this.user_GroupBox.TabIndex = 10;
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
            this.delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // deleteSite_Button
            // 
            this.deleteSite_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSite_Button.Location = new System.Drawing.Point(137, 396);
            this.deleteSite_Button.Name = "deleteSite_Button";
            this.deleteSite_Button.Size = new System.Drawing.Size(125, 41);
            this.deleteSite_Button.TabIndex = 11;
            this.deleteSite_Button.Text = "Delete site";
            this.deleteSite_Button.UseVisualStyleBackColor = true;
            this.deleteSite_Button.Click += new System.EventHandler(this.DeleteSite_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 493);
            this.Controls.Add(this.deleteSite_Button);
            this.Controls.Add(this.user_GroupBox);
            this.Controls.Add(this.generatePw_Button);
            this.Controls.Add(this.addUser_Button);
            this.Controls.Add(this.addSite_Button);
            this.Controls.Add(this.selectedSite_Label);
            this.Controls.Add(this.site_TreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Password Manager";
            this.user_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView site_TreeView;
        private System.Windows.Forms.Label selectedSite_Label;
        private System.Windows.Forms.Button addSite_Button;
        private System.Windows.Forms.Button copyPw_Button;
        private System.Windows.Forms.Button addUser_Button;
        private System.Windows.Forms.Button changePw_Button;
        private System.Windows.Forms.Button changeUsr_Button;
        private System.Windows.Forms.Button showPw_Button;
        private System.Windows.Forms.Button generatePw_Button;
        private System.Windows.Forms.GroupBox user_GroupBox;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button deleteSite_Button;
    }
}