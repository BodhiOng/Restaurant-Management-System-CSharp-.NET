namespace IOOP_Assignment
{
    partial class AdminViewSalesReport
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.lbl_viewsalesreport = new System.Windows.Forms.Label();
            this.btn_viewbymonth = new System.Windows.Forms.Button();
            this.btn_viewbychef = new System.Windows.Forms.Button();
            this.btn_viewbycategory = new System.Windows.Forms.Button();
            this.dgv_viewsalesreport = new System.Windows.Forms.DataGridView();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewsalesreport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_viewsalesreport);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1923, 205);
            this.panel_header.TabIndex = 22;
            // 
            // lbl_viewsalesreport
            // 
            this.lbl_viewsalesreport.AutoSize = true;
            this.lbl_viewsalesreport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewsalesreport.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewsalesreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewsalesreport.Location = new System.Drawing.Point(619, 59);
            this.lbl_viewsalesreport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewsalesreport.Name = "lbl_viewsalesreport";
            this.lbl_viewsalesreport.Size = new System.Drawing.Size(731, 93);
            this.lbl_viewsalesreport.TabIndex = 0;
            this.lbl_viewsalesreport.Text = "View Sales Report";
            // 
            // btn_viewbymonth
            // 
            this.btn_viewbymonth.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_viewbymonth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_viewbymonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewbymonth.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_viewbymonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewbymonth.Location = new System.Drawing.Point(99, 348);
            this.btn_viewbymonth.Name = "btn_viewbymonth";
            this.btn_viewbymonth.Size = new System.Drawing.Size(668, 162);
            this.btn_viewbymonth.TabIndex = 23;
            this.btn_viewbymonth.Text = "View by month";
            this.btn_viewbymonth.UseVisualStyleBackColor = false;
            this.btn_viewbymonth.Click += new System.EventHandler(this.btn_viewbymonth_Click);
            // 
            // btn_viewbychef
            // 
            this.btn_viewbychef.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_viewbychef.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_viewbychef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewbychef.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_viewbychef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewbychef.Location = new System.Drawing.Point(99, 525);
            this.btn_viewbychef.Name = "btn_viewbychef";
            this.btn_viewbychef.Size = new System.Drawing.Size(668, 162);
            this.btn_viewbychef.TabIndex = 24;
            this.btn_viewbychef.Text = "View by chef";
            this.btn_viewbychef.UseVisualStyleBackColor = false;
            this.btn_viewbychef.Click += new System.EventHandler(this.btn_viewbychef_Click);
            // 
            // btn_viewbycategory
            // 
            this.btn_viewbycategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_viewbycategory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_viewbycategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewbycategory.Font = new System.Drawing.Font("Arial", 20F);
            this.btn_viewbycategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewbycategory.Location = new System.Drawing.Point(99, 703);
            this.btn_viewbycategory.Name = "btn_viewbycategory";
            this.btn_viewbycategory.Size = new System.Drawing.Size(668, 162);
            this.btn_viewbycategory.TabIndex = 25;
            this.btn_viewbycategory.Text = "View by category";
            this.btn_viewbycategory.UseVisualStyleBackColor = false;
            this.btn_viewbycategory.Click += new System.EventHandler(this.btn_viewbycategory_Click);
            // 
            // dgv_viewsalesreport
            // 
            this.dgv_viewsalesreport.AllowUserToAddRows = false;
            this.dgv_viewsalesreport.AllowUserToDeleteRows = false;
            this.dgv_viewsalesreport.AllowUserToOrderColumns = true;
            this.dgv_viewsalesreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_viewsalesreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewsalesreport.Location = new System.Drawing.Point(860, 291);
            this.dgv_viewsalesreport.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_viewsalesreport.Name = "dgv_viewsalesreport";
            this.dgv_viewsalesreport.ReadOnly = true;
            this.dgv_viewsalesreport.RowHeadersWidth = 82;
            this.dgv_viewsalesreport.RowTemplate.Height = 33;
            this.dgv_viewsalesreport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_viewsalesreport.Size = new System.Drawing.Size(954, 574);
            this.dgv_viewsalesreport.TabIndex = 26;
            // 
            // lbl_notice
            // 
            this.lbl_notice.AutoSize = true;
            this.lbl_notice.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_notice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_notice.Location = new System.Drawing.Point(94, 291);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(614, 27);
            this.lbl_notice.TabIndex = 29;
            this.lbl_notice.Text = "*Press the button once again to refresh data in the table";
            // 
            // AdminViewSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbl_notice);
            this.Controls.Add(this.dgv_viewsalesreport);
            this.Controls.Add(this.btn_viewbycategory);
            this.Controls.Add(this.btn_viewbychef);
            this.Controls.Add(this.btn_viewbymonth);
            this.Controls.Add(this.panel_header);
            this.Name = "AdminViewSalesReport";
            this.Size = new System.Drawing.Size(1923, 913);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewsalesreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_viewsalesreport;
        private System.Windows.Forms.Button btn_viewbymonth;
        private System.Windows.Forms.Button btn_viewbychef;
        private System.Windows.Forms.Button btn_viewbycategory;
        private System.Windows.Forms.DataGridView dgv_viewsalesreport;
        private System.Windows.Forms.Label lbl_notice;
    }
}
