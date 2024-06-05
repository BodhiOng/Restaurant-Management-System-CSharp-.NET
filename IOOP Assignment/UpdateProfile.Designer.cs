namespace IOOP_Assignment
{
    partial class UpdateProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_newpassword = new System.Windows.Forms.Label();
            this.lbl_updateprofile = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.lbl_newusername = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.panel_mustfill = new System.Windows.Forms.Panel();
            this.lbl_plsprovideinfo = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.linklbl_deactivateacc = new System.Windows.Forms.LinkLabel();
            this.txtbx_newpassword = new System.Windows.Forms.TextBox();
            this.txtbx_newusername = new System.Windows.Forms.TextBox();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.linklbl_forgetpw = new System.Windows.Forms.LinkLabel();
            this.lbl_noticeusername = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_mustfill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_newpassword
            // 
            this.lbl_newpassword.AutoSize = true;
            this.lbl_newpassword.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpassword.Location = new System.Drawing.Point(861, 516);
            this.lbl_newpassword.Name = "lbl_newpassword";
            this.lbl_newpassword.Size = new System.Drawing.Size(396, 61);
            this.lbl_newpassword.TabIndex = 41;
            this.lbl_newpassword.Text = "New password:";
            // 
            // lbl_updateprofile
            // 
            this.lbl_updateprofile.AutoSize = true;
            this.lbl_updateprofile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_updateprofile.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateprofile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_updateprofile.Location = new System.Drawing.Point(670, 61);
            this.lbl_updateprofile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_updateprofile.Name = "lbl_updateprofile";
            this.lbl_updateprofile.Size = new System.Drawing.Size(577, 93);
            this.lbl_updateprofile.TabIndex = 0;
            this.lbl_updateprofile.Text = "Update profile";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_updateprofile);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 39;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(22, 153);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(416, 55);
            this.lbl_password.TabIndex = 25;
            this.lbl_password.Text = "Current password:";
            // 
            // lbl_notice
            // 
            this.lbl_notice.AutoSize = true;
            this.lbl_notice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_notice.Location = new System.Drawing.Point(1257, 306);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(493, 32);
            this.lbl_notice.TabIndex = 42;
            this.lbl_notice.Text = "*Leave text box empty to retain old data";
            // 
            // lbl_newusername
            // 
            this.lbl_newusername.AutoSize = true;
            this.lbl_newusername.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newusername.Location = new System.Drawing.Point(854, 356);
            this.lbl_newusername.Name = "lbl_newusername";
            this.lbl_newusername.Size = new System.Drawing.Size(403, 61);
            this.lbl_newusername.TabIndex = 40;
            this.lbl_newusername.Text = "New username:";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_password.Location = new System.Drawing.Point(32, 255);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(598, 63);
            this.txtbx_password.TabIndex = 30;
            // 
            // panel_mustfill
            // 
            this.panel_mustfill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_mustfill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mustfill.Controls.Add(this.lbl_plsprovideinfo);
            this.panel_mustfill.Controls.Add(this.txtbx_password);
            this.panel_mustfill.Controls.Add(this.lbl_password);
            this.panel_mustfill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_mustfill.Location = new System.Drawing.Point(102, 395);
            this.panel_mustfill.Name = "panel_mustfill";
            this.panel_mustfill.Size = new System.Drawing.Size(678, 385);
            this.panel_mustfill.TabIndex = 47;
            // 
            // lbl_plsprovideinfo
            // 
            this.lbl_plsprovideinfo.AutoSize = true;
            this.lbl_plsprovideinfo.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plsprovideinfo.Location = new System.Drawing.Point(22, 45);
            this.lbl_plsprovideinfo.Name = "lbl_plsprovideinfo";
            this.lbl_plsprovideinfo.Size = new System.Drawing.Size(639, 56);
            this.lbl_plsprovideinfo.TabIndex = 31;
            this.lbl_plsprovideinfo.Text = "Please provide information";
            this.lbl_plsprovideinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(866, 659);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(948, 122);
            this.btn_update.TabIndex = 46;
            this.btn_update.Text = "Save and submit changes";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // linklbl_deactivateacc
            // 
            this.linklbl_deactivateacc.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linklbl_deactivateacc.AutoSize = true;
            this.linklbl_deactivateacc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_deactivateacc.LinkColor = System.Drawing.Color.Red;
            this.linklbl_deactivateacc.Location = new System.Drawing.Point(1551, 598);
            this.linklbl_deactivateacc.Name = "linklbl_deactivateacc";
            this.linklbl_deactivateacc.Size = new System.Drawing.Size(262, 32);
            this.linklbl_deactivateacc.TabIndex = 45;
            this.linklbl_deactivateacc.TabStop = true;
            this.linklbl_deactivateacc.Text = "Deactivate account?";
            this.linklbl_deactivateacc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_deactivateacc_LinkClicked);
            // 
            // txtbx_newpassword
            // 
            this.txtbx_newpassword.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_newpassword.Location = new System.Drawing.Point(1263, 512);
            this.txtbx_newpassword.Name = "txtbx_newpassword";
            this.txtbx_newpassword.Size = new System.Drawing.Size(550, 69);
            this.txtbx_newpassword.TabIndex = 44;
            // 
            // txtbx_newusername
            // 
            this.txtbx_newusername.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_newusername.Location = new System.Drawing.Point(1263, 353);
            this.txtbx_newusername.Name = "txtbx_newusername";
            this.txtbx_newusername.Size = new System.Drawing.Size(550, 69);
            this.txtbx_newusername.TabIndex = 43;
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(102, 323);
            this.lblGreetings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(109, 45);
            this.lblGreetings.TabIndex = 50;
            this.lblGreetings.Text = "Hello";
            // 
            // linklbl_forgetpw
            // 
            this.linklbl_forgetpw.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.linklbl_forgetpw.AutoSize = true;
            this.linklbl_forgetpw.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_forgetpw.LinkColor = System.Drawing.Color.MediumOrchid;
            this.linklbl_forgetpw.Location = new System.Drawing.Point(1298, 598);
            this.linklbl_forgetpw.Name = "linklbl_forgetpw";
            this.linklbl_forgetpw.Size = new System.Drawing.Size(234, 32);
            this.linklbl_forgetpw.TabIndex = 49;
            this.linklbl_forgetpw.TabStop = true;
            this.linklbl_forgetpw.Text = "Forget Password?";
            this.linklbl_forgetpw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_forgetpw_LinkClicked);
            // 
            // lbl_noticeusername
            // 
            this.lbl_noticeusername.AutoSize = true;
            this.lbl_noticeusername.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noticeusername.ForeColor = System.Drawing.Color.Black;
            this.lbl_noticeusername.Location = new System.Drawing.Point(1268, 434);
            this.lbl_noticeusername.Name = "lbl_noticeusername";
            this.lbl_noticeusername.Size = new System.Drawing.Size(438, 50);
            this.lbl_noticeusername.TabIndex = 48;
            this.lbl_noticeusername.Text = "*Username must be in lowercase\r\n*No use of spaces, only use underscores (_)\r\n";
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_newpassword);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.lbl_notice);
            this.Controls.Add(this.lbl_newusername);
            this.Controls.Add(this.panel_mustfill);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.linklbl_deactivateacc);
            this.Controls.Add(this.txtbx_newpassword);
            this.Controls.Add(this.txtbx_newusername);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.linklbl_forgetpw);
            this.Controls.Add(this.lbl_noticeusername);
            this.Name = "UpdateProfile";
            this.Size = new System.Drawing.Size(1900, 913);
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_mustfill.ResumeLayout(false);
            this.panel_mustfill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newpassword;
        private System.Windows.Forms.Label lbl_updateprofile;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_notice;
        private System.Windows.Forms.Label lbl_newusername;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Panel panel_mustfill;
        private System.Windows.Forms.Label lbl_plsprovideinfo;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.LinkLabel linklbl_deactivateacc;
        private System.Windows.Forms.TextBox txtbx_newpassword;
        private System.Windows.Forms.TextBox txtbx_newusername;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.LinkLabel linklbl_forgetpw;
        private System.Windows.Forms.Label lbl_noticeusername;
    }
}
