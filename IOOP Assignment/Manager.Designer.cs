namespace IOOP_Assignment
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.AddReservation = new IOOP_Assignment.ManagerAddReservation();
            this.ManagerManageMenu = new IOOP_Assignment.ManagerManageMenu();
            this.ViewReservation = new IOOP_Assignment.ManagerViewReservation();
            this.UpdateProfile = new IOOP_Assignment.UpdateProfile();
            this.panel_footerbar = new System.Windows.Forms.Panel();
            this.lilblMainMenu = new System.Windows.Forms.LinkLabel();
            this.lilblLogout = new System.Windows.Forms.LinkLabel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_footerbar.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddReservation
            // 
            this.AddReservation.Location = new System.Drawing.Point(0, 0);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(1900, 913);
            this.AddReservation.TabIndex = 0;
            // 
            // ManagerManageMenu
            // 
            this.ManagerManageMenu.Location = new System.Drawing.Point(0, 0);
            this.ManagerManageMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManagerManageMenu.Name = "ManagerManageMenu";
            this.ManagerManageMenu.Size = new System.Drawing.Size(1900, 913);
            this.ManagerManageMenu.TabIndex = 1;
            // 
            // ViewReservation
            // 
            this.ViewReservation.Location = new System.Drawing.Point(0, 0);
            this.ViewReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewReservation.Name = "ViewReservation";
            this.ViewReservation.Size = new System.Drawing.Size(1900, 913);
            this.ViewReservation.TabIndex = 2;
            // 
            // UpdateProfile
            // 
            this.UpdateProfile.Location = new System.Drawing.Point(0, 0);
            this.UpdateProfile.Name = "UpdateProfile";
            this.UpdateProfile.Size = new System.Drawing.Size(1900, 913);
            this.UpdateProfile.TabIndex = 3;
            this.UpdateProfile.Username = null;
            // 
            // panel_footerbar
            // 
            this.panel_footerbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_footerbar.Controls.Add(this.lilblMainMenu);
            this.panel_footerbar.Controls.Add(this.lilblLogout);
            this.panel_footerbar.Location = new System.Drawing.Point(1, 900);
            this.panel_footerbar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footerbar.Name = "panel_footerbar";
            this.panel_footerbar.Size = new System.Drawing.Size(1893, 109);
            this.panel_footerbar.TabIndex = 26;
            // 
            // lilblMainMenu
            // 
            this.lilblMainMenu.AutoSize = true;
            this.lilblMainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilblMainMenu.Location = new System.Drawing.Point(145, 34);
            this.lilblMainMenu.Name = "lilblMainMenu";
            this.lilblMainMenu.Size = new System.Drawing.Size(197, 32);
            this.lilblMainMenu.TabIndex = 10;
            this.lilblMainMenu.TabStop = true;
            this.lilblMainMenu.Text = "Manager Menu";
            this.lilblMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilblMainMenu_LinkClicked);
            // 
            // lilblLogout
            // 
            this.lilblLogout.AutoSize = true;
            this.lilblLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilblLogout.Location = new System.Drawing.Point(1627, 34);
            this.lilblLogout.Name = "lilblLogout";
            this.lilblLogout.Size = new System.Drawing.Size(171, 32);
            this.lilblLogout.TabIndex = 11;
            this.lilblLogout.TabStop = true;
            this.lilblLogout.Text = "Back to login";
            this.lilblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilblLogout_LinkClicked);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblMainMenu);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1893, 225);
            this.panel_header.TabIndex = 23;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainMenu.Location = new System.Drawing.Point(4, 56);
            this.lblMainMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(1893, 108);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Manager Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(980, 625);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(853, 200);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.FlatAppearance.BorderSize = 2;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(60, 369);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(853, 200);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View / Manage Reservation";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReservation.FlatAppearance.BorderSize = 2;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservation.Location = new System.Drawing.Point(60, 625);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(853, 200);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Add Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.FlatAppearance.BorderSize = 2;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(980, 369);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(853, 200);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Manage Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(0, 225);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1893, 112);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1893, 900);
            this.panel1.TabIndex = 25;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.panel_footerbar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateProfile);
            this.Controls.Add(this.ViewReservation);
            this.Controls.Add(this.ManagerManageMenu);
            this.Controls.Add(this.AddReservation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel_footerbar.ResumeLayout(false);
            this.panel_footerbar.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ManagerAddReservation AddReservation;
        private ManagerManageMenu ManagerManageMenu;
        private ManagerViewReservation ViewReservation;
        private UpdateProfile UpdateProfile;
        private System.Windows.Forms.Panel panel_footerbar;
        private System.Windows.Forms.LinkLabel lilblMainMenu;
        private System.Windows.Forms.LinkLabel lilblLogout;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
    }
}