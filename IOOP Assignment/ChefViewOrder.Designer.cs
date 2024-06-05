namespace IOOP_Assignment
{
    partial class ChefViewOrder
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
            this.lbl_viewupdateorder = new System.Windows.Forms.Label();
            this.dgv_viewupdateorder = new System.Windows.Forms.DataGridView();
            this.btn_refreshtbl = new System.Windows.Forms.Button();
            this.radbtn_pending = new System.Windows.Forms.RadioButton();
            this.radbtn_inprogress = new System.Windows.Forms.RadioButton();
            this.lbl_orderstatus = new System.Windows.Forms.Label();
            this.lbl_orderDetail = new System.Windows.Forms.Label();
            this.lbl_custName = new System.Windows.Forms.Label();
            this.llb_custInfo = new System.Windows.Forms.Label();
            this.lbl_custOrder = new System.Windows.Forms.Label();
            this.radbtn_completed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updatecompleted = new System.Windows.Forms.Button();
            this.btn_updateinprogress = new System.Windows.Forms.Button();
            this.btn_deletecompleted = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewupdateorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_viewupdateorder);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 22;
            // 
            // lbl_viewupdateorder
            // 
            this.lbl_viewupdateorder.AutoSize = true;
            this.lbl_viewupdateorder.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewupdateorder.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewupdateorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewupdateorder.Location = new System.Drawing.Point(572, 56);
            this.lbl_viewupdateorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewupdateorder.Name = "lbl_viewupdateorder";
            this.lbl_viewupdateorder.Size = new System.Drawing.Size(834, 93);
            this.lbl_viewupdateorder.TabIndex = 0;
            this.lbl_viewupdateorder.Text = "View && Update Order";
            // 
            // dgv_viewupdateorder
            // 
            this.dgv_viewupdateorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewupdateorder.Location = new System.Drawing.Point(1011, 227);
            this.dgv_viewupdateorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_viewupdateorder.Name = "dgv_viewupdateorder";
            this.dgv_viewupdateorder.RowHeadersWidth = 51;
            this.dgv_viewupdateorder.RowTemplate.Height = 24;
            this.dgv_viewupdateorder.Size = new System.Drawing.Size(872, 572);
            this.dgv_viewupdateorder.TabIndex = 23;
            this.dgv_viewupdateorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ViewUpdateOrderClick);
            // 
            // btn_refreshtbl
            // 
            this.btn_refreshtbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_refreshtbl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_refreshtbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshtbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshtbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refreshtbl.Location = new System.Drawing.Point(1514, 806);
            this.btn_refreshtbl.Name = "btn_refreshtbl";
            this.btn_refreshtbl.Size = new System.Drawing.Size(369, 59);
            this.btn_refreshtbl.TabIndex = 39;
            this.btn_refreshtbl.Text = "Refresh table";
            this.btn_refreshtbl.UseVisualStyleBackColor = false;
            this.btn_refreshtbl.Click += new System.EventHandler(this.btn_refreshtbl_Click);
            // 
            // radbtn_pending
            // 
            this.radbtn_pending.AutoSize = true;
            this.radbtn_pending.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_pending.Location = new System.Drawing.Point(312, 264);
            this.radbtn_pending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radbtn_pending.Name = "radbtn_pending";
            this.radbtn_pending.Size = new System.Drawing.Size(149, 36);
            this.radbtn_pending.TabIndex = 40;
            this.radbtn_pending.TabStop = true;
            this.radbtn_pending.Text = "Pending";
            this.radbtn_pending.UseVisualStyleBackColor = true;
            this.radbtn_pending.CheckedChanged += new System.EventHandler(this.radbtn_pending_CheckedChanged);
            // 
            // radbtn_inprogress
            // 
            this.radbtn_inprogress.AutoSize = true;
            this.radbtn_inprogress.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_inprogress.Location = new System.Drawing.Point(484, 264);
            this.radbtn_inprogress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radbtn_inprogress.Name = "radbtn_inprogress";
            this.radbtn_inprogress.Size = new System.Drawing.Size(188, 36);
            this.radbtn_inprogress.TabIndex = 41;
            this.radbtn_inprogress.TabStop = true;
            this.radbtn_inprogress.Text = "In Progress";
            this.radbtn_inprogress.UseVisualStyleBackColor = true;
            this.radbtn_inprogress.CheckedChanged += new System.EventHandler(this.radbtn_inprogress_CheckedChanged);
            // 
            // lbl_orderstatus
            // 
            this.lbl_orderstatus.AutoSize = true;
            this.lbl_orderstatus.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderstatus.Location = new System.Drawing.Point(28, 256);
            this.lbl_orderstatus.Name = "lbl_orderstatus";
            this.lbl_orderstatus.Size = new System.Drawing.Size(254, 45);
            this.lbl_orderstatus.TabIndex = 42;
            this.lbl_orderstatus.Text = "Order Status:";
            // 
            // lbl_orderDetail
            // 
            this.lbl_orderDetail.AutoSize = true;
            this.lbl_orderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderDetail.Location = new System.Drawing.Point(27, 531);
            this.lbl_orderDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orderDetail.Name = "lbl_orderDetail";
            this.lbl_orderDetail.Size = new System.Drawing.Size(0, 37);
            this.lbl_orderDetail.TabIndex = 43;
            // 
            // lbl_custName
            // 
            this.lbl_custName.AutoSize = true;
            this.lbl_custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custName.Location = new System.Drawing.Point(27, 406);
            this.lbl_custName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_custName.Name = "lbl_custName";
            this.lbl_custName.Size = new System.Drawing.Size(0, 52);
            this.lbl_custName.TabIndex = 44;
            // 
            // llb_custInfo
            // 
            this.llb_custInfo.AutoSize = true;
            this.llb_custInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_custInfo.Location = new System.Drawing.Point(27, 356);
            this.llb_custInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_custInfo.Name = "llb_custInfo";
            this.llb_custInfo.Size = new System.Drawing.Size(353, 52);
            this.llb_custInfo.TabIndex = 45;
            this.llb_custInfo.Text = "Customer Name:";
            // 
            // lbl_custOrder
            // 
            this.lbl_custOrder.AutoSize = true;
            this.lbl_custOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custOrder.Location = new System.Drawing.Point(27, 481);
            this.lbl_custOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_custOrder.Name = "lbl_custOrder";
            this.lbl_custOrder.Size = new System.Drawing.Size(348, 52);
            this.lbl_custOrder.TabIndex = 46;
            this.lbl_custOrder.Text = "Customer Order:";
            // 
            // radbtn_completed
            // 
            this.radbtn_completed.AutoSize = true;
            this.radbtn_completed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_completed.Location = new System.Drawing.Point(698, 264);
            this.radbtn_completed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radbtn_completed.Name = "radbtn_completed";
            this.radbtn_completed.Size = new System.Drawing.Size(180, 36);
            this.radbtn_completed.TabIndex = 47;
            this.radbtn_completed.TabStop = true;
            this.radbtn_completed.Text = "Completed";
            this.radbtn_completed.UseVisualStyleBackColor = true;
            this.radbtn_completed.CheckedChanged += new System.EventHandler(this.radbtn_completed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 658);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 52);
            this.label1.TabIndex = 48;
            this.label1.Text = "Update Order Status for Selected Index";
            // 
            // btn_updatecompleted
            // 
            this.btn_updatecompleted.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_updatecompleted.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_updatecompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatecompleted.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatecompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updatecompleted.Location = new System.Drawing.Point(312, 739);
            this.btn_updatecompleted.Name = "btn_updatecompleted";
            this.btn_updatecompleted.Size = new System.Drawing.Size(236, 127);
            this.btn_updatecompleted.TabIndex = 49;
            this.btn_updatecompleted.Text = "Update to:\r\nCompleted";
            this.btn_updatecompleted.UseVisualStyleBackColor = false;
            this.btn_updatecompleted.Click += new System.EventHandler(this.btn_updatecompleted_Click);
            // 
            // btn_updateinprogress
            // 
            this.btn_updateinprogress.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_updateinprogress.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_updateinprogress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateinprogress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateinprogress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_updateinprogress.Location = new System.Drawing.Point(36, 739);
            this.btn_updateinprogress.Name = "btn_updateinprogress";
            this.btn_updateinprogress.Size = new System.Drawing.Size(234, 127);
            this.btn_updateinprogress.TabIndex = 50;
            this.btn_updateinprogress.Text = "Update to:\r\nIn Progress";
            this.btn_updateinprogress.UseVisualStyleBackColor = false;
            this.btn_updateinprogress.Click += new System.EventHandler(this.btn_updateinprogress_Click);
            // 
            // btn_deletecompleted
            // 
            this.btn_deletecompleted.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_deletecompleted.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_deletecompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletecompleted.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletecompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletecompleted.Location = new System.Drawing.Point(586, 739);
            this.btn_deletecompleted.Name = "btn_deletecompleted";
            this.btn_deletecompleted.Size = new System.Drawing.Size(236, 127);
            this.btn_deletecompleted.TabIndex = 51;
            this.btn_deletecompleted.Text = "Delete \r\nCompleted Order\r\n";
            this.btn_deletecompleted.UseVisualStyleBackColor = false;
            this.btn_deletecompleted.Click += new System.EventHandler(this.btn_deletecompleted_Click);
            // 
            // ChefViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_deletecompleted);
            this.Controls.Add(this.btn_updateinprogress);
            this.Controls.Add(this.btn_updatecompleted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radbtn_completed);
            this.Controls.Add(this.lbl_custOrder);
            this.Controls.Add(this.llb_custInfo);
            this.Controls.Add(this.lbl_custName);
            this.Controls.Add(this.lbl_orderDetail);
            this.Controls.Add(this.lbl_orderstatus);
            this.Controls.Add(this.radbtn_inprogress);
            this.Controls.Add(this.radbtn_pending);
            this.Controls.Add(this.btn_refreshtbl);
            this.Controls.Add(this.dgv_viewupdateorder);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChefViewOrder";
            this.Size = new System.Drawing.Size(1900, 913);
            this.Load += new System.EventHandler(this.ChefViewOrder_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewupdateorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_viewupdateorder;
        private System.Windows.Forms.DataGridView dgv_viewupdateorder;
        private System.Windows.Forms.Button btn_refreshtbl;
        private System.Windows.Forms.RadioButton radbtn_pending;
        private System.Windows.Forms.RadioButton radbtn_inprogress;
        private System.Windows.Forms.Label lbl_orderstatus;
        private System.Windows.Forms.Label lbl_orderDetail;
        private System.Windows.Forms.Label lbl_custName;
        private System.Windows.Forms.Label llb_custInfo;
        private System.Windows.Forms.Label lbl_custOrder;
        private System.Windows.Forms.RadioButton radbtn_completed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updatecompleted;
        private System.Windows.Forms.Button btn_updateinprogress;
        private System.Windows.Forms.Button btn_deletecompleted;
    }
}
