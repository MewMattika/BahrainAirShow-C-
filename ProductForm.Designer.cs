namespace BahrainAirshow
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label productIDLabel;
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.tabControl_Product = new System.Windows.Forms.TabControl();
            this.tabPage_AirCraft = new System.Windows.Forms.TabPage();
            this.airCraftModelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airCraftModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableDataSet = new BahrainAirshow.ProductTableDataSet();
            this.textBox_BuySpe = new System.Windows.Forms.TextBox();
            this.button_BuyAll = new System.Windows.Forms.Button();
            this.button_BuySpecific = new System.Windows.Forms.Button();
            this.tabPage_Clothing = new System.Windows.Forms.TabPage();
            this.textBox_SelectedClothing = new System.Windows.Forms.TextBox();
            this.button_SelectIDCloth = new System.Windows.Forms.Button();
            this.button_buyAllCloth = new System.Windows.Forms.Button();
            this.clothingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_Toys = new System.Windows.Forms.TabPage();
            this.listBox_ToyName = new System.Windows.Forms.ListBox();
            this.toysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.textBox_SelectedToy = new System.Windows.Forms.TextBox();
            this.button_SelectIDToy = new System.Windows.Forms.Button();
            this.button_BuyAllToys = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.textBox_VatPrice = new System.Windows.Forms.TextBox();
            this.button_useVat = new System.Windows.Forms.Button();
            this.toysTableAdapter = new BahrainAirshow.ProductTableDataSetTableAdapters.ToysTableAdapter();
            this.tableAdapterManager = new BahrainAirshow.ProductTableDataSetTableAdapters.TableAdapterManager();
            this.airCraftModelTableAdapter = new BahrainAirshow.ProductTableDataSetTableAdapters.AirCraftModelTableAdapter();
            this.clothingTableAdapter = new BahrainAirshow.ProductTableDataSetTableAdapters.ClothingTableAdapter();
            this.label_TotalBuying = new System.Windows.Forms.Label();
            this.listBox_BillingList = new System.Windows.Forms.ListBox();
            this.Button_clear = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tabControl_Product.SuspendLayout();
            this.tabPage_AirCraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftModelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableDataSet)).BeginInit();
            this.tabPage_Clothing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clothingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingBindingSource)).BeginInit();
            this.tabPage_Toys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(65, 48);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 21);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(422, 98);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(58, 21);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(422, 44);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(109, 21);
            productIDLabel.TabIndex = 30;
            productIDLabel.Text = "Product ID:";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.Image = global::BahrainAirshow.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(457, 0);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(323, 102);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 5;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tabControl_Product
            // 
            this.tabControl_Product.Controls.Add(this.tabPage_AirCraft);
            this.tabControl_Product.Controls.Add(this.tabPage_Clothing);
            this.tabControl_Product.Controls.Add(this.tabPage_Toys);
            this.tabControl_Product.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold);
            this.tabControl_Product.ItemSize = new System.Drawing.Size(100, 39);
            this.tabControl_Product.Location = new System.Drawing.Point(12, 117);
            this.tabControl_Product.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl_Product.Name = "tabControl_Product";
            this.tabControl_Product.SelectedIndex = 0;
            this.tabControl_Product.Size = new System.Drawing.Size(751, 404);
            this.tabControl_Product.TabIndex = 17;
            // 
            // tabPage_AirCraft
            // 
            this.tabPage_AirCraft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_AirCraft.Controls.Add(this.airCraftModelDataGridView);
            this.tabPage_AirCraft.Controls.Add(this.textBox_BuySpe);
            this.tabPage_AirCraft.Controls.Add(this.button_BuyAll);
            this.tabPage_AirCraft.Controls.Add(this.button_BuySpecific);
            this.tabPage_AirCraft.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_AirCraft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_AirCraft.Location = new System.Drawing.Point(4, 43);
            this.tabPage_AirCraft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_AirCraft.Name = "tabPage_AirCraft";
            this.tabPage_AirCraft.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_AirCraft.Size = new System.Drawing.Size(743, 357);
            this.tabPage_AirCraft.TabIndex = 3;
            this.tabPage_AirCraft.Text = "AirCraft Model";
            this.tabPage_AirCraft.UseVisualStyleBackColor = true;
            // 
            // airCraftModelDataGridView
            // 
            this.airCraftModelDataGridView.AutoGenerateColumns = false;
            this.airCraftModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airCraftModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.airCraftModelDataGridView.DataSource = this.airCraftModelBindingSource;
            this.airCraftModelDataGridView.Location = new System.Drawing.Point(34, 20);
            this.airCraftModelDataGridView.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.airCraftModelDataGridView.Name = "airCraftModelDataGridView";
            this.airCraftModelDataGridView.RowTemplate.Height = 25;
            this.airCraftModelDataGridView.Size = new System.Drawing.Size(608, 220);
            this.airCraftModelDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = " Name";
            this.dataGridViewTextBoxColumn2.HeaderText = " Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn5.HeaderText = "Model";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // airCraftModelBindingSource
            // 
            this.airCraftModelBindingSource.DataMember = "AirCraftModel";
            this.airCraftModelBindingSource.DataSource = this.productTableDataSet;
            // 
            // productTableDataSet
            // 
            this.productTableDataSet.DataSetName = "ProductTableDataSet";
            this.productTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_BuySpe
            // 
            this.textBox_BuySpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BuySpe.Location = new System.Drawing.Point(569, 294);
            this.textBox_BuySpe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox_BuySpe.Name = "textBox_BuySpe";
            this.textBox_BuySpe.Size = new System.Drawing.Size(143, 26);
            this.textBox_BuySpe.TabIndex = 24;
            // 
            // button_BuyAll
            // 
            this.button_BuyAll.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuyAll.ForeColor = System.Drawing.Color.Navy;
            this.button_BuyAll.Location = new System.Drawing.Point(34, 294);
            this.button_BuyAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_BuyAll.Name = "button_BuyAll";
            this.button_BuyAll.Size = new System.Drawing.Size(104, 36);
            this.button_BuyAll.TabIndex = 19;
            this.button_BuyAll.Text = "Buy All";
            this.button_BuyAll.UseVisualStyleBackColor = true;
            this.button_BuyAll.Click += new System.EventHandler(this.button_BuyAll_Click);
            // 
            // button_BuySpecific
            // 
            this.button_BuySpecific.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuySpecific.ForeColor = System.Drawing.Color.Navy;
            this.button_BuySpecific.Location = new System.Drawing.Point(378, 294);
            this.button_BuySpecific.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_BuySpecific.Name = "button_BuySpecific";
            this.button_BuySpecific.Size = new System.Drawing.Size(150, 36);
            this.button_BuySpecific.TabIndex = 23;
            this.button_BuySpecific.Text = "Select to Add";
            this.button_BuySpecific.UseVisualStyleBackColor = true;
            this.button_BuySpecific.Click += new System.EventHandler(this.button_BuySpecific_Click);
            // 
            // tabPage_Clothing
            // 
            this.tabPage_Clothing.Controls.Add(this.textBox_SelectedClothing);
            this.tabPage_Clothing.Controls.Add(this.button_SelectIDCloth);
            this.tabPage_Clothing.Controls.Add(this.button_buyAllCloth);
            this.tabPage_Clothing.Controls.Add(this.clothingDataGridView);
            this.tabPage_Clothing.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold);
            this.tabPage_Clothing.ForeColor = System.Drawing.Color.Navy;
            this.tabPage_Clothing.Location = new System.Drawing.Point(4, 43);
            this.tabPage_Clothing.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Clothing.Name = "tabPage_Clothing";
            this.tabPage_Clothing.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage_Clothing.Size = new System.Drawing.Size(743, 357);
            this.tabPage_Clothing.TabIndex = 2;
            this.tabPage_Clothing.Text = "Clothing";
            this.tabPage_Clothing.UseVisualStyleBackColor = true;
            // 
            // textBox_SelectedClothing
            // 
            this.textBox_SelectedClothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SelectedClothing.Location = new System.Drawing.Point(570, 298);
            this.textBox_SelectedClothing.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox_SelectedClothing.Name = "textBox_SelectedClothing";
            this.textBox_SelectedClothing.Size = new System.Drawing.Size(143, 26);
            this.textBox_SelectedClothing.TabIndex = 28;
            // 
            // button_SelectIDCloth
            // 
            this.button_SelectIDCloth.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectIDCloth.ForeColor = System.Drawing.Color.Navy;
            this.button_SelectIDCloth.Location = new System.Drawing.Point(379, 298);
            this.button_SelectIDCloth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_SelectIDCloth.Name = "button_SelectIDCloth";
            this.button_SelectIDCloth.Size = new System.Drawing.Size(150, 36);
            this.button_SelectIDCloth.TabIndex = 27;
            this.button_SelectIDCloth.Text = "Select to Add";
            this.button_SelectIDCloth.UseVisualStyleBackColor = true;
            this.button_SelectIDCloth.Click += new System.EventHandler(this.button_SelectIDCloth_Click);
            // 
            // button_buyAllCloth
            // 
            this.button_buyAllCloth.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buyAllCloth.ForeColor = System.Drawing.Color.Navy;
            this.button_buyAllCloth.Location = new System.Drawing.Point(42, 298);
            this.button_buyAllCloth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_buyAllCloth.Name = "button_buyAllCloth";
            this.button_buyAllCloth.Size = new System.Drawing.Size(104, 36);
            this.button_buyAllCloth.TabIndex = 25;
            this.button_buyAllCloth.Text = "Buy All";
            this.button_buyAllCloth.UseVisualStyleBackColor = true;
            this.button_buyAllCloth.Click += new System.EventHandler(this.button_buyAllCloth_Click);
            // 
            // clothingDataGridView
            // 
            this.clothingDataGridView.AutoGenerateColumns = false;
            this.clothingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clothingDataGridView.DataSource = this.clothingBindingSource;
            this.clothingDataGridView.Location = new System.Drawing.Point(44, 19);
            this.clothingDataGridView.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clothingDataGridView.Name = "clothingDataGridView";
            this.clothingDataGridView.RowTemplate.Height = 25;
            this.clothingDataGridView.Size = new System.Drawing.Size(558, 220);
            this.clothingDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProdectID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProdectID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn9.HeaderText = "Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // clothingBindingSource
            // 
            this.clothingBindingSource.DataMember = "Clothing";
            this.clothingBindingSource.DataSource = this.productTableDataSet;
            // 
            // tabPage_Toys
            // 
            this.tabPage_Toys.AutoScroll = true;
            this.tabPage_Toys.Controls.Add(this.listBox_ToyName);
            this.tabPage_Toys.Controls.Add(productIDLabel);
            this.tabPage_Toys.Controls.Add(this.productIDTextBox);
            this.tabPage_Toys.Controls.Add(this.textBox_SelectedToy);
            this.tabPage_Toys.Controls.Add(this.button_SelectIDToy);
            this.tabPage_Toys.Controls.Add(this.button_BuyAllToys);
            this.tabPage_Toys.Controls.Add(priceLabel);
            this.tabPage_Toys.Controls.Add(this.priceTextBox);
            this.tabPage_Toys.Controls.Add(nameLabel);
            this.tabPage_Toys.Location = new System.Drawing.Point(4, 43);
            this.tabPage_Toys.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabPage_Toys.Name = "tabPage_Toys";
            this.tabPage_Toys.Size = new System.Drawing.Size(743, 357);
            this.tabPage_Toys.TabIndex = 4;
            this.tabPage_Toys.Text = "Toys";
            this.tabPage_Toys.UseVisualStyleBackColor = true;
            // 
            // listBox_ToyName
            // 
            this.listBox_ToyName.DataSource = this.toysBindingSource;
            this.listBox_ToyName.DisplayMember = "Name";
            this.listBox_ToyName.FormattingEnabled = true;
            this.listBox_ToyName.ItemHeight = 19;
            this.listBox_ToyName.Location = new System.Drawing.Point(135, 41);
            this.listBox_ToyName.Name = "listBox_ToyName";
            this.listBox_ToyName.Size = new System.Drawing.Size(230, 118);
            this.listBox_ToyName.TabIndex = 32;
            // 
            // toysBindingSource
            // 
            this.toysBindingSource.DataMember = "Toys";
            this.toysBindingSource.DataSource = this.productTableDataSet;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toysBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(537, 41);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.productIDTextBox.TabIndex = 31;
            // 
            // textBox_SelectedToy
            // 
            this.textBox_SelectedToy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SelectedToy.Location = new System.Drawing.Point(582, 282);
            this.textBox_SelectedToy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox_SelectedToy.Name = "textBox_SelectedToy";
            this.textBox_SelectedToy.Size = new System.Drawing.Size(143, 26);
            this.textBox_SelectedToy.TabIndex = 30;
            this.textBox_SelectedToy.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_SelectIDToy
            // 
            this.button_SelectIDToy.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectIDToy.ForeColor = System.Drawing.Color.Navy;
            this.button_SelectIDToy.Location = new System.Drawing.Point(391, 282);
            this.button_SelectIDToy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_SelectIDToy.Name = "button_SelectIDToy";
            this.button_SelectIDToy.Size = new System.Drawing.Size(150, 36);
            this.button_SelectIDToy.TabIndex = 29;
            this.button_SelectIDToy.Text = "Select to Add";
            this.button_SelectIDToy.UseVisualStyleBackColor = true;
            this.button_SelectIDToy.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_BuyAllToys
            // 
            this.button_BuyAllToys.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BuyAllToys.ForeColor = System.Drawing.Color.Navy;
            this.button_BuyAllToys.Location = new System.Drawing.Point(70, 282);
            this.button_BuyAllToys.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_BuyAllToys.Name = "button_BuyAllToys";
            this.button_BuyAllToys.Size = new System.Drawing.Size(104, 36);
            this.button_BuyAllToys.TabIndex = 27;
            this.button_BuyAllToys.Text = "Buy All";
            this.button_BuyAllToys.UseVisualStyleBackColor = true;
            this.button_BuyAllToys.Click += new System.EventHandler(this.button_BuyAllToys_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.toysBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(537, 95);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 27);
            this.priceTextBox.TabIndex = 4;
            // 
            // textBox_VatPrice
            // 
            this.textBox_VatPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VatPrice.Location = new System.Drawing.Point(607, 580);
            this.textBox_VatPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox_VatPrice.Name = "textBox_VatPrice";
            this.textBox_VatPrice.Size = new System.Drawing.Size(143, 26);
            this.textBox_VatPrice.TabIndex = 22;
            // 
            // button_useVat
            // 
            this.button_useVat.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_useVat.ForeColor = System.Drawing.Color.Navy;
            this.button_useVat.Location = new System.Drawing.Point(426, 555);
            this.button_useVat.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button_useVat.Name = "button_useVat";
            this.button_useVat.Size = new System.Drawing.Size(150, 52);
            this.button_useVat.TabIndex = 21;
            this.button_useVat.Text = "Price Inclusive VAT";
            this.button_useVat.UseVisualStyleBackColor = true;
            this.button_useVat.Click += new System.EventHandler(this.button_useVat_Click);
            // 
            // toysTableAdapter
            // 
            this.toysTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirCraftModelTableAdapter = this.airCraftModelTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClothingTableAdapter = this.clothingTableAdapter;
            this.tableAdapterManager.ToysTableAdapter = this.toysTableAdapter;
            this.tableAdapterManager.UpdateOrder = BahrainAirshow.ProductTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airCraftModelTableAdapter
            // 
            this.airCraftModelTableAdapter.ClearBeforeFill = true;
            // 
            // clothingTableAdapter
            // 
            this.clothingTableAdapter.ClearBeforeFill = true;
            // 
            // label_TotalBuying
            // 
            this.label_TotalBuying.AutoSize = true;
            this.label_TotalBuying.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalBuying.Font = new System.Drawing.Font("Tahoma", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalBuying.ForeColor = System.Drawing.Color.Navy;
            this.label_TotalBuying.Location = new System.Drawing.Point(33, 555);
            this.label_TotalBuying.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TotalBuying.Name = "label_TotalBuying";
            this.label_TotalBuying.Size = new System.Drawing.Size(174, 19);
            this.label_TotalBuying.TabIndex = 25;
            this.label_TotalBuying.Text = "Your Total Purchase";
            this.label_TotalBuying.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox_BillingList
            // 
            this.listBox_BillingList.FormattingEnabled = true;
            this.listBox_BillingList.ItemHeight = 16;
            this.listBox_BillingList.Location = new System.Drawing.Point(93, 627);
            this.listBox_BillingList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_BillingList.Name = "listBox_BillingList";
            this.listBox_BillingList.Size = new System.Drawing.Size(552, 196);
            this.listBox_BillingList.TabIndex = 26;
            // 
            // Button_clear
            // 
            this.Button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_clear.ForeColor = System.Drawing.Color.Navy;
            this.Button_clear.Location = new System.Drawing.Point(661, 627);
            this.Button_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(68, 28);
            this.Button_clear.TabIndex = 28;
            this.Button_clear.Text = "Clear ";
            this.Button_clear.UseVisualStyleBackColor = true;
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BahrainAirshow.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 865);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.listBox_BillingList);
            this.Controls.Add(this.label_TotalBuying);
            this.Controls.Add(this.textBox_VatPrice);
            this.Controls.Add(this.button_useVat);
            this.Controls.Add(this.tabControl_Product);
            this.Controls.Add(this.pictureBox_Logo);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tabControl_Product.ResumeLayout(false);
            this.tabPage_AirCraft.ResumeLayout(false);
            this.tabPage_AirCraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftModelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableDataSet)).EndInit();
            this.tabPage_Clothing.ResumeLayout(false);
            this.tabPage_Clothing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clothingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothingBindingSource)).EndInit();
            this.tabPage_Toys.ResumeLayout(false);
            this.tabPage_Toys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TabControl tabControl_Product;
        private System.Windows.Forms.TabPage tabPage_AirCraft;
        private System.Windows.Forms.TabPage tabPage_Clothing;
        private System.Windows.Forms.TabPage tabPage_Toys;
        private ProductTableDataSet productTableDataSet;
        private System.Windows.Forms.BindingSource toysBindingSource;
        private ProductTableDataSetTableAdapters.ToysTableAdapter toysTableAdapter;
        private ProductTableDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox priceTextBox;
        private ProductTableDataSetTableAdapters.ClothingTableAdapter clothingTableAdapter;
        private System.Windows.Forms.BindingSource clothingBindingSource;
        private ProductTableDataSetTableAdapters.AirCraftModelTableAdapter airCraftModelTableAdapter;
        private System.Windows.Forms.BindingSource airCraftModelBindingSource;
        private System.Windows.Forms.DataGridView airCraftModelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView clothingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button_BuyAll;
        private System.Windows.Forms.TextBox textBox_VatPrice;
        private System.Windows.Forms.Button button_useVat;
        private System.Windows.Forms.TextBox textBox_BuySpe;
        private System.Windows.Forms.Button button_BuySpecific;
        private System.Windows.Forms.Button button_buyAllCloth;
        private System.Windows.Forms.Button button_BuyAllToys;
        private System.Windows.Forms.Label label_TotalBuying;
        private System.Windows.Forms.TextBox textBox_SelectedClothing;
        private System.Windows.Forms.Button button_SelectIDCloth;
        private System.Windows.Forms.TextBox textBox_SelectedToy;
        private System.Windows.Forms.Button button_SelectIDToy;
        private System.Windows.Forms.ListBox listBox_BillingList;
        private System.Windows.Forms.Button Button_clear;
        private System.Windows.Forms.ListBox listBox_ToyName;
        private System.Windows.Forms.TextBox productIDTextBox;
    }
}