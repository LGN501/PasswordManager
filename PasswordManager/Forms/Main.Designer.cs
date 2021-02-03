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
            this.changePw_Button = new System.Windows.Forms.Button();
            this.changeUsr_Button = new System.Windows.Forms.Button();
            this.showPw_Button = new System.Windows.Forms.Button();
            this.generatePw_Button = new System.Windows.Forms.Button();
            this.options_GroupBox = new System.Windows.Forms.GroupBox();
            this.addUser_Button = new System.Windows.Forms.Button();
            this.deleteUsr_Button = new System.Windows.Forms.Button();
            this.deleteSite_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudStatus_Label = new System.Windows.Forms.Label();
            this.options_GroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // site_TreeView
            // 
            this.site_TreeView.Location = new System.Drawing.Point(12, 56);
            this.site_TreeView.Name = "site_TreeView";
            this.site_TreeView.Size = new System.Drawing.Size(250, 353);
            this.site_TreeView.TabIndex = 0;
            this.site_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Site_TreeView_AfterSelect);
            // 
            // selectedSite_Label
            // 
            this.selectedSite_Label.AutoSize = true;
            this.selectedSite_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSite_Label.Location = new System.Drawing.Point(7, 28);
            this.selectedSite_Label.Name = "selectedSite_Label";
            this.selectedSite_Label.Size = new System.Drawing.Size(130, 25);
            this.selectedSite_Label.TabIndex = 1;
            this.selectedSite_Label.Text = "Selected site:";
            // 
            // addSite_Button
            // 
            this.addSite_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSite_Button.Location = new System.Drawing.Point(12, 415);
            this.addSite_Button.Name = "addSite_Button";
            this.addSite_Button.Size = new System.Drawing.Size(250, 41);
            this.addSite_Button.TabIndex = 2;
            this.addSite_Button.Text = "Add site";
            this.addSite_Button.UseVisualStyleBackColor = true;
            this.addSite_Button.Click += new System.EventHandler(this.AddSite_Button_Click);
            // 
            // copyPw_Button
            // 
            this.copyPw_Button.Enabled = false;
            this.copyPw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPw_Button.Location = new System.Drawing.Point(6, 166);
            this.copyPw_Button.Name = "copyPw_Button";
            this.copyPw_Button.Size = new System.Drawing.Size(270, 31);
            this.copyPw_Button.TabIndex = 3;
            this.copyPw_Button.Text = "Copy password to clipboard";
            this.copyPw_Button.UseVisualStyleBackColor = true;
            this.copyPw_Button.Visible = false;
            this.copyPw_Button.Click += new System.EventHandler(this.CopyPw_Button_Click);
            // 
            // changePw_Button
            // 
            this.changePw_Button.Enabled = false;
            this.changePw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePw_Button.Location = new System.Drawing.Point(6, 117);
            this.changePw_Button.Name = "changePw_Button";
            this.changePw_Button.Size = new System.Drawing.Size(270, 31);
            this.changePw_Button.TabIndex = 6;
            this.changePw_Button.Text = "Change password";
            this.changePw_Button.UseVisualStyleBackColor = true;
            this.changePw_Button.Visible = false;
            this.changePw_Button.Click += new System.EventHandler(this.ChangePw_Button_Click);
            // 
            // changeUsr_Button
            // 
            this.changeUsr_Button.Enabled = false;
            this.changeUsr_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsr_Button.Location = new System.Drawing.Point(6, 80);
            this.changeUsr_Button.Name = "changeUsr_Button";
            this.changeUsr_Button.Size = new System.Drawing.Size(270, 31);
            this.changeUsr_Button.TabIndex = 7;
            this.changeUsr_Button.Text = "Change username (soon)";
            this.changeUsr_Button.UseVisualStyleBackColor = true;
            this.changeUsr_Button.Visible = false;
            // 
            // showPw_Button
            // 
            this.showPw_Button.Enabled = false;
            this.showPw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPw_Button.Location = new System.Drawing.Point(6, 203);
            this.showPw_Button.Name = "showPw_Button";
            this.showPw_Button.Size = new System.Drawing.Size(270, 31);
            this.showPw_Button.TabIndex = 8;
            this.showPw_Button.Text = "Show password";
            this.showPw_Button.UseVisualStyleBackColor = true;
            this.showPw_Button.Visible = false;
            this.showPw_Button.Click += new System.EventHandler(this.ShowPw_Button_Click);
            // 
            // generatePw_Button
            // 
            this.generatePw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePw_Button.Location = new System.Drawing.Point(268, 334);
            this.generatePw_Button.Name = "generatePw_Button";
            this.generatePw_Button.Size = new System.Drawing.Size(282, 122);
            this.generatePw_Button.TabIndex = 9;
            this.generatePw_Button.Text = "Generate Random Password";
            this.generatePw_Button.UseVisualStyleBackColor = true;
            this.generatePw_Button.Click += new System.EventHandler(this.GeneratePw_Button_Click);
            // 
            // options_GroupBox
            // 
            this.options_GroupBox.Controls.Add(this.addUser_Button);
            this.options_GroupBox.Controls.Add(this.deleteUsr_Button);
            this.options_GroupBox.Controls.Add(this.showPw_Button);
            this.options_GroupBox.Controls.Add(this.deleteSite_Button);
            this.options_GroupBox.Controls.Add(this.changeUsr_Button);
            this.options_GroupBox.Controls.Add(this.copyPw_Button);
            this.options_GroupBox.Controls.Add(this.changePw_Button);
            this.options_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_GroupBox.Location = new System.Drawing.Point(268, 42);
            this.options_GroupBox.Name = "options_GroupBox";
            this.options_GroupBox.Size = new System.Drawing.Size(282, 286);
            this.options_GroupBox.TabIndex = 10;
            this.options_GroupBox.TabStop = false;
            // 
            // addUser_Button
            // 
            this.addUser_Button.Enabled = false;
            this.addUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.addUser_Button.Location = new System.Drawing.Point(6, 117);
            this.addUser_Button.Name = "addUser_Button";
            this.addUser_Button.Size = new System.Drawing.Size(270, 31);
            this.addUser_Button.TabIndex = 12;
            this.addUser_Button.Text = "Add user";
            this.addUser_Button.UseVisualStyleBackColor = true;
            this.addUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // deleteUsr_Button
            // 
            this.deleteUsr_Button.Enabled = false;
            this.deleteUsr_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUsr_Button.Location = new System.Drawing.Point(6, 249);
            this.deleteUsr_Button.Name = "deleteUsr_Button";
            this.deleteUsr_Button.Size = new System.Drawing.Size(270, 31);
            this.deleteUsr_Button.TabIndex = 9;
            this.deleteUsr_Button.Text = "Delete user";
            this.deleteUsr_Button.UseVisualStyleBackColor = true;
            this.deleteUsr_Button.Visible = false;
            this.deleteUsr_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // deleteSite_Button
            // 
            this.deleteSite_Button.Enabled = false;
            this.deleteSite_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.deleteSite_Button.Location = new System.Drawing.Point(6, 80);
            this.deleteSite_Button.Name = "deleteSite_Button";
            this.deleteSite_Button.Size = new System.Drawing.Size(270, 31);
            this.deleteSite_Button.TabIndex = 11;
            this.deleteSite_Button.Text = "Delete site";
            this.deleteSite_Button.UseVisualStyleBackColor = true;
            this.deleteSite_Button.Click += new System.EventHandler(this.DeleteSite_Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUpdateToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.updateToolStripMenuItem.Text = "Cloud";
            // 
            // autoUpdateToolStripMenuItem
            // 
            this.autoUpdateToolStripMenuItem.Name = "autoUpdateToolStripMenuItem";
            this.autoUpdateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autoUpdateToolStripMenuItem.Text = "Auto Update";
            this.autoUpdateToolStripMenuItem.Click += new System.EventHandler(this.AutoUpdateToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.UploadToolStripMenuItem_Click_1);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.DownloadToolStripMenuItem_Click_1);
            // 
            // cloudStatus_Label
            // 
            this.cloudStatus_Label.AutoSize = true;
            this.cloudStatus_Label.Location = new System.Drawing.Point(12, 459);
            this.cloudStatus_Label.Name = "cloudStatus_Label";
            this.cloudStatus_Label.Size = new System.Drawing.Size(90, 17);
            this.cloudStatus_Label.TabIndex = 12;
            this.cloudStatus_Label.Text = "Cloud status:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 488);
            this.Controls.Add(this.cloudStatus_Label);
            this.Controls.Add(this.options_GroupBox);
            this.Controls.Add(this.generatePw_Button);
            this.Controls.Add(this.addSite_Button);
            this.Controls.Add(this.selectedSite_Label);
            this.Controls.Add(this.site_TreeView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Password Manager";
            this.options_GroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView site_TreeView;
        private System.Windows.Forms.Label selectedSite_Label;
        private System.Windows.Forms.Button addSite_Button;
        private System.Windows.Forms.Button copyPw_Button;
        private System.Windows.Forms.Button changePw_Button;
        private System.Windows.Forms.Button changeUsr_Button;
        private System.Windows.Forms.Button showPw_Button;
        private System.Windows.Forms.Button generatePw_Button;
        private System.Windows.Forms.GroupBox options_GroupBox;
        private System.Windows.Forms.Button deleteUsr_Button;
        private System.Windows.Forms.Button deleteSite_Button;
        private System.Windows.Forms.Button addUser_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.Label cloudStatus_Label;
    }
}