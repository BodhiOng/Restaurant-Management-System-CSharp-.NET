namespace IOOP_Assignment
{
    partial class ManagerManageMenu
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
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFoodId = new System.Windows.Forms.Label();
            this.btnSwitchAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSwitchEdit = new System.Windows.Forms.Button();
            this.dgvViewMenu = new System.Windows.Forms.DataGridView();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lblManageMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblInstruction1.Location = new System.Drawing.Point(30, 200);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(467, 29);
            this.lblInstruction1.TabIndex = 16;
            this.lblInstruction1.Text = "*Double click on the table to select a menu";
            // 
            // lblId
            // 
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Location = new System.Drawing.Point(391, 158);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(107, 32);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "...";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFoodId
            // 
            this.lblFoodId.AutoSize = true;
            this.lblFoodId.Location = new System.Drawing.Point(385, 120);
            this.lblFoodId.Name = "lblFoodId";
            this.lblFoodId.Size = new System.Drawing.Size(113, 32);
            this.lblFoodId.TabIndex = 14;
            this.lblFoodId.Text = "Food ID";
            // 
            // btnSwitchAdd
            // 
            this.btnSwitchAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwitchAdd.Location = new System.Drawing.Point(35, 30);
            this.btnSwitchAdd.Name = "btnSwitchAdd";
            this.btnSwitchAdd.Size = new System.Drawing.Size(230, 70);
            this.btnSwitchAdd.TabIndex = 13;
            this.btnSwitchAdd.Text = "Switch to Add";
            this.btnSwitchAdd.UseVisualStyleBackColor = false;
            this.btnSwitchAdd.Click += new System.EventHandler(this.btnSwitchAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(35, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 60);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(391, 460);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(311, 460);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(220, 60);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert Menu";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSwitchEdit
            // 
            this.btnSwitchEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwitchEdit.Location = new System.Drawing.Point(301, 30);
            this.btnSwitchEdit.Name = "btnSwitchEdit";
            this.btnSwitchEdit.Size = new System.Drawing.Size(230, 70);
            this.btnSwitchEdit.TabIndex = 8;
            this.btnSwitchEdit.Text = "Switch to Edit";
            this.btnSwitchEdit.UseVisualStyleBackColor = false;
            this.btnSwitchEdit.Click += new System.EventHandler(this.btnSwitchEdit_Click);
            // 
            // dgvViewMenu
            // 
            this.dgvViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewMenu.Location = new System.Drawing.Point(560, 30);
            this.dgvViewMenu.Name = "dgvViewMenu";
            this.dgvViewMenu.RowHeadersVisible = false;
            this.dgvViewMenu.RowHeadersWidth = 62;
            this.dgvViewMenu.RowTemplate.Height = 28;
            this.dgvViewMenu.Size = new System.Drawing.Size(830, 490);
            this.dgvViewMenu.TabIndex = 6;
            this.dgvViewMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewMenu_CellDoubleClick);
            // 
            // cbxCat
            // 
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Items.AddRange(new object[] {
            "Main Course",
            "Appetizer",
            "Dessert",
            "Beverage"});
            this.cbxCat.Location = new System.Drawing.Point(34, 355);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(319, 40);
            this.cbxCat.TabIndex = 5;
            this.cbxCat.SelectionChangeCommitted += new System.EventHandler(this.cbxCat_SelectionChangeCommitted);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(29, 320);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(201, 32);
            this.lblCat.TabIndex = 4;
            this.lblCat.Text = "Food Category";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudPrice.Location = new System.Drawing.Point(34, 265);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 39);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.ValueChanged += new System.EventHandler(this.nudPrice_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(29, 230);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 32);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 155);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(161, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Food Name";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblInstruction1);
            this.pnlMain.Controls.Add(this.lblId);
            this.pnlMain.Controls.Add(this.lblFoodId);
            this.pnlMain.Controls.Add(this.btnSwitchAdd);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.btnInsert);
            this.pnlMain.Controls.Add(this.btnSwitchEdit);
            this.pnlMain.Controls.Add(this.dgvViewMenu);
            this.pnlMain.Controls.Add(this.cbxCat);
            this.pnlMain.Controls.Add(this.lblCat);
            this.pnlMain.Controls.Add(this.nudPrice);
            this.pnlMain.Controls.Add(this.lblPrice);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(3, 182);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1420, 550);
            this.pnlMain.TabIndex = 28;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblManageMenu);
            this.panel_header.Location = new System.Drawing.Point(3, -2);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1420, 180);
            this.panel_header.TabIndex = 27;
            // 
            // lblManageMenu
            // 
            this.lblManageMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblManageMenu.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManageMenu.Location = new System.Drawing.Point(3, 45);
            this.lblManageMenu.Name = "lblManageMenu";
            this.lblManageMenu.Size = new System.Drawing.Size(1420, 86);
            this.lblManageMenu.TabIndex = 0;
            this.lblManageMenu.Text = "Add Menu";
            this.lblManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManagerManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerManageMenu";
            this.Size = new System.Drawing.Size(1425, 730);
            this.Load += new System.EventHandler(this.ManagerManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFoodId;
        private System.Windows.Forms.Button btnSwitchAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSwitchEdit;
        private System.Windows.Forms.DataGridView dgvViewMenu;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lblManageMenu;
    }
}
