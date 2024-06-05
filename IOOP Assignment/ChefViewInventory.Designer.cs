namespace IOOP_Assignment
{
    partial class ChefViewInventory
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
            this.lbl_viewinventory = new System.Windows.Forms.Label();
            this.dgv_viewupdateinventory = new System.Windows.Forms.DataGridView();
            this.gbxIngredientType = new System.Windows.Forms.GroupBox();
            this.rad_foodbevtype = new System.Windows.Forms.RadioButton();
            this.rad_beveragetype = new System.Windows.Forms.RadioButton();
            this.rad_foodtype = new System.Windows.Forms.RadioButton();
            this.gbx_addingredient = new System.Windows.Forms.GroupBox();
            this.btn_addingredient = new System.Windows.Forms.Button();
            this.tbx_initialstock = new System.Windows.Forms.TextBox();
            this.lbl_inventorytype = new System.Windows.Forms.Label();
            this.lbl_initialstock = new System.Windows.Forms.Label();
            this.lbl_newingredient = new System.Windows.Forms.Label();
            this.tbx_newingredient = new System.Windows.Forms.TextBox();
            this.rad_foodbev = new System.Windows.Forms.RadioButton();
            this.rad_beverage = new System.Windows.Forms.RadioButton();
            this.rad_food = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_subtractstock = new System.Windows.Forms.Button();
            this.tbx_stockadd = new System.Windows.Forms.TextBox();
            this.lbl_stockstoadd = new System.Windows.Forms.Label();
            this.btn_addmorestock = new System.Windows.Forms.Button();
            this.btn_deleteingredient = new System.Windows.Forms.Button();
            this.lbl_stocktitle = new System.Windows.Forms.Label();
            this.lbl_selectedingredient = new System.Windows.Forms.Label();
            this.lbl_stockleft = new System.Windows.Forms.Label();
            this.lbl_ingredienttitle = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewupdateinventory)).BeginInit();
            this.gbxIngredientType.SuspendLayout();
            this.gbx_addingredient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lbl_viewinventory);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1900, 205);
            this.panel_header.TabIndex = 23;
            // 
            // lbl_viewinventory
            // 
            this.lbl_viewinventory.AutoSize = true;
            this.lbl_viewinventory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewinventory.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewinventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_viewinventory.Location = new System.Drawing.Point(478, 55);
            this.lbl_viewinventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_viewinventory.Name = "lbl_viewinventory";
            this.lbl_viewinventory.Size = new System.Drawing.Size(1083, 93);
            this.lbl_viewinventory.TabIndex = 0;
            this.lbl_viewinventory.Text = "View and Manage Inventory";
            // 
            // dgv_viewupdateinventory
            // 
            this.dgv_viewupdateinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewupdateinventory.Location = new System.Drawing.Point(1024, 223);
            this.dgv_viewupdateinventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_viewupdateinventory.Name = "dgv_viewupdateinventory";
            this.dgv_viewupdateinventory.RowHeadersWidth = 51;
            this.dgv_viewupdateinventory.RowTemplate.Height = 24;
            this.dgv_viewupdateinventory.Size = new System.Drawing.Size(872, 667);
            this.dgv_viewupdateinventory.TabIndex = 24;
            this.dgv_viewupdateinventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ViewInventory);
            // 
            // gbxIngredientType
            // 
            this.gbxIngredientType.Controls.Add(this.rad_foodbevtype);
            this.gbxIngredientType.Controls.Add(this.rad_beveragetype);
            this.gbxIngredientType.Controls.Add(this.rad_foodtype);
            this.gbxIngredientType.Location = new System.Drawing.Point(24, 223);
            this.gbxIngredientType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxIngredientType.Name = "gbxIngredientType";
            this.gbxIngredientType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxIngredientType.Size = new System.Drawing.Size(942, 84);
            this.gbxIngredientType.TabIndex = 25;
            this.gbxIngredientType.TabStop = false;
            this.gbxIngredientType.Text = "Ingredient Type";
            // 
            // rad_foodbevtype
            // 
            this.rad_foodbevtype.AutoSize = true;
            this.rad_foodbevtype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_foodbevtype.Location = new System.Drawing.Point(814, 33);
            this.rad_foodbevtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_foodbevtype.Name = "rad_foodbevtype";
            this.rad_foodbevtype.Size = new System.Drawing.Size(103, 36);
            this.rad_foodbevtype.TabIndex = 28;
            this.rad_foodbevtype.TabStop = true;
            this.rad_foodbevtype.Text = "Both";
            this.rad_foodbevtype.UseVisualStyleBackColor = true;
            this.rad_foodbevtype.CheckedChanged += new System.EventHandler(this.radFoodBev_CheckedChanged);
            // 
            // rad_beveragetype
            // 
            this.rad_beveragetype.AutoSize = true;
            this.rad_beveragetype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_beveragetype.Location = new System.Drawing.Point(372, 33);
            this.rad_beveragetype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_beveragetype.Name = "rad_beveragetype";
            this.rad_beveragetype.Size = new System.Drawing.Size(176, 36);
            this.rad_beveragetype.TabIndex = 27;
            this.rad_beveragetype.TabStop = true;
            this.rad_beveragetype.Text = "Beverages";
            this.rad_beveragetype.UseVisualStyleBackColor = true;
            this.rad_beveragetype.CheckedChanged += new System.EventHandler(this.radBeverages_CheckedChanged);
            // 
            // rad_foodtype
            // 
            this.rad_foodtype.AutoSize = true;
            this.rad_foodtype.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_foodtype.Location = new System.Drawing.Point(27, 33);
            this.rad_foodtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_foodtype.Name = "rad_foodtype";
            this.rad_foodtype.Size = new System.Drawing.Size(108, 36);
            this.rad_foodtype.TabIndex = 26;
            this.rad_foodtype.TabStop = true;
            this.rad_foodtype.Text = "Food";
            this.rad_foodtype.UseVisualStyleBackColor = true;
            this.rad_foodtype.CheckedChanged += new System.EventHandler(this.radFood_CheckedChanged);
            // 
            // gbx_addingredient
            // 
            this.gbx_addingredient.Controls.Add(this.btn_addingredient);
            this.gbx_addingredient.Controls.Add(this.tbx_initialstock);
            this.gbx_addingredient.Controls.Add(this.lbl_inventorytype);
            this.gbx_addingredient.Controls.Add(this.lbl_initialstock);
            this.gbx_addingredient.Controls.Add(this.lbl_newingredient);
            this.gbx_addingredient.Controls.Add(this.tbx_newingredient);
            this.gbx_addingredient.Controls.Add(this.rad_foodbev);
            this.gbx_addingredient.Controls.Add(this.rad_beverage);
            this.gbx_addingredient.Controls.Add(this.rad_food);
            this.gbx_addingredient.Location = new System.Drawing.Point(24, 317);
            this.gbx_addingredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_addingredient.Name = "gbx_addingredient";
            this.gbx_addingredient.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_addingredient.Size = new System.Drawing.Size(460, 555);
            this.gbx_addingredient.TabIndex = 26;
            this.gbx_addingredient.TabStop = false;
            this.gbx_addingredient.Text = "Add Ingredient";
            // 
            // btn_addingredient
            // 
            this.btn_addingredient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_addingredient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addingredient.ForeColor = System.Drawing.Color.White;
            this.btn_addingredient.Location = new System.Drawing.Point(214, 438);
            this.btn_addingredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addingredient.Name = "btn_addingredient";
            this.btn_addingredient.Size = new System.Drawing.Size(237, 108);
            this.btn_addingredient.TabIndex = 8;
            this.btn_addingredient.Text = "Add Ingredient";
            this.btn_addingredient.UseVisualStyleBackColor = false;
            this.btn_addingredient.Click += new System.EventHandler(this.btn_addingredient_Click);
            // 
            // tbx_initialstock
            // 
            this.tbx_initialstock.Location = new System.Drawing.Point(9, 200);
            this.tbx_initialstock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_initialstock.Multiline = true;
            this.tbx_initialstock.Name = "tbx_initialstock";
            this.tbx_initialstock.Size = new System.Drawing.Size(298, 40);
            this.tbx_initialstock.TabIndex = 7;
            this.tbx_initialstock.Text = "Enter number of stock";
            this.tbx_initialstock.Enter += new System.EventHandler(this.tbx_initialstock_Enter);
            // 
            // lbl_inventorytype
            // 
            this.lbl_inventorytype.AutoSize = true;
            this.lbl_inventorytype.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventorytype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_inventorytype.Location = new System.Drawing.Point(2, 266);
            this.lbl_inventorytype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inventorytype.Name = "lbl_inventorytype";
            this.lbl_inventorytype.Size = new System.Drawing.Size(389, 42);
            this.lbl_inventorytype.TabIndex = 6;
            this.lbl_inventorytype.Text = "Select Ingredient Type:";
            // 
            // lbl_initialstock
            // 
            this.lbl_initialstock.AutoSize = true;
            this.lbl_initialstock.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_initialstock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_initialstock.Location = new System.Drawing.Point(2, 155);
            this.lbl_initialstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_initialstock.Name = "lbl_initialstock";
            this.lbl_initialstock.Size = new System.Drawing.Size(311, 42);
            this.lbl_initialstock.TabIndex = 5;
            this.lbl_initialstock.Text = "Enter Initial Stock:";
            // 
            // lbl_newingredient
            // 
            this.lbl_newingredient.AutoSize = true;
            this.lbl_newingredient.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newingredient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_newingredient.Location = new System.Drawing.Point(2, 50);
            this.lbl_newingredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newingredient.Name = "lbl_newingredient";
            this.lbl_newingredient.Size = new System.Drawing.Size(372, 42);
            this.lbl_newingredient.TabIndex = 4;
            this.lbl_newingredient.Text = "Enter New Ingredient:";
            // 
            // tbx_newingredient
            // 
            this.tbx_newingredient.Location = new System.Drawing.Point(9, 95);
            this.tbx_newingredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_newingredient.Multiline = true;
            this.tbx_newingredient.Name = "tbx_newingredient";
            this.tbx_newingredient.Size = new System.Drawing.Size(298, 40);
            this.tbx_newingredient.TabIndex = 4;
            this.tbx_newingredient.Text = "Type Here";
            this.tbx_newingredient.Enter += new System.EventHandler(this.tbx_newingredient_Enter);
            // 
            // rad_foodbev
            // 
            this.rad_foodbev.AutoSize = true;
            this.rad_foodbev.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_foodbev.Location = new System.Drawing.Point(9, 406);
            this.rad_foodbev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_foodbev.Name = "rad_foodbev";
            this.rad_foodbev.Size = new System.Drawing.Size(103, 36);
            this.rad_foodbev.TabIndex = 2;
            this.rad_foodbev.TabStop = true;
            this.rad_foodbev.Text = "Both";
            this.rad_foodbev.UseVisualStyleBackColor = true;
            // 
            // rad_beverage
            // 
            this.rad_beverage.AutoSize = true;
            this.rad_beverage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_beverage.Location = new System.Drawing.Point(9, 361);
            this.rad_beverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_beverage.Name = "rad_beverage";
            this.rad_beverage.Size = new System.Drawing.Size(162, 36);
            this.rad_beverage.TabIndex = 1;
            this.rad_beverage.TabStop = true;
            this.rad_beverage.Text = "Beverage";
            this.rad_beverage.UseVisualStyleBackColor = true;
            // 
            // rad_food
            // 
            this.rad_food.AutoSize = true;
            this.rad_food.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_food.Location = new System.Drawing.Point(9, 316);
            this.rad_food.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rad_food.Name = "rad_food";
            this.rad_food.Size = new System.Drawing.Size(108, 36);
            this.rad_food.TabIndex = 0;
            this.rad_food.TabStop = true;
            this.rad_food.Text = "Food";
            this.rad_food.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_subtractstock);
            this.groupBox2.Controls.Add(this.tbx_stockadd);
            this.groupBox2.Controls.Add(this.lbl_stockstoadd);
            this.groupBox2.Controls.Add(this.btn_addmorestock);
            this.groupBox2.Controls.Add(this.btn_deleteingredient);
            this.groupBox2.Controls.Add(this.lbl_stocktitle);
            this.groupBox2.Controls.Add(this.lbl_selectedingredient);
            this.groupBox2.Controls.Add(this.lbl_stockleft);
            this.groupBox2.Controls.Add(this.lbl_ingredienttitle);
            this.groupBox2.Location = new System.Drawing.Point(494, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(472, 555);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Stock";
            // 
            // btn_subtractstock
            // 
            this.btn_subtractstock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_subtractstock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtractstock.ForeColor = System.Drawing.Color.White;
            this.btn_subtractstock.Location = new System.Drawing.Point(240, 361);
            this.btn_subtractstock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_subtractstock.Name = "btn_subtractstock";
            this.btn_subtractstock.Size = new System.Drawing.Size(200, 98);
            this.btn_subtractstock.TabIndex = 11;
            this.btn_subtractstock.Text = "Remove from Stock";
            this.btn_subtractstock.UseVisualStyleBackColor = false;
            this.btn_subtractstock.Click += new System.EventHandler(this.btn_subtractstock_Click);
            // 
            // tbx_stockadd
            // 
            this.tbx_stockadd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_stockadd.Location = new System.Drawing.Point(9, 295);
            this.tbx_stockadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_stockadd.Multiline = true;
            this.tbx_stockadd.Name = "tbx_stockadd";
            this.tbx_stockadd.Size = new System.Drawing.Size(307, 54);
            this.tbx_stockadd.TabIndex = 9;
            this.tbx_stockadd.Text = "Enter stocks to add";
            this.tbx_stockadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_stockadd.Enter += new System.EventHandler(this.tbx_stockadd_Enter);
            // 
            // lbl_stockstoadd
            // 
            this.lbl_stockstoadd.AutoSize = true;
            this.lbl_stockstoadd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockstoadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_stockstoadd.Location = new System.Drawing.Point(22, 244);
            this.lbl_stockstoadd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stockstoadd.Name = "lbl_stockstoadd";
            this.lbl_stockstoadd.Size = new System.Drawing.Size(392, 42);
            this.lbl_stockstoadd.TabIndex = 10;
            this.lbl_stockstoadd.Text = "Stock To Add/Remove:";
            // 
            // btn_addmorestock
            // 
            this.btn_addmorestock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_addmorestock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmorestock.ForeColor = System.Drawing.Color.White;
            this.btn_addmorestock.Location = new System.Drawing.Point(9, 361);
            this.btn_addmorestock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addmorestock.Name = "btn_addmorestock";
            this.btn_addmorestock.Size = new System.Drawing.Size(222, 98);
            this.btn_addmorestock.TabIndex = 9;
            this.btn_addmorestock.Text = "Add to Stock";
            this.btn_addmorestock.UseVisualStyleBackColor = false;
            this.btn_addmorestock.Click += new System.EventHandler(this.btn_addmorestock_Click);
            // 
            // btn_deleteingredient
            // 
            this.btn_deleteingredient.BackColor = System.Drawing.Color.Red;
            this.btn_deleteingredient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteingredient.Location = new System.Drawing.Point(9, 456);
            this.btn_deleteingredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_deleteingredient.Name = "btn_deleteingredient";
            this.btn_deleteingredient.Size = new System.Drawing.Size(430, 98);
            this.btn_deleteingredient.TabIndex = 9;
            this.btn_deleteingredient.Text = "Delete Ingredient";
            this.btn_deleteingredient.UseVisualStyleBackColor = false;
            this.btn_deleteingredient.Click += new System.EventHandler(this.btn_deleteingredient_Click);
            // 
            // lbl_stocktitle
            // 
            this.lbl_stocktitle.AutoSize = true;
            this.lbl_stocktitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stocktitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_stocktitle.Location = new System.Drawing.Point(22, 155);
            this.lbl_stocktitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stocktitle.Name = "lbl_stocktitle";
            this.lbl_stocktitle.Size = new System.Drawing.Size(193, 42);
            this.lbl_stocktitle.TabIndex = 3;
            this.lbl_stocktitle.Text = "Stock Left:";
            // 
            // lbl_selectedingredient
            // 
            this.lbl_selectedingredient.AutoSize = true;
            this.lbl_selectedingredient.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedingredient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_selectedingredient.Location = new System.Drawing.Point(24, 97);
            this.lbl_selectedingredient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectedingredient.Name = "lbl_selectedingredient";
            this.lbl_selectedingredient.Size = new System.Drawing.Size(0, 32);
            this.lbl_selectedingredient.TabIndex = 2;
            // 
            // lbl_stockleft
            // 
            this.lbl_stockleft.AutoSize = true;
            this.lbl_stockleft.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockleft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_stockleft.Location = new System.Drawing.Point(46, 214);
            this.lbl_stockleft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stockleft.Name = "lbl_stockleft";
            this.lbl_stockleft.Size = new System.Drawing.Size(0, 32);
            this.lbl_stockleft.TabIndex = 1;
            // 
            // lbl_ingredienttitle
            // 
            this.lbl_ingredienttitle.AutoSize = true;
            this.lbl_ingredienttitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingredienttitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ingredienttitle.Location = new System.Drawing.Point(22, 50);
            this.lbl_ingredienttitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ingredienttitle.Name = "lbl_ingredienttitle";
            this.lbl_ingredienttitle.Size = new System.Drawing.Size(342, 42);
            this.lbl_ingredienttitle.TabIndex = 0;
            this.lbl_ingredienttitle.Text = "Selected Ingredient:";
            // 
            // ChefViewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_addingredient);
            this.Controls.Add(this.gbxIngredientType);
            this.Controls.Add(this.dgv_viewupdateinventory);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChefViewInventory";
            this.Size = new System.Drawing.Size(1900, 913);
            this.Load += new System.EventHandler(this.ChefViewInventory_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewupdateinventory)).EndInit();
            this.gbxIngredientType.ResumeLayout(false);
            this.gbxIngredientType.PerformLayout();
            this.gbx_addingredient.ResumeLayout(false);
            this.gbx_addingredient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_viewinventory;
        private System.Windows.Forms.DataGridView dgv_viewupdateinventory;
        private System.Windows.Forms.GroupBox gbxIngredientType;
        private System.Windows.Forms.RadioButton rad_foodbevtype;
        private System.Windows.Forms.RadioButton rad_beveragetype;
        private System.Windows.Forms.RadioButton rad_foodtype;
        private System.Windows.Forms.GroupBox gbx_addingredient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_foodbev;
        private System.Windows.Forms.RadioButton rad_beverage;
        private System.Windows.Forms.RadioButton rad_food;
        private System.Windows.Forms.Label lbl_stocktitle;
        private System.Windows.Forms.Label lbl_selectedingredient;
        private System.Windows.Forms.Label lbl_stockleft;
        private System.Windows.Forms.Label lbl_ingredienttitle;
        private System.Windows.Forms.Label lbl_newingredient;
        private System.Windows.Forms.TextBox tbx_newingredient;
        private System.Windows.Forms.TextBox tbx_initialstock;
        private System.Windows.Forms.Label lbl_inventorytype;
        private System.Windows.Forms.Label lbl_initialstock;
        private System.Windows.Forms.Button btn_addingredient;
        private System.Windows.Forms.Button btn_deleteingredient;
        private System.Windows.Forms.Button btn_addmorestock;
        private System.Windows.Forms.Label lbl_stockstoadd;
        private System.Windows.Forms.TextBox tbx_stockadd;
        private System.Windows.Forms.Button btn_subtractstock;
    }
}
