namespace IOOP_Assignment
{
    partial class Chef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            this.panel_footerbar = new System.Windows.Forms.Panel();
            this.linklbl_chefhomepage = new System.Windows.Forms.LinkLabel();
            this.linklbl_backtologin = new System.Windows.Forms.LinkLabel();
            this.btn_vieworder = new System.Windows.Forms.Button();
            this.btn_updateprofile = new System.Windows.Forms.Button();
            this.btn_viewinventory = new System.Windows.Forms.Button();
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.uc_viewupdateorder = new IOOP_Assignment.ChefViewOrder();
            this.uc_viewinventory = new IOOP_Assignment.ChefViewInventory();
            this.uc_updateprofile = new IOOP_Assignment.UpdateProfile();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panel_footerbar.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_footerbar
            // 
            this.panel_footerbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_footerbar.Controls.Add(this.linklbl_chefhomepage);
            this.panel_footerbar.Controls.Add(this.linklbl_backtologin);
            this.panel_footerbar.Location = new System.Drawing.Point(0, 899);
            this.panel_footerbar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footerbar.Name = "panel_footerbar";
            this.panel_footerbar.Size = new System.Drawing.Size(1900, 112);
            this.panel_footerbar.TabIndex = 23;
            // 
            // linklbl_chefhomepage
            // 
            this.linklbl_chefhomepage.AutoSize = true;
            this.linklbl_chefhomepage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_chefhomepage.Location = new System.Drawing.Point(141, 48);
            this.linklbl_chefhomepage.Name = "linklbl_chefhomepage";
            this.linklbl_chefhomepage.Size = new System.Drawing.Size(300, 32);
            this.linklbl_chefhomepage.TabIndex = 6;
            this.linklbl_chefhomepage.TabStop = true;
            this.linklbl_chefhomepage.Text = "Back to chef homepage";
            this.linklbl_chefhomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_chefhomepage_LinkClicked);
            // 
            // linklbl_backtologin
            // 
            this.linklbl_backtologin.AutoSize = true;
            this.linklbl_backtologin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_backtologin.Location = new System.Drawing.Point(1628, 48);
            this.linklbl_backtologin.Name = "linklbl_backtologin";
            this.linklbl_backtologin.Size = new System.Drawing.Size(171, 32);
            this.linklbl_backtologin.TabIndex = 5;
            this.linklbl_backtologin.TabStop = true;
            this.linklbl_backtologin.Text = "Back to login";
            this.linklbl_backtologin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_backtologin_LinkClicked);
            // 
            // btn_vieworder
            // 
            this.btn_vieworder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_vieworder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vieworder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vieworder.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_vieworder.ForeColor = System.Drawing.Color.White;
            this.btn_vieworder.Location = new System.Drawing.Point(147, 460);
            this.btn_vieworder.Name = "btn_vieworder";
            this.btn_vieworder.Size = new System.Drawing.Size(370, 370);
            this.btn_vieworder.TabIndex = 22;
            this.btn_vieworder.Text = "View && Update\r\nOrder";
            this.btn_vieworder.UseVisualStyleBackColor = false;
            this.btn_vieworder.Click += new System.EventHandler(this.btn_vieworder_Click);
            // 
            // btn_updateprofile
            // 
            this.btn_updateprofile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_updateprofile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_updateprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateprofile.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_updateprofile.ForeColor = System.Drawing.Color.White;
            this.btn_updateprofile.Location = new System.Drawing.Point(1429, 460);
            this.btn_updateprofile.Name = "btn_updateprofile";
            this.btn_updateprofile.Size = new System.Drawing.Size(370, 370);
            this.btn_updateprofile.TabIndex = 21;
            this.btn_updateprofile.Text = "Update your profile";
            this.btn_updateprofile.UseVisualStyleBackColor = false;
            this.btn_updateprofile.Click += new System.EventHandler(this.btn_updateprofile_Click);
            // 
            // btn_viewinventory
            // 
            this.btn_viewinventory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_viewinventory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_viewinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewinventory.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_viewinventory.ForeColor = System.Drawing.Color.White;
            this.btn_viewinventory.Location = new System.Drawing.Point(813, 460);
            this.btn_viewinventory.Name = "btn_viewinventory";
            this.btn_viewinventory.Size = new System.Drawing.Size(370, 370);
            this.btn_viewinventory.TabIndex = 20;
            this.btn_viewinventory.Text = "View && Manage\r\nInventory\r\n";
            this.btn_viewinventory.UseVisualStyleBackColor = false;
            this.btn_viewinventory.Click += new System.EventHandler(this.btn_viewinventory_Click);
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_greetings.Location = new System.Drawing.Point(428, 85);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Size = new System.Drawing.Size(1113, 279);
            this.lbl_greetings.TabIndex = 24;
            this.lbl_greetings.Text = "Welcome, Chef!\r\n\r\nSelect an option to proceed:";
            this.lbl_greetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uc_viewupdateorder
            // 
            this.uc_viewupdateorder.Location = new System.Drawing.Point(0, 0);
            this.uc_viewupdateorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_viewupdateorder.Name = "uc_viewupdateorder";
            this.uc_viewupdateorder.Size = new System.Drawing.Size(1900, 913);
            this.uc_viewupdateorder.TabIndex = 25;
            // 
            // uc_viewinventory
            // 
            this.uc_viewinventory.Location = new System.Drawing.Point(0, 0);
            this.uc_viewinventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_viewinventory.Name = "uc_viewinventory";
            this.uc_viewinventory.Size = new System.Drawing.Size(1900, 913);
            this.uc_viewinventory.TabIndex = 26;
            // 
            // uc_updateprofile
            // 
            this.uc_updateprofile.Location = new System.Drawing.Point(0, 0);
            this.uc_updateprofile.Name = "uc_updateprofile";
            this.uc_updateprofile.Size = new System.Drawing.Size(1900, 913);
            this.uc_updateprofile.TabIndex = 27;
            this.uc_updateprofile.Username = null;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.lbl_greetings);
            this.panelBackground.Controls.Add(this.btn_viewinventory);
            this.panelBackground.Controls.Add(this.btn_vieworder);
            this.panelBackground.Controls.Add(this.btn_updateprofile);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1900, 913);
            this.panelBackground.TabIndex = 28;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.panel_footerbar);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.uc_viewupdateorder);
            this.Controls.Add(this.uc_updateprofile);
            this.Controls.Add(this.uc_viewinventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef";
            this.panel_footerbar.ResumeLayout(false);
            this.panel_footerbar.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_footerbar;
        private System.Windows.Forms.LinkLabel linklbl_chefhomepage;
        private System.Windows.Forms.LinkLabel linklbl_backtologin;
        private System.Windows.Forms.Button btn_vieworder;
        private System.Windows.Forms.Button btn_updateprofile;
        private System.Windows.Forms.Button btn_viewinventory;
        private System.Windows.Forms.Label lbl_greetings;
        private ChefViewOrder uc_viewupdateorder;
        private ChefViewInventory uc_viewinventory;
        private UpdateProfile uc_updateprofile;
        private System.Windows.Forms.Panel panelBackground;
    }
}