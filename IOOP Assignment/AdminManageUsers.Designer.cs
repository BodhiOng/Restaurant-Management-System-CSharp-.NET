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
            this.dRDatabase_logindatabase = new IOOP_Assignment.DRDatabase_logindatabase();
            this.dRDatabaselogindatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dRDatabase_logindatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRDatabaselogindatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_manageusers
            // 
            this.lbl_manageusers.AutoSize = true;
            this.lbl_manageusers.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_manageusers.Location = new System.Drawing.Point(666, 50);
            this.lbl_manageusers.Name = "lbl_manageusers";
            this.lbl_manageusers.Size = new System.Drawing.Size(571, 93);
            this.lbl_manageusers.TabIndex = 0;
            this.lbl_manageusers.Text = "Manage users";
            this.lbl_manageusers.Click += new System.EventHandler(this.label1_Click);
            // 
            // dRDatabase_logindatabase
            // 
            this.dRDatabase_logindatabase.DataSetName = "DRDatabase_logindatabase";
            this.dRDatabase_logindatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dRDatabaselogindatabaseBindingSource
            // 
            this.dRDatabaselogindatabaseBindingSource.DataSource = this.dRDatabase_logindatabase;
            this.dRDatabaselogindatabaseBindingSource.Position = 0;
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_manageusers);
            this.Name = "AdminManageUsers";
            this.Size = new System.Drawing.Size(1911, 923);
            this.Load += new System.EventHandler(this.AdminManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dRDatabase_logindatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRDatabaselogindatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageusers;
        private DRDatabase_logindatabase dRDatabase_logindatabase;
        private System.Windows.Forms.BindingSource dRDatabaselogindatabaseBindingSource;
    }
}
