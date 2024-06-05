namespace IOOP_Assignment
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel_footerbar = new System.Windows.Forms.Panel();
            this.linklblCustomerHomePage = new System.Windows.Forms.LinkLabel();
            this.linklblBackToLogin = new System.Windows.Forms.LinkLabel();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.SendFeedback = new IOOP_Assignment.CustomerSendFeedback();
            this.ViewStatus = new IOOP_Assignment.CustomerViewStatus();
            this.OrderFoodMenu = new IOOP_Assignment.CustomerOrderFoodMenu();
            this.UpdateProfile = new IOOP_Assignment.UpdateProfile();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panel_footerbar.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateProfile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateProfile.Location = new System.Drawing.Point(967, 587);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(880, 240);
            this.btnUpdateProfile.TabIndex = 43;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSendFeedback.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFeedback.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.Transparent;
            this.btnSendFeedback.Location = new System.Drawing.Point(967, 317);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(880, 240);
            this.btnSendFeedback.TabIndex = 42;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = false;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewStatus.Location = new System.Drawing.Point(51, 587);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(880, 240);
            this.btnViewStatus.TabIndex = 41;
            this.btnViewStatus.Text = "View Order And Reservation Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu.Location = new System.Drawing.Point(51, 317);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(880, 240);
            this.btnMenu.TabIndex = 40;
            this.btnMenu.Text = "See Food Menu and Order Food";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel_footerbar
            // 
            this.panel_footerbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_footerbar.Controls.Add(this.linklblCustomerHomePage);
            this.panel_footerbar.Controls.Add(this.linklblBackToLogin);
            this.panel_footerbar.Location = new System.Drawing.Point(0, 916);
            this.panel_footerbar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_footerbar.Name = "panel_footerbar";
            this.panel_footerbar.Size = new System.Drawing.Size(1896, 94);
            this.panel_footerbar.TabIndex = 39;
            // 
            // linklblCustomerHomePage
            // 
            this.linklblCustomerHomePage.AutoSize = true;
            this.linklblCustomerHomePage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblCustomerHomePage.Location = new System.Drawing.Point(120, 32);
            this.linklblCustomerHomePage.Name = "linklblCustomerHomePage";
            this.linklblCustomerHomePage.Size = new System.Drawing.Size(271, 32);
            this.linklblCustomerHomePage.TabIndex = 6;
            this.linklblCustomerHomePage.TabStop = true;
            this.linklblCustomerHomePage.Text = "Customer Homepage";
            this.linklblCustomerHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCustomerHomePage_LinkClicked);
            // 
            // linklblBackToLogin
            // 
            this.linklblBackToLogin.AutoSize = true;
            this.linklblBackToLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblBackToLogin.Location = new System.Drawing.Point(1630, 32);
            this.linklblBackToLogin.Name = "linklblBackToLogin";
            this.linklblBackToLogin.Size = new System.Drawing.Size(171, 32);
            this.linklblBackToLogin.TabIndex = 5;
            this.linklblBackToLogin.TabStop = true;
            this.linklblBackToLogin.Text = "Back to login";
            this.linklblBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBackToLogin_LinkClicked);
            // 
            // lblGreetings
            // 
            this.lblGreetings.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblGreetings.Location = new System.Drawing.Point(1, 62);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(1897, 211);
            this.lblGreetings.TabIndex = 38;
            this.lblGreetings.Text = "Welcome, Customer!\r\nClick a Button To:";
            this.lblGreetings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SendFeedback
            // 
            this.SendFeedback.Location = new System.Drawing.Point(0, 0);
            this.SendFeedback.Name = "SendFeedback";
            this.SendFeedback.Size = new System.Drawing.Size(1900, 913);
            this.SendFeedback.TabIndex = 46;
            this.SendFeedback.Username = "";
            // 
            // ViewStatus
            // 
            this.ViewStatus.Location = new System.Drawing.Point(0, 0);
            this.ViewStatus.Name = "ViewStatus";
            this.ViewStatus.Size = new System.Drawing.Size(1900, 913);
            this.ViewStatus.TabIndex = 45;
            this.ViewStatus.Username = "";
            // 
            // OrderFoodMenu
            // 
            this.OrderFoodMenu.Location = new System.Drawing.Point(0, 0);
            this.OrderFoodMenu.Name = "OrderFoodMenu";
            this.OrderFoodMenu.Size = new System.Drawing.Size(1900, 913);
            this.OrderFoodMenu.TabIndex = 44;
            this.OrderFoodMenu.Username = null;
            // 
            // UpdateProfile
            // 
            this.UpdateProfile.Location = new System.Drawing.Point(0, 0);
            this.UpdateProfile.Name = "UpdateProfile";
            this.UpdateProfile.Size = new System.Drawing.Size(1900, 913);
            this.UpdateProfile.TabIndex = 47;
            this.UpdateProfile.Username = null;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.btnViewStatus);
            this.panelBackground.Controls.Add(this.btnUpdateProfile);
            this.panelBackground.Controls.Add(this.lblGreetings);
            this.panelBackground.Controls.Add(this.btnSendFeedback);
            this.panelBackground.Controls.Add(this.btnMenu);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1900, 922);
            this.panelBackground.TabIndex = 48;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.panel_footerbar);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.UpdateProfile);
            this.Controls.Add(this.SendFeedback);
            this.Controls.Add(this.ViewStatus);
            this.Controls.Add(this.OrderFoodMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel_footerbar.ResumeLayout(false);
            this.panel_footerbar.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel_footerbar;
        private System.Windows.Forms.LinkLabel linklblCustomerHomePage;
        private System.Windows.Forms.LinkLabel linklblBackToLogin;
        private System.Windows.Forms.Label lblGreetings;
        private CustomerOrderFoodMenu OrderFoodMenu;
        private CustomerViewStatus ViewStatus;
        private CustomerSendFeedback SendFeedback;
        private UpdateProfile UpdateProfile;
        private System.Windows.Forms.Panel panelBackground;
    }
}