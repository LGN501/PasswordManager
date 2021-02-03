namespace PasswordManager.Forms
{
    partial class AddSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSite));
            this.siteName_Textbox = new System.Windows.Forms.TextBox();
            this.addSite_Label = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siteName_Textbox
            // 
            this.siteName_Textbox.Location = new System.Drawing.Point(12, 35);
            this.siteName_Textbox.MaxLength = 50;
            this.siteName_Textbox.Name = "siteName_Textbox";
            this.siteName_Textbox.Size = new System.Drawing.Size(181, 22);
            this.siteName_Textbox.TabIndex = 1;
            // 
            // addSite_Label
            // 
            this.addSite_Label.Location = new System.Drawing.Point(199, 35);
            this.addSite_Label.Name = "addSite_Label";
            this.addSite_Label.Size = new System.Drawing.Size(130, 23);
            this.addSite_Label.TabIndex = 2;
            this.addSite_Label.Text = "Add site";
            this.addSite_Label.UseVisualStyleBackColor = true;
            this.addSite_Label.Click += new System.EventHandler(this.AddSite_Label_Click);
            // 
            // AddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 84);
            this.Controls.Add(this.addSite_Label);
            this.Controls.Add(this.siteName_Textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSite";
            this.Text = "Add Site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox siteName_Textbox;
        private System.Windows.Forms.Button addSite_Label;
    }
}