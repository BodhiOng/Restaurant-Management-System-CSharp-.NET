namespace IOOP_Assignment
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.linklbl_backtologin = new System.Windows.Forms.LinkLabel();
            this.panel_footerbar = new System.Windows.Forms.Panel();
            this.linklbl_adminhomepage = new System.Windows.Forms.LinkLabel();
            this.lbl_greetings = new System.Windows.Forms.Label();
            this.btn_functionality4 = new System.Windows.Forms.Button();
            this.btn_functionality3 = new System.Windows.Forms.Button();
            this.btn_functionality2 = new System.Windows.Forms.Button();
            this.btn_functionality1 = new System.Windows.Forms.Button();
            this.uc_viewfeedbacks = new IOOP_Assignment.AdminViewCustomerFeedbacks();
            this.uc_viewsalesreport = new IOOP_Assignment.AdminViewSalesReport();
            this.uc_manageusers = new IOOP_Assignment.AdminManageUsers();
            this.uc_updateprofile = new IOOP_Assignment.UpdateProfile();
            this.panel_footerbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbl_backtologin
            // 
            this.linklbl_backtologin.AutoSize = true;
            this.linklbl_backtologin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_backtologin.Location = new System.Drawing.Point(1626, 34);
            this.linklbl_backtologin.Name = "linklbl_backtologin";
            this.linklbl_backtologin.Size = new System.Drawing.Size(171, 32);
            this.linklbl_backtologin.TabIndex = 5;
            this.linklbl_backtologin.TabStop = true;
            this.linklbl_backtologin.Text = "Back to login";
            this.linklbl_backtologin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_backtologin_LinkClicked);
            // 
            // panel_footerbar
            // 
            this.panel_footerbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_footerbar.Controls.Add(this.linklbl_adminhomepage);
            this.panel_footerbar.Controls.Add(this.linklbl_backtologin);
            this.panel_footerbar.Location = new System.Drawing.Point(0, 910);
            this.panel_footerbar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footerbar.Name = "panel_footerbar";
            this.panel_footerbar.Size = new System.Drawing.Size(1900, 112);
            this.panel_footerbar.TabIndex = 6;
            // 
            // linklbl_adminhomepage
            // 
            this.linklbl_adminhomepage.AutoSize = true;
            this.linklbl_adminhomepage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_adminhomepage.Location = new System.Drawing.Point(145, 34);
            this.linklbl_adminhomepage.Name = "linklbl_adminhomepage";
            this.linklbl_adminhomepage.Size = new System.Drawing.Size(225, 32);
            this.linklbl_adminhomepage.TabIndex = 6;
            this.linklbl_adminhomepage.TabStop = true;
            this.linklbl_adminhomepage.Text = "Admin homepage";
            this.linklbl_adminhomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_adminhomepage_LinkClicked);
            // 
            // lbl_greetings
            // 
            this.lbl_greetings.AutoSize = true;
            this.lbl_greetings.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_greetings.Location = new System.Drawing.Point(311, 132);
            this.lbl_greetings.Name = "lbl_greetings";
            this.lbl_greetings.Size = new System.Drawing.Size(1413, 279);
            this.lbl_greetings.TabIndex = 14;
            this.lbl_greetings.Text = "Welcome, Admin!\r\n\r\nClick a button to use a functionality:";
            this.lbl_greetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_functionality4
            // 
            this.btn_functionality4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_functionality4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_functionality4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_functionality4.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_functionality4.ForeColor = System.Drawing.Color.White;
            this.btn_functionality4.Location = new System.Drawing.Point(1427, 461);
            this.btn_functionality4.Name = "btn_functionality4";
            this.btn_functionality4.Size = new System.Drawing.Size(370, 370);
            this.btn_functionality4.TabIndex = 13;
            this.btn_functionality4.Text = "Update your profile";
            this.btn_functionality4.UseVisualStyleBackColor = false;
            this.btn_functionality4.Click += new System.EventHandler(this.btn_functionality4_Click);
            // 
            // btn_functionality3
            // 
            this.btn_functionality3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_functionality3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_functionality3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_functionality3.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_functionality3.ForeColor = System.Drawing.Color.White;
            this.btn_functionality3.Location = new System.Drawing.Point(988, 461);
            this.btn_functionality3.Name = "btn_functionality3";
            this.btn_functionality3.Size = new System.Drawing.Size(370, 370);
            this.btn_functionality3.TabIndex = 12;
            this.btn_functionality3.Text = "View customer feedback";
            this.btn_functionality3.UseVisualStyleBackColor = false;
            this.btn_functionality3.Click += new System.EventHandler(this.btn_functionality3_Click);
            // 
            // btn_functionality2
            // 
            this.btn_functionality2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_functionality2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_functionality2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_functionality2.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_functionality2.ForeColor = System.Drawing.Color.White;
            this.btn_functionality2.Location = new System.Drawing.Point(564, 461);
            this.btn_functionality2.Name = "btn_functionality2";
            this.btn_functionality2.Size = new System.Drawing.Size(370, 370);
            this.btn_functionality2.TabIndex = 11;
            this.btn_functionality2.Text = "View sales report";
            this.btn_functionality2.UseVisualStyleBackColor = false;
            this.btn_functionality2.Click += new System.EventHandler(this.btn_functionality2_Click);
            // 
            // btn_functionality1
            // 
            this.btn_functionality1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_functionality1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_functionality1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_functionality1.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_functionality1.ForeColor = System.Drawing.Color.White;
            this.btn_functionality1.Location = new System.Drawing.Point(141, 461);
            this.btn_functionality1.Name = "btn_functionality1";
            this.btn_functionality1.Size = new System.Drawing.Size(370, 370);
            this.btn_functionality1.TabIndex = 10;
            this.btn_functionality1.Text = "Manage users";
            this.btn_functionality1.UseVisualStyleBackColor = false;
            this.btn_functionality1.Click += new System.EventHandler(this.btn_functionality1_Click);
            // 
            // uc_viewfeedbacks
            // 
            this.uc_viewfeedbacks.Location = new System.Drawing.Point(0, 0);
            this.uc_viewfeedbacks.Margin = new System.Windows.Forms.Padding(0);
            this.uc_viewfeedbacks.Name = "uc_viewfeedbacks";
            this.uc_viewfeedbacks.Size = new System.Drawing.Size(1900, 913);
            this.uc_viewfeedbacks.TabIndex = 17;
            // 
            // uc_viewsalesreport
            // 
            this.uc_viewsalesreport.AutoSize = true;
            this.uc_viewsalesreport.Location = new System.Drawing.Point(0, 0);
            this.uc_viewsalesreport.Margin = new System.Windows.Forms.Padding(0);
            this.uc_viewsalesreport.Name = "uc_viewsalesreport";
            this.uc_viewsalesreport.Size = new System.Drawing.Size(1923, 913);
            this.uc_viewsalesreport.TabIndex = 16;
            // 
            // uc_manageusers
            // 
            this.uc_manageusers.AutoSize = true;
            this.uc_manageusers.BackColor = System.Drawing.Color.Transparent;
            this.uc_manageusers.Location = new System.Drawing.Point(0, 0);
            this.uc_manageusers.Margin = new System.Windows.Forms.Padding(0);
            this.uc_manageusers.Name = "uc_manageusers";
            this.uc_manageusers.Size = new System.Drawing.Size(1900, 913);
            this.uc_manageusers.TabIndex = 15;
            // 
            // uc_updateprofile
            // 
            this.uc_updateprofile.Location = new System.Drawing.Point(0, 0);
            this.uc_updateprofile.Margin = new System.Windows.Forms.Padding(0);
            this.uc_updateprofile.Name = "uc_updateprofile";
            this.uc_updateprofile.Size = new System.Drawing.Size(1900, 913);
            this.uc_updateprofile.TabIndex = 18;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.uc_updateprofile);
            this.Controls.Add(this.panel_footerbar);
            this.Controls.Add(this.uc_viewfeedbacks);
            this.Controls.Add(this.uc_viewsalesreport);
            this.Controls.Add(this.uc_manageusers);
            this.Controls.Add(this.btn_functionality4);
            this.Controls.Add(this.btn_functionality3);
            this.Controls.Add(this.btn_functionality2);
            this.Controls.Add(this.btn_functionality1);
            this.Controls.Add(this.lbl_greetings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel_footerbar.ResumeLayout(false);
            this.panel_footerbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklbl_backtologin;
        private System.Windows.Forms.Panel panel_footerbar;
        private System.Windows.Forms.LinkLabel linklbl_adminhomepage;
        private System.Windows.Forms.Label lbl_greetings;
        private System.Windows.Forms.Button btn_functionality4;
        private System.Windows.Forms.Button btn_functionality3;
        private System.Windows.Forms.Button btn_functionality2;
        private System.Windows.Forms.Button btn_functionality1;
        private AdminManageUsers uc_manageusers;
        private AdminViewSalesReport uc_viewsalesreport;
        private AdminViewCustomerFeedbacks uc_viewfeedbacks;
        private UpdateProfile uc_updateprofile;
    }
}