namespace IOOP_Assignment
{
    partial class ManagerViewReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.lblTypeManage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblCusname = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnDateClear = new System.Windows.Forms.Button();
            this.dgvViewReserve = new System.Windows.Forms.DataGridView();
            this.clbType = new System.Windows.Forms.CheckedListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.clbStatus = new System.Windows.Forms.CheckedListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblViewManageReservation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.pnlView.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(521, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 31);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "ID: ...";
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClear.Location = new System.Drawing.Point(388, 132);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(225, 50);
            this.btnAllClear.TabIndex = 31;
            this.btnAllClear.Text = "Remove all filters";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // lblTypeManage
            // 
            this.lblTypeManage.AutoSize = true;
            this.lblTypeManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeManage.Location = new System.Drawing.Point(25, 299);
            this.lblTypeManage.Name = "lblTypeManage";
            this.lblTypeManage.Size = new System.Drawing.Size(202, 29);
            this.lblTypeManage.TabIndex = 22;
            this.lblTypeManage.Text = "Reservation Type";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(637, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(350, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(25, 401);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(135, 58);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Description\r\n(optional)";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(166, 398);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDesc.Size = new System.Drawing.Size(447, 126);
            this.rtbDesc.TabIndex = 19;
            this.rtbDesc.Text = "";
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction1.Location = new System.Drawing.Point(219, 23);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(394, 22);
            this.lblInstruction1.TabIndex = 18;
            this.lblInstruction1.Text = "*Double click on a cell to select record";
            this.lblInstruction1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Location = new System.Drawing.Point(637, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 60);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Full Restaurant",
            "VIP Room",
            "Regular Room",
            "Multi Table",
            "Single Table"});
            this.cbxType.Location = new System.Drawing.Point(275, 296);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(237, 37);
            this.cbxType.TabIndex = 16;
            this.cbxType.Text = "Single Table";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"});
            this.cbxStatus.Location = new System.Drawing.Point(275, 197);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(237, 37);
            this.cbxStatus.TabIndex = 15;
            this.cbxStatus.Text = "Pending";
            // 
            // lblCusname
            // 
            this.lblCusname.AutoSize = true;
            this.lblCusname.Location = new System.Drawing.Point(273, 20);
            this.lblCusname.Name = "lblCusname";
            this.lblCusname.Size = new System.Drawing.Size(0, 29);
            this.lblCusname.TabIndex = 14;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1091, 464);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(300, 60);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View records";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(1091, 464);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(300, 60);
            this.btnManage.TabIndex = 7;
            this.btnManage.Text = "Manage record";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnDateClear
            // 
            this.btnDateClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateClear.Location = new System.Drawing.Point(482, 73);
            this.btnDateClear.Name = "btnDateClear";
            this.btnDateClear.Size = new System.Drawing.Size(131, 42);
            this.btnDateClear.TabIndex = 2;
            this.btnDateClear.Text = "Clear Date";
            this.btnDateClear.UseVisualStyleBackColor = true;
            this.btnDateClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvViewReserve
            // 
            this.dgvViewReserve.AllowUserToAddRows = false;
            this.dgvViewReserve.AllowUserToDeleteRows = false;
            this.dgvViewReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewReserve.ColumnHeadersHeight = 34;
            this.dgvViewReserve.Location = new System.Drawing.Point(627, 16);
            this.dgvViewReserve.Margin = new System.Windows.Forms.Padding(0);
            this.dgvViewReserve.Name = "dgvViewReserve";
            this.dgvViewReserve.ReadOnly = true;
            this.dgvViewReserve.RowHeadersVisible = false;
            this.dgvViewReserve.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvViewReserve.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewReserve.RowTemplate.Height = 28;
            this.dgvViewReserve.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvViewReserve.Size = new System.Drawing.Size(775, 439);
            this.dgvViewReserve.TabIndex = 30;
            this.dgvViewReserve.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewReserve_CellDoubleClick);
            // 
            // clbType
            // 
            this.clbType.BackColor = System.Drawing.SystemColors.Control;
            this.clbType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbType.FormattingEnabled = true;
            this.clbType.Items.AddRange(new object[] {
            "Full Restaurant",
            "VIP Room",
            "Regular Room",
            "Multi Table",
            "Single Table"});
            this.clbType.Location = new System.Drawing.Point(275, 232);
            this.clbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbType.Name = "clbType";
            this.clbType.Size = new System.Drawing.Size(237, 160);
            this.clbType.TabIndex = 5;
            this.clbType.ThreeDCheckBoxes = true;
            this.clbType.Click += new System.EventHandler(this.clbType_Click);
            this.clbType.SelectedIndexChanged += new System.EventHandler(this.clbType_SelectedIndexChanged);
            this.clbType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clbType_MouseDown);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(275, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 35);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // nudNum
            // 
            this.nudNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNum.Location = new System.Drawing.Point(275, 138);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(92, 35);
            this.nudNum.TabIndex = 3;
            this.nudNum.ValueChanged += new System.EventHandler(this.nudNum_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(25, 200);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(213, 29);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Reservation Status";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(25, 140);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(207, 29);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Number of Guests";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(270, 200);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(202, 29);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Reservation Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(25, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(197, 29);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Reservation Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(188, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Customer Name";
            // 
            // clbStatus
            // 
            this.clbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.clbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"});
            this.clbStatus.Location = new System.Drawing.Point(30, 232);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(237, 128);
            this.clbStatus.TabIndex = 4;
            this.clbStatus.Click += new System.EventHandler(this.clbStatus_Click);
            this.clbStatus.SelectedIndexChanged += new System.EventHandler(this.clbStatus_SelectedIndexChanged);
            this.clbStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clbStatus_MouseDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(275, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 35);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.lblId);
            this.pnlView.Controls.Add(this.btnAllClear);
            this.pnlView.Controls.Add(this.lblTypeManage);
            this.pnlView.Controls.Add(this.btnDelete);
            this.pnlView.Controls.Add(this.lblDesc);
            this.pnlView.Controls.Add(this.rtbDesc);
            this.pnlView.Controls.Add(this.lblInstruction1);
            this.pnlView.Controls.Add(this.btnUpdate);
            this.pnlView.Controls.Add(this.cbxType);
            this.pnlView.Controls.Add(this.cbxStatus);
            this.pnlView.Controls.Add(this.lblCusname);
            this.pnlView.Controls.Add(this.btnView);
            this.pnlView.Controls.Add(this.btnManage);
            this.pnlView.Controls.Add(this.btnDateClear);
            this.pnlView.Controls.Add(this.dgvViewReserve);
            this.pnlView.Controls.Add(this.clbType);
            this.pnlView.Controls.Add(this.dtpDate);
            this.pnlView.Controls.Add(this.nudNum);
            this.pnlView.Controls.Add(this.lblStatus);
            this.pnlView.Controls.Add(this.lblNum);
            this.pnlView.Controls.Add(this.lblType);
            this.pnlView.Controls.Add(this.lblDate);
            this.pnlView.Controls.Add(this.lblName);
            this.pnlView.Controls.Add(this.clbStatus);
            this.pnlView.Controls.Add(this.txtName);
            this.pnlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlView.Location = new System.Drawing.Point(3, 182);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1420, 550);
            this.pnlView.TabIndex = 27;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblViewManageReservation);
            this.panel_header.Location = new System.Drawing.Point(3, -2);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1420, 180);
            this.panel_header.TabIndex = 26;
            // 
            // lblViewManageReservation
            // 
            this.lblViewManageReservation.BackColor = System.Drawing.Color.Transparent;
            this.lblViewManageReservation.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewManageReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblViewManageReservation.Location = new System.Drawing.Point(3, 45);
            this.lblViewManageReservation.Name = "lblViewManageReservation";
            this.lblViewManageReservation.Size = new System.Drawing.Size(1420, 86);
            this.lblViewManageReservation.TabIndex = 0;
            this.lblViewManageReservation.Text = "View Reservation";
            this.lblViewManageReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManagerViewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerViewReservation";
            this.Size = new System.Drawing.Size(1425, 730);
            this.Load += new System.EventHandler(this.ManagerViewReservation_Load);
            this.Enter += new System.EventHandler(this.ManagerViewReservation_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Label lblTypeManage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblCusname;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnDateClear;
        private System.Windows.Forms.DataGridView dgvViewReserve;
        private System.Windows.Forms.CheckedListBox clbType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblViewManageReservation;
    }
}
