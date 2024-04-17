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
            this.components = new System.ComponentModel.Container();
            this.lbl_manageusers = new System.Windows.Forms.Label();
            this.logindatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.cmbbx_role = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logindatabaseBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lbl_manageusers.Click += new System.EventHandler(this.label1_Click);
            // 
            // logindatabaseBindingSource
            // 
            this.logindatabaseBindingSource.DataMember = "login_database";
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::IOOP_Assignment.Properties.Resources.delete_button_5974771;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1043, 671);
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
            this.btn_edit.Location = new System.Drawing.Point(836, 671);
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
            this.btn_add.Location = new System.Drawing.Point(624, 671);
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
            this.lbl_username.Location = new System.Drawing.Point(524, 275);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(290, 61);
            this.lbl_username.TabIndex = 15;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_password.Location = new System.Drawing.Point(535, 411);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(279, 61);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_role.Location = new System.Drawing.Point(660, 506);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(154, 61);
            this.lbl_role.TabIndex = 17;
            this.lbl_role.Text = "Role:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Font = new System.Drawing.Font("Arial", 20F);
            this.txtbx_username.Location = new System.Drawing.Point(820, 275);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(454, 69);
            this.txtbx_username.TabIndex = 18;
            this.txtbx_username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbx_password
            // 
            this.txtbx_password.Font = new System.Drawing.Font("Arial", 20F);
            this.txtbx_password.Location = new System.Drawing.Point(820, 408);
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
            this.cmbbx_role.Location = new System.Drawing.Point(820, 506);
            this.cmbbx_role.Name = "cmbbx_role";
            this.cmbbx_role.Size = new System.Drawing.Size(454, 68);
            this.cmbbx_role.TabIndex = 20;
            this.cmbbx_role.SelectedIndexChanged += new System.EventHandler(this.cmbbx_role_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbl_manageusers);
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1923, 205);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(814, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "*Username must be typed all in lowercase";
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbx_role);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminManageUsers";
            this.Size = new System.Drawing.Size(1914, 923);
            this.Load += new System.EventHandler(this.AdminManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logindatabaseBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageusers;
        private System.Windows.Forms.BindingSource logindatabaseBindingSource;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
