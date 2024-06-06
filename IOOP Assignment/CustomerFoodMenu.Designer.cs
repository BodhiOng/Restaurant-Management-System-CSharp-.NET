namespace IOOP_Assignment
{
    partial class CustomerOrderFoodMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderFoodMenu));
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblAllCategories = new System.Windows.Forms.Label();
            this.lblAppetizer = new System.Windows.Forms.Label();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lstOrderDetails = new System.Windows.Forms.ListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lblShowCartnMenu = new System.Windows.Forms.Label();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.dgvFoodMenu = new System.Windows.Forms.DataGridView();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.panelFoodCategories = new System.Windows.Forms.Panel();
            this.pbxAll = new System.Windows.Forms.PictureBox();
            this.pbxDessert = new System.Windows.Forms.PictureBox();
            this.pbxAppetizer = new System.Windows.Forms.PictureBox();
            this.pbxBeverages = new System.Windows.Forms.PictureBox();
            this.pbxMainCourse = new System.Windows.Forms.PictureBox();
            this.lblFoodMenunCart = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFoodSearch = new System.Windows.Forms.TextBox();
            this.lblCusFoodMenuandOrder = new System.Windows.Forms.Label();
            this.panelFoodCart = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.pbxSearchMenu = new System.Windows.Forms.PictureBox();
            this.pbxShowCart = new System.Windows.Forms.PictureBox();
            this.pbxShowMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).BeginInit();
            this.panelFoodCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppetizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeverages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainCourse)).BeginInit();
            this.panelFoodCart.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecrement
            // 
            this.btnDecrement.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.Location = new System.Drawing.Point(283, 538);
            this.btnDecrement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(33, 32);
            this.btnDecrement.TabIndex = 56;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(212, 540);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 30);
            this.lblQty.TabIndex = 54;
            this.lblQty.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(79, 540);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(119, 28);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(79, 483);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(140, 30);
            this.lblOrder.TabIndex = 52;
            this.lblOrder.Text = "Order food:";
            // 
            // lblAllCategories
            // 
            this.lblAllCategories.AutoSize = true;
            this.lblAllCategories.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCategories.Location = new System.Drawing.Point(61, 216);
            this.lblAllCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllCategories.Name = "lblAllCategories";
            this.lblAllCategories.Size = new System.Drawing.Size(170, 28);
            this.lblAllCategories.TabIndex = 40;
            this.lblAllCategories.Text = "All Categories";
            // 
            // lblAppetizer
            // 
            this.lblAppetizer.AutoSize = true;
            this.lblAppetizer.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppetizer.Location = new System.Drawing.Point(61, 180);
            this.lblAppetizer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppetizer.Name = "lblAppetizer";
            this.lblAppetizer.Size = new System.Drawing.Size(131, 28);
            this.lblAppetizer.TabIndex = 39;
            this.lblAppetizer.Text = "Appetizers";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.Location = new System.Drawing.Point(328, 534);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(180, 38);
            this.btnAddtoCart.TabIndex = 58;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // lstOrderDetails
            // 
            this.lstOrderDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstOrderDetails.FormattingEnabled = true;
            this.lstOrderDetails.ItemHeight = 16;
            this.lstOrderDetails.Location = new System.Drawing.Point(9, 12);
            this.lstOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOrderDetails.Name = "lstOrderDetails";
            this.lstOrderDetails.Size = new System.Drawing.Size(549, 228);
            this.lstOrderDetails.TabIndex = 0;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(1057, 526);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(163, 40);
            this.btnAddOrder.TabIndex = 60;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDessert.Location = new System.Drawing.Point(60, 141);
            this.lblDessert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(112, 28);
            this.lblDessert.TabIndex = 38;
            this.lblDessert.Text = "Desserts";
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverage.Location = new System.Drawing.Point(60, 99);
            this.lblBeverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(131, 28);
            this.lblBeverage.TabIndex = 37;
            this.lblBeverage.Text = "Beverages";
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCourse.Location = new System.Drawing.Point(60, 56);
            this.lblMainCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(168, 28);
            this.lblMainCourse.TabIndex = 36;
            this.lblMainCourse.Text = "Main Courses";
            // 
            // lblShowCartnMenu
            // 
            this.lblShowCartnMenu.AutoSize = true;
            this.lblShowCartnMenu.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCartnMenu.Location = new System.Drawing.Point(542, 540);
            this.lblShowCartnMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowCartnMenu.Name = "lblShowCartnMenu";
            this.lblShowCartnMenu.Size = new System.Drawing.Size(130, 28);
            this.lblShowCartnMenu.TabIndex = 63;
            this.lblShowCartnMenu.Text = "Show Cart";
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncrement.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrement.Location = new System.Drawing.Point(245, 538);
            this.btnIncrement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(33, 32);
            this.btnIncrement.TabIndex = 55;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // dgvFoodMenu
            // 
            this.dgvFoodMenu.AllowUserToAddRows = false;
            this.dgvFoodMenu.AllowUserToDeleteRows = false;
            this.dgvFoodMenu.AllowUserToOrderColumns = true;
            this.dgvFoodMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodMenu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFoodMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFoodMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodMenu.Location = new System.Drawing.Point(645, 210);
            this.dgvFoodMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dgvFoodMenu.Name = "dgvFoodMenu";
            this.dgvFoodMenu.ReadOnly = true;
            this.dgvFoodMenu.RowHeadersWidth = 82;
            this.dgvFoodMenu.RowTemplate.Height = 24;
            this.dgvFoodMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFoodMenu.Size = new System.Drawing.Size(575, 266);
            this.dgvFoodMenu.TabIndex = 47;
            this.dgvFoodMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodMenu_CellClick);
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCategory.Location = new System.Drawing.Point(11, 12);
            this.lblFoodCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(270, 38);
            this.lblFoodCategory.TabIndex = 0;
            this.lblFoodCategory.Text = "Food Categories :";
            // 
            // panelFoodCategories
            // 
            this.panelFoodCategories.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFoodCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFoodCategories.Controls.Add(this.lblAllCategories);
            this.panelFoodCategories.Controls.Add(this.pbxAll);
            this.panelFoodCategories.Controls.Add(this.lblAppetizer);
            this.panelFoodCategories.Controls.Add(this.pbxDessert);
            this.panelFoodCategories.Controls.Add(this.lblDessert);
            this.panelFoodCategories.Controls.Add(this.lblBeverage);
            this.panelFoodCategories.Controls.Add(this.pbxAppetizer);
            this.panelFoodCategories.Controls.Add(this.lblMainCourse);
            this.panelFoodCategories.Controls.Add(this.pbxBeverages);
            this.panelFoodCategories.Controls.Add(this.pbxMainCourse);
            this.panelFoodCategories.Controls.Add(this.lblFoodCategory);
            this.panelFoodCategories.Location = new System.Drawing.Point(84, 210);
            this.panelFoodCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFoodCategories.Name = "panelFoodCategories";
            this.panelFoodCategories.Size = new System.Drawing.Size(523, 267);
            this.panelFoodCategories.TabIndex = 50;
            // 
            // pbxAll
            // 
            this.pbxAll.Image = global::IOOP_Assignment.Properties.Resources.allLogo;
            this.pbxAll.Location = new System.Drawing.Point(22, 216);
            this.pbxAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAll.Name = "pbxAll";
            this.pbxAll.Size = new System.Drawing.Size(30, 29);
            this.pbxAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAll.TabIndex = 37;
            this.pbxAll.TabStop = false;
            this.pbxAll.Click += new System.EventHandler(this.pbxAll_Click);
            // 
            // pbxDessert
            // 
            this.pbxDessert.Image = global::IOOP_Assignment.Properties.Resources.DessertLogo;
            this.pbxDessert.Location = new System.Drawing.Point(20, 141);
            this.pbxDessert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxDessert.Name = "pbxDessert";
            this.pbxDessert.Size = new System.Drawing.Size(30, 29);
            this.pbxDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDessert.TabIndex = 39;
            this.pbxDessert.TabStop = false;
            this.pbxDessert.Click += new System.EventHandler(this.pbxDessert_Click);
            // 
            // pbxAppetizer
            // 
            this.pbxAppetizer.BackColor = System.Drawing.Color.Transparent;
            this.pbxAppetizer.Image = global::IOOP_Assignment.Properties.Resources.AppetizersLogo;
            this.pbxAppetizer.Location = new System.Drawing.Point(21, 178);
            this.pbxAppetizer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxAppetizer.Name = "pbxAppetizer";
            this.pbxAppetizer.Size = new System.Drawing.Size(30, 29);
            this.pbxAppetizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAppetizer.TabIndex = 36;
            this.pbxAppetizer.TabStop = false;
            this.pbxAppetizer.Click += new System.EventHandler(this.pbxAppetizer_Click);
            // 
            // pbxBeverages
            // 
            this.pbxBeverages.Image = global::IOOP_Assignment.Properties.Resources.BeveragesLogo;
            this.pbxBeverages.Location = new System.Drawing.Point(21, 99);
            this.pbxBeverages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxBeverages.Name = "pbxBeverages";
            this.pbxBeverages.Size = new System.Drawing.Size(30, 29);
            this.pbxBeverages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBeverages.TabIndex = 38;
            this.pbxBeverages.TabStop = false;
            this.pbxBeverages.Click += new System.EventHandler(this.pbxBeverages_Click);
            // 
            // pbxMainCourse
            // 
            this.pbxMainCourse.Image = global::IOOP_Assignment.Properties.Resources.MainCourseLogo;
            this.pbxMainCourse.Location = new System.Drawing.Point(20, 56);
            this.pbxMainCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxMainCourse.Name = "pbxMainCourse";
            this.pbxMainCourse.Size = new System.Drawing.Size(30, 29);
            this.pbxMainCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMainCourse.TabIndex = 37;
            this.pbxMainCourse.TabStop = false;
            this.pbxMainCourse.Click += new System.EventHandler(this.pbxMainCourse_Click);
            // 
            // lblFoodMenunCart
            // 
            this.lblFoodMenunCart.AutoSize = true;
            this.lblFoodMenunCart.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodMenunCart.Location = new System.Drawing.Point(639, 145);
            this.lblFoodMenunCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodMenunCart.Name = "lblFoodMenunCart";
            this.lblFoodMenunCart.Size = new System.Drawing.Size(196, 38);
            this.lblFoodMenunCart.TabIndex = 49;
            this.lblFoodMenunCart.Text = "Food Menu :";
            // 
            // txtFoodSearch
            // 
            this.txtFoodSearch.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodSearch.Location = new System.Drawing.Point(84, 145);
            this.txtFoodSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFoodSearch.Name = "txtFoodSearch";
            this.txtFoodSearch.Size = new System.Drawing.Size(450, 45);
            this.txtFoodSearch.TabIndex = 48;
            // 
            // lblCusFoodMenuandOrder
            // 
            this.lblCusFoodMenuandOrder.AutoSize = true;
            this.lblCusFoodMenuandOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblCusFoodMenuandOrder.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusFoodMenuandOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCusFoodMenuandOrder.Location = new System.Drawing.Point(284, 26);
            this.lblCusFoodMenuandOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusFoodMenuandOrder.Name = "lblCusFoodMenuandOrder";
            this.lblCusFoodMenuandOrder.Size = new System.Drawing.Size(683, 59);
            this.lblCusFoodMenuandOrder.TabIndex = 0;
            this.lblCusFoodMenuandOrder.Text = "Food Menu and Order Food";
            this.lblCusFoodMenuandOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFoodCart
            // 
            this.panelFoodCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFoodCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFoodCart.Controls.Add(this.lstOrderDetails);
            this.panelFoodCart.Location = new System.Drawing.Point(645, 210);
            this.panelFoodCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFoodCart.Name = "panelFoodCart";
            this.panelFoodCart.Size = new System.Drawing.Size(576, 267);
            this.panelFoodCart.TabIndex = 59;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_header.Controls.Add(this.lblCusFoodMenuandOrder);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1267, 105);
            this.panel_header.TabIndex = 46;
            // 
            // pbxSearchMenu
            // 
            this.pbxSearchMenu.ErrorImage = global::IOOP_Assignment.Properties.Resources.SearchLogo;
            this.pbxSearchMenu.Image = global::IOOP_Assignment.Properties.Resources.SearchLogo;
            this.pbxSearchMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxSearchMenu.InitialImage")));
            this.pbxSearchMenu.Location = new System.Drawing.Point(547, 145);
            this.pbxSearchMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxSearchMenu.Name = "pbxSearchMenu";
            this.pbxSearchMenu.Size = new System.Drawing.Size(49, 44);
            this.pbxSearchMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearchMenu.TabIndex = 57;
            this.pbxSearchMenu.TabStop = false;
            this.pbxSearchMenu.Click += new System.EventHandler(this.pbxSearchMenu_Click);
            // 
            // pbxShowCart
            // 
            this.pbxShowCart.Image = global::IOOP_Assignment.Properties.Resources.ShoppingCartLogo;
            this.pbxShowCart.Location = new System.Drawing.Point(512, 543);
            this.pbxShowCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxShowCart.Name = "pbxShowCart";
            this.pbxShowCart.Size = new System.Drawing.Size(26, 22);
            this.pbxShowCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShowCart.TabIndex = 61;
            this.pbxShowCart.TabStop = false;
            this.pbxShowCart.Click += new System.EventHandler(this.pbxShowCart_Click);
            // 
            // pbxShowMenu
            // 
            this.pbxShowMenu.Image = global::IOOP_Assignment.Properties.Resources.menuLogo;
            this.pbxShowMenu.Location = new System.Drawing.Point(512, 543);
            this.pbxShowMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxShowMenu.Name = "pbxShowMenu";
            this.pbxShowMenu.Size = new System.Drawing.Size(26, 22);
            this.pbxShowMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShowMenu.TabIndex = 62;
            this.pbxShowMenu.TabStop = false;
            this.pbxShowMenu.Click += new System.EventHandler(this.pbxShowMenu_Click);
            // 
            // CustomerOrderFoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblShowCartnMenu);
            this.Controls.Add(this.pbxSearchMenu);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.dgvFoodMenu);
            this.Controls.Add(this.lblFoodMenunCart);
            this.Controls.Add(this.txtFoodSearch);
            this.Controls.Add(this.panelFoodCart);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.pbxShowMenu);
            this.Controls.Add(this.pbxShowCart);
            this.Controls.Add(this.panelFoodCategories);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerOrderFoodMenu";
            this.Size = new System.Drawing.Size(1267, 584);
            this.Load += new System.EventHandler(this.CustomerFoodMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodMenu)).EndInit();
            this.panelFoodCategories.ResumeLayout(false);
            this.panelFoodCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppetizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeverages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainCourse)).EndInit();
            this.panelFoodCart.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearchMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShowMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblAllCategories;
        private System.Windows.Forms.PictureBox pbxAll;
        private System.Windows.Forms.Label lblAppetizer;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.ListBox lstOrderDetails;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.PictureBox pbxDessert;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.PictureBox pbxAppetizer;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.Label lblShowCartnMenu;
        private System.Windows.Forms.PictureBox pbxShowMenu;
        private System.Windows.Forms.PictureBox pbxSearchMenu;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.PictureBox pbxBeverages;
        private System.Windows.Forms.DataGridView dgvFoodMenu;
        private System.Windows.Forms.PictureBox pbxMainCourse;
        private System.Windows.Forms.Label lblFoodCategory;
        private System.Windows.Forms.PictureBox pbxShowCart;
        private System.Windows.Forms.Panel panelFoodCategories;
        private System.Windows.Forms.Label lblFoodMenunCart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFoodSearch;
        private System.Windows.Forms.Label lblCusFoodMenuandOrder;
        private System.Windows.Forms.Panel panelFoodCart;
        private System.Windows.Forms.Panel panel_header;
    }
}
