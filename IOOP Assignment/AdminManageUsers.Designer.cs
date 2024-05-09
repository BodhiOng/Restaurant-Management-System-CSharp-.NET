namespace IOOP_Assignment
{
    partial class AdminManageUsers
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
            this.lbl_manageusers = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.cmbbx_role = new System.Windows.Forms.ComboBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.dgv_logindatabase = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refreshtbl = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logindatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_manageusers
            // 
            this.lbl_manageusers.AutoSize = true;
            this.lbl_manageusers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_manageusers.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manageusers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_manageusers.Location = new System.Drawing.Point(687, 57);
            this.lbl_manageusers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manageusers.Name = "lbl_manageusers";
            this.lbl_manageusers.Size = new System.Drawing.Size(571, 93);
            this.lbl_manageusers.TabIndex = 0;
            this.lbl_manageusers.Text = "Manage users";
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::IOOP_Assignment.Properties.Resources.delete_button_5974771;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(665, 664);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(180, 180);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::IOOP_Assignment.Properties.Resources.edit_button;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(458, 664);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(180, 180);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::IOOP_Assignment.Properties.Resources.add_button_5974633;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(246, 664);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(180, 180);
            this.btn_add.TabIndex = 12;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_username.Location = new System.Drawing.Point(146, 268);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(290, 61);
            this.lbl_username.TabIndex = 15;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_password.Location = new System.Drawing.Point(157, 431);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(279, 61);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_role.Location = new System.Drawing.Point(282, 526);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(154, 61);
            this.lbl_role.TabIndex = 17;
            this.lbl_role.Text = "Role:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Font = new System.Drawing.Font("Arial", 20F);
            this.txtbx_username.Location = new System.Drawing.Point(442, 268);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(454, 69);
            this.txtbx_username.TabIndex = 18;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Font = new System.Drawing.Font("Arial", 20F);
            this.txtbx_password.Location = new System.Drawing.Point(442, 428);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(454, 69);
            this.txtbx_password.TabIndex = 19;
            // 
            // cmbbx_role
            // 
            this.cmbbx_role.Font = new System.Drawing.Font("Arial", 20F);
            this.cmbbx_role.FormattingEnabled = true;
            this.cmbbx_role.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Customer"});
            this.cmbbx_role.Location = new System.Drawing.Point(442, 526);
            this.cmbbx_role.Name = "cmbbx_role";
            this.cmbbx_role.Size = new System.Drawing.Size(454, 68);
            this.cmbbx_role.TabIndex = 20;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_manageusers);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 21;
            // 
            // dgv_logindatabase
            // 
            this.dgv_logindatabase.AllowUserToAddRows = false;
            this.dgv_logindatabase.AllowUserToDeleteRows = false;
            this.dgv_logindatabase.AllowUserToOrderColumns = true;
            this.dgv_logindatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_logindatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_logindatabase.Location = new System.Drawing.Point(984, 306);
            this.dgv_logindatabase.Name = "dgv_logindatabase";
            this.dgv_logindatabase.ReadOnly = true;
            this.dgv_logindatabase.RowHeadersWidth = 82;
            this.dgv_logindatabase.RowTemplate.Height = 33;
            this.dgv_logindatabase.Size = new System.Drawing.Size(830, 576);
            this.dgv_logindatabase.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(442, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "*Username must be in lowercase\r\n*No use of spaces, only use underscores (_)\r\n";
            // 
            // btn_refreshtbl
            // 
            this.btn_refreshtbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_refreshtbl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_refreshtbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshtbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshtbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refreshtbl.Location = new System.Drawing.Point(1507, 240);
            this.btn_refreshtbl.Name = "btn_refreshtbl";
            this.btn_refreshtbl.Size = new System.Drawing.Size(307, 60);
            this.btn_refreshtbl.TabIndex = 38;
            this.btn_refreshtbl.Text = "Refresh table";
            this.btn_refreshtbl.UseVisualStyleBackColor = false;
            this.btn_refreshtbl.Click += new System.EventHandler(this.btn_refreshtbl_Click);
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_refreshtbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_logindatabase);
            this.Controls.Add(this.cmbbx_role);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminManageUsers";
            this.Size = new System.Drawing.Size(1900, 913);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_logindatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageusers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.ComboBox cmbbx_role;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.DataGridView dgv_logindatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refreshtbl;
    }
}
