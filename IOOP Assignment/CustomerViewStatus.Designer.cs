namespace IOOP_Assignment
{
    partial class CustomerViewStatus
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
            this.lblViewStatus = new System.Windows.Forms.Label();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.lbl_notice2 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dgvViewStatus = new System.Windows.Forms.DataGridView();
            this.txtStatusView = new System.Windows.Forms.TextBox();
            this.lbl_notice = new System.Windows.Forms.Label();
            this.lblStatusView = new System.Windows.Forms.Label();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblViewStatus);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 170);
            this.panel_header.TabIndex = 37;
            // 
            // lblViewStatus
            // 
            this.lblViewStatus.AutoSize = true;
            this.lblViewStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblViewStatus.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblViewStatus.Location = new System.Drawing.Point(345, 39);
            this.lblViewStatus.Name = "lblViewStatus";
            this.lblViewStatus.Size = new System.Drawing.Size(1172, 93);
            this.lblViewStatus.TabIndex = 0;
            this.lblViewStatus.Text = "Order And Reservation Status";
            this.lblViewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbDetails
            // 
            this.rtbDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbDetails.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDetails.Location = new System.Drawing.Point(903, 716);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.Size = new System.Drawing.Size(920, 127);
            this.rtbDetails.TabIndex = 47;
            this.rtbDetails.Text = "";
            // 
            // lbl_notice2
            // 
            this.lbl_notice2.AutoSize = true;
            this.lbl_notice2.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_notice2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_notice2.Location = new System.Drawing.Point(898, 631);
            this.lbl_notice2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_notice2.Name = "lbl_notice2";
            this.lbl_notice2.Size = new System.Drawing.Size(468, 27);
            this.lbl_notice2.TabIndex = 46;
            this.lbl_notice2.Text = "*click on the table rows to show the details";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(895, 658);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(273, 45);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Order Details :";
            // 
            // dgvViewStatus
            // 
            this.dgvViewStatus.AllowUserToAddRows = false;
            this.dgvViewStatus.AllowUserToDeleteRows = false;
            this.dgvViewStatus.AllowUserToOrderColumns = true;
            this.dgvViewStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStatus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStatus.Location = new System.Drawing.Point(903, 239);
            this.dgvViewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewStatus.Name = "dgvViewStatus";
            this.dgvViewStatus.ReadOnly = true;
            this.dgvViewStatus.RowHeadersWidth = 82;
            this.dgvViewStatus.RowTemplate.Height = 24;
            this.dgvViewStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewStatus.Size = new System.Drawing.Size(920, 361);
            this.dgvViewStatus.TabIndex = 44;
            this.dgvViewStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStatus_CellClick);
            // 
            // txtStatusView
            // 
            this.txtStatusView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStatusView.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusView.Location = new System.Drawing.Point(106, 716);
            this.txtStatusView.Name = "txtStatusView";
            this.txtStatusView.ReadOnly = true;
            this.txtStatusView.Size = new System.Drawing.Size(741, 68);
            this.txtStatusView.TabIndex = 43;
            // 
            // lbl_notice
            // 
            this.lbl_notice.AutoSize = true;
            this.lbl_notice.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_notice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_notice.Location = new System.Drawing.Point(101, 641);
            this.lbl_notice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_notice.Name = "lbl_notice";
            this.lbl_notice.Size = new System.Drawing.Size(463, 27);
            this.lbl_notice.TabIndex = 42;
            this.lbl_notice.Text = "*click on the table rows to show the status\r\n";
            // 
            // lblStatusView
            // 
            this.lblStatusView.AutoSize = true;
            this.lblStatusView.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusView.Location = new System.Drawing.Point(98, 668);
            this.lblStatusView.Name = "lblStatusView";
            this.lblStatusView.Size = new System.Drawing.Size(265, 45);
            this.lblStatusView.TabIndex = 41;
            this.lblStatusView.Text = "Order Status :";
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReservation.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservation.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewReservation.Location = new System.Drawing.Point(106, 451);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(752, 149);
            this.btnViewReservation.TabIndex = 40;
            this.btnViewReservation.Text = "View Reservation Status";
            this.btnViewReservation.UseVisualStyleBackColor = false;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewOrder.Location = new System.Drawing.Point(106, 298);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(752, 149);
            this.btnViewOrder.TabIndex = 39;
            this.btnViewOrder.Text = "View Order Status";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(98, 239);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(760, 45);
            this.lblGreetings.TabIndex = 38;
            this.lblGreetings.Text = "Hello customer, Please Press any button :)\r\n";
            // 
            // CustomerViewStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.lbl_notice2);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.dgvViewStatus);
            this.Controls.Add(this.txtStatusView);
            this.Controls.Add(this.lbl_notice);
            this.Controls.Add(this.lblStatusView);
            this.Controls.Add(this.btnViewReservation);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.lblGreetings);
            this.Name = "CustomerViewStatus";
            this.Size = new System.Drawing.Size(1900, 913);
            this.Load += new System.EventHandler(this.CustomerViewStatus_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblViewStatus;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Label lbl_notice2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridView dgvViewStatus;
        private System.Windows.Forms.TextBox txtStatusView;
        private System.Windows.Forms.Label lbl_notice;
        private System.Windows.Forms.Label lblStatusView;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label lblGreetings;
    }
}
