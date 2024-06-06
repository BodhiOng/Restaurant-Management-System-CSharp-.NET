namespace IOOP_Assignment
{
    partial class ManagerAddReservation
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
            this.lblInstruction6 = new System.Windows.Forms.Label();
            this.lblInstruction5 = new System.Windows.Forms.Label();
            this.lblInstruction4 = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.radConfirmed = new System.Windows.Forms.RadioButton();
            this.radPending = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCusname = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvViewName = new System.Windows.Forms.DataGridView();
            this.lblNametitle = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblAddReservation = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewName)).BeginInit();
            this.panel_header.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruction6
            // 
            this.lblInstruction6.AutoSize = true;
            this.lblInstruction6.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction6.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction6.Location = new System.Drawing.Point(885, 398);
            this.lblInstruction6.Name = "lblInstruction6";
            this.lblInstruction6.Size = new System.Drawing.Size(452, 29);
            this.lblInstruction6.TabIndex = 14;
            this.lblInstruction6.Text = "*Add comments or submit the reservation";
            // 
            // lblInstruction5
            // 
            this.lblInstruction5.AutoSize = true;
            this.lblInstruction5.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction5.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction5.Location = new System.Drawing.Point(450, 381);
            this.lblInstruction5.Name = "lblInstruction5";
            this.lblInstruction5.Size = new System.Drawing.Size(388, 29);
            this.lblInstruction5.TabIndex = 13;
            this.lblInstruction5.Text = "*Select the status of the reservation";
            // 
            // lblInstruction4
            // 
            this.lblInstruction4.AutoSize = true;
            this.lblInstruction4.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction4.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction4.Location = new System.Drawing.Point(450, 270);
            this.lblInstruction4.Name = "lblInstruction4";
            this.lblInstruction4.Size = new System.Drawing.Size(419, 29);
            this.lblInstruction4.TabIndex = 12;
            this.lblInstruction4.Text = "*Select the type of reservation request";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction3.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction3.Location = new System.Drawing.Point(450, 164);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(370, 29);
            this.lblInstruction3.TabIndex = 11;
            this.lblInstruction3.Text = "*Enter the number of reservations";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction2.Location = new System.Drawing.Point(450, 48);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(308, 29);
            this.lblInstruction2.TabIndex = 10;
            this.lblInstruction2.Text = "*Select the reservation date";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(30, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 35);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Search Name..";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction1.Location = new System.Drawing.Point(25, 75);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(335, 25);
            this.lblInstruction1.TabIndex = 8;
            this.lblInstruction1.Text = "*Double click the table to select name";
            // 
            // radConfirmed
            // 
            this.radConfirmed.AutoSize = true;
            this.radConfirmed.Location = new System.Drawing.Point(671, 453);
            this.radConfirmed.Name = "radConfirmed";
            this.radConfirmed.Size = new System.Drawing.Size(150, 33);
            this.radConfirmed.TabIndex = 5;
            this.radConfirmed.TabStop = true;
            this.radConfirmed.Text = "Confirmed";
            this.radConfirmed.UseVisualStyleBackColor = true;
            this.radConfirmed.CheckedChanged += new System.EventHandler(this.radConfirmed_CheckedChanged);
            // 
            // radPending
            // 
            this.radPending.AutoSize = true;
            this.radPending.Location = new System.Drawing.Point(671, 413);
            this.radPending.Name = "radPending";
            this.radPending.Size = new System.Drawing.Size(128, 33);
            this.radPending.TabIndex = 4;
            this.radPending.TabStop = true;
            this.radPending.Text = "Pending";
            this.radPending.UseVisualStyleBackColor = true;
            this.radPending.CheckedChanged += new System.EventHandler(this.radPending_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(450, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(213, 29);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Reservation Status";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(1140, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 70);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Reservation";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbComments.Location = new System.Drawing.Point(890, 80);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(500, 315);
            this.rtbComments.TabIndex = 6;
            this.rtbComments.Text = "I want my food to be extra spicy..";
            this.rtbComments.Enter += new System.EventHandler(this.rtbComments_Enter);
            this.rtbComments.Leave += new System.EventHandler(this.rtbComments_Leave);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(885, 40);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(350, 29);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "Additional Comments (optional)";
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
            this.cbxType.Location = new System.Drawing.Point(671, 302);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(205, 37);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectionChangeCommitted += new System.EventHandler(this.cbxType_SelectionChangeCommitted);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(450, 305);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(202, 29);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Reservation Type";
            // 
            // nudNum
            // 
            this.nudNum.Location = new System.Drawing.Point(671, 196);
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(120, 35);
            this.nudNum.TabIndex = 2;
            this.nudNum.ValueChanged += new System.EventHandler(this.nudNum_ValueChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(450, 195);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(210, 29);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Number of People";
            // 
            // lblCusname
            // 
            this.lblCusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusname.Location = new System.Drawing.Point(220, 37);
            this.lblCusname.Name = "lblCusname";
            this.lblCusname.Size = new System.Drawing.Size(225, 40);
            this.lblCusname.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(671, 80);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(205, 35);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(450, 85);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(197, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Reservation Date";
            // 
            // dgvViewName
            // 
            this.dgvViewName.AllowUserToAddRows = false;
            this.dgvViewName.AllowUserToDeleteRows = false;
            this.dgvViewName.AllowUserToOrderColumns = true;
            this.dgvViewName.AllowUserToResizeColumns = false;
            this.dgvViewName.AllowUserToResizeRows = false;
            this.dgvViewName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewName.Location = new System.Drawing.Point(30, 145);
            this.dgvViewName.MultiSelect = false;
            this.dgvViewName.Name = "dgvViewName";
            this.dgvViewName.ReadOnly = true;
            this.dgvViewName.RowHeadersVisible = false;
            this.dgvViewName.RowHeadersWidth = 20;
            this.dgvViewName.RowTemplate.Height = 28;
            this.dgvViewName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvViewName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewName.ShowEditingIcon = false;
            this.dgvViewName.Size = new System.Drawing.Size(415, 355);
            this.dgvViewName.TabIndex = 0;
            this.dgvViewName.TabStop = false;
            this.dgvViewName.DoubleClick += new System.EventHandler(this.dgvViewName_DoubleClick);
            // 
            // lblNametitle
            // 
            this.lblNametitle.AutoSize = true;
            this.lblNametitle.Location = new System.Drawing.Point(25, 40);
            this.lblNametitle.Name = "lblNametitle";
            this.lblNametitle.Size = new System.Drawing.Size(188, 29);
            this.lblNametitle.TabIndex = 0;
            this.lblNametitle.Text = "Customer Name";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblAddReservation);
            this.panel_header.Location = new System.Drawing.Point(3, -2);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1420, 180);
            this.panel_header.TabIndex = 28;
            // 
            // lblAddReservation
            // 
            this.lblAddReservation.BackColor = System.Drawing.Color.Transparent;
            this.lblAddReservation.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddReservation.Location = new System.Drawing.Point(3, 45);
            this.lblAddReservation.Name = "lblAddReservation";
            this.lblAddReservation.Size = new System.Drawing.Size(1420, 86);
            this.lblAddReservation.TabIndex = 0;
            this.lblAddReservation.Text = "Add Reservation";
            this.lblAddReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.lblInstruction6);
            this.pnlMain.Controls.Add(this.lblInstruction5);
            this.pnlMain.Controls.Add(this.lblInstruction4);
            this.pnlMain.Controls.Add(this.lblInstruction3);
            this.pnlMain.Controls.Add(this.lblInstruction2);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblInstruction1);
            this.pnlMain.Controls.Add(this.radConfirmed);
            this.pnlMain.Controls.Add(this.radPending);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.rtbComments);
            this.pnlMain.Controls.Add(this.lblComments);
            this.pnlMain.Controls.Add(this.cbxType);
            this.pnlMain.Controls.Add(this.lblType);
            this.pnlMain.Controls.Add(this.nudNum);
            this.pnlMain.Controls.Add(this.lblNum);
            this.pnlMain.Controls.Add(this.lblCusname);
            this.pnlMain.Controls.Add(this.dtpDate);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.dgvViewName);
            this.pnlMain.Controls.Add(this.lblNametitle);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(3, 182);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1420, 550);
            this.pnlMain.TabIndex = 29;
            // 
            // ManagerAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerAddReservation";
            this.Size = new System.Drawing.Size(1425, 730);
            this.Load += new System.EventHandler(this.ManagerAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewName)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction6;
        private System.Windows.Forms.Label lblInstruction5;
        private System.Windows.Forms.Label lblInstruction4;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.RadioButton radConfirmed;
        private System.Windows.Forms.RadioButton radPending;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCusname;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvViewName;
        private System.Windows.Forms.Label lblNametitle;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblAddReservation;
        private System.Windows.Forms.Panel pnlMain;
    }
}
