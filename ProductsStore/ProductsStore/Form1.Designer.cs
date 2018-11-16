namespace ProductsStore
{
    partial class Storage
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
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.HeadLabel1 = new System.Windows.Forms.Label();
            this.SubmitProduct = new System.Windows.Forms.Button();
            this.ShelfLifeInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitInput = new System.Windows.Forms.ComboBox();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.CategoryInput = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FillStorePanel = new System.Windows.Forms.Panel();
            this.HeadLabel2 = new System.Windows.Forms.Label();
            this.ShelfStartDate = new System.Windows.Forms.DateTimePicker();
            this.ShelfStartDateLabel = new System.Windows.Forms.Label();
            this.PrimalPriceInput = new System.Windows.Forms.NumericUpDown();
            this.PrimalPrice = new System.Windows.Forms.Label();
            this.InsertStoredButton = new System.Windows.Forms.Button();
            this.CountInput = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.StoreProductName = new System.Windows.Forms.ComboBox();
            this.StoreNameLabel = new System.Windows.Forms.Label();
            this.productsList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeList = new System.Windows.Forms.DataGridView();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldProductsPanel = new System.Windows.Forms.Panel();
            this.oldProductsList = new System.Windows.Forms.DataGridView();
            this.RemoveOldProducts = new System.Windows.Forms.Button();
            this.oldProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfLifeInput)).BeginInit();
            this.FillStorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimalPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeList)).BeginInit();
            this.OldProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductPanel.Controls.Add(this.HeadLabel1);
            this.addProductPanel.Controls.Add(this.SubmitProduct);
            this.addProductPanel.Controls.Add(this.ShelfLifeInput);
            this.addProductPanel.Controls.Add(this.label1);
            this.addProductPanel.Controls.Add(this.UnitInput);
            this.addProductPanel.Controls.Add(this.UnitLabel);
            this.addProductPanel.Controls.Add(this.CategoryInput);
            this.addProductPanel.Controls.Add(this.CategoryLabel);
            this.addProductPanel.Controls.Add(this.ProductNameInput);
            this.addProductPanel.Controls.Add(this.NameLabel);
            this.addProductPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductPanel.Location = new System.Drawing.Point(13, 13);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(434, 221);
            this.addProductPanel.TabIndex = 0;
            // 
            // HeadLabel1
            // 
            this.HeadLabel1.AutoSize = true;
            this.HeadLabel1.Location = new System.Drawing.Point(71, 10);
            this.HeadLabel1.Name = "HeadLabel1";
            this.HeadLabel1.Size = new System.Drawing.Size(273, 20);
            this.HeadLabel1.TabIndex = 9;
            this.HeadLabel1.Text = "Добавить наименование продукта";
            // 
            // SubmitProduct
            // 
            this.SubmitProduct.Location = new System.Drawing.Point(3, 177);
            this.SubmitProduct.Name = "SubmitProduct";
            this.SubmitProduct.Size = new System.Drawing.Size(424, 37);
            this.SubmitProduct.TabIndex = 8;
            this.SubmitProduct.Text = "Добавить";
            this.SubmitProduct.UseVisualStyleBackColor = true;
            this.SubmitProduct.Click += new System.EventHandler(this.SubmitProduct_Click);
            // 
            // ShelfLifeInput
            // 
            this.ShelfLifeInput.Location = new System.Drawing.Point(157, 145);
            this.ShelfLifeInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ShelfLifeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ShelfLifeInput.Name = "ShelfLifeInput";
            this.ShelfLifeInput.Size = new System.Drawing.Size(270, 26);
            this.ShelfLifeInput.TabIndex = 7;
            this.ShelfLifeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Срок жизни, часов";
            // 
            // UnitInput
            // 
            this.UnitInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitInput.FormattingEnabled = true;
            this.UnitInput.Location = new System.Drawing.Point(157, 111);
            this.UnitInput.Name = "UnitInput";
            this.UnitInput.Size = new System.Drawing.Size(270, 28);
            this.UnitInput.TabIndex = 5;
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(3, 114);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(129, 20);
            this.UnitLabel.TabIndex = 4;
            this.UnitLabel.Text = "Ед. измерения: ";
            // 
            // CategoryInput
            // 
            this.CategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryInput.FormattingEnabled = true;
            this.CategoryInput.Location = new System.Drawing.Point(157, 77);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(270, 28);
            this.CategoryInput.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 80);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(97, 20);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Категория: ";
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.Location = new System.Drawing.Point(157, 45);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(270, 26);
            this.ProductNameInput.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(91, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название: ";
            // 
            // FillStorePanel
            // 
            this.FillStorePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FillStorePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FillStorePanel.Controls.Add(this.HeadLabel2);
            this.FillStorePanel.Controls.Add(this.ShelfStartDate);
            this.FillStorePanel.Controls.Add(this.ShelfStartDateLabel);
            this.FillStorePanel.Controls.Add(this.PrimalPriceInput);
            this.FillStorePanel.Controls.Add(this.PrimalPrice);
            this.FillStorePanel.Controls.Add(this.InsertStoredButton);
            this.FillStorePanel.Controls.Add(this.CountInput);
            this.FillStorePanel.Controls.Add(this.CountLabel);
            this.FillStorePanel.Controls.Add(this.StoreProductName);
            this.FillStorePanel.Controls.Add(this.StoreNameLabel);
            this.FillStorePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillStorePanel.Location = new System.Drawing.Point(455, 13);
            this.FillStorePanel.Name = "FillStorePanel";
            this.FillStorePanel.Size = new System.Drawing.Size(534, 221);
            this.FillStorePanel.TabIndex = 1;
            // 
            // HeadLabel2
            // 
            this.HeadLabel2.AutoSize = true;
            this.HeadLabel2.Location = new System.Drawing.Point(164, 10);
            this.HeadLabel2.Name = "HeadLabel2";
            this.HeadLabel2.Size = new System.Drawing.Size(222, 20);
            this.HeadLabel2.TabIndex = 10;
            this.HeadLabel2.Text = "Добавить продукт на склад";
            // 
            // ShelfStartDate
            // 
            this.ShelfStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ShelfStartDate.Location = new System.Drawing.Point(157, 143);
            this.ShelfStartDate.Name = "ShelfStartDate";
            this.ShelfStartDate.Size = new System.Drawing.Size(370, 26);
            this.ShelfStartDate.TabIndex = 21;
            // 
            // ShelfStartDateLabel
            // 
            this.ShelfStartDateLabel.AutoSize = true;
            this.ShelfStartDateLabel.Location = new System.Drawing.Point(3, 145);
            this.ShelfStartDateLabel.Name = "ShelfStartDateLabel";
            this.ShelfStartDateLabel.Size = new System.Drawing.Size(103, 20);
            this.ShelfStartDateLabel.TabIndex = 20;
            this.ShelfStartDateLabel.Text = "Изготовлен:";
            // 
            // PrimalPriceInput
            // 
            this.PrimalPriceInput.DecimalPlaces = 2;
            this.PrimalPriceInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PrimalPriceInput.Location = new System.Drawing.Point(157, 111);
            this.PrimalPriceInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PrimalPriceInput.Name = "PrimalPriceInput";
            this.PrimalPriceInput.Size = new System.Drawing.Size(370, 26);
            this.PrimalPriceInput.TabIndex = 19;
            this.PrimalPriceInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PrimalPrice
            // 
            this.PrimalPrice.AutoSize = true;
            this.PrimalPrice.Location = new System.Drawing.Point(3, 113);
            this.PrimalPrice.Name = "PrimalPrice";
            this.PrimalPrice.Size = new System.Drawing.Size(97, 20);
            this.PrimalPrice.TabIndex = 18;
            this.PrimalPrice.Text = "Цена за ед.";
            // 
            // InsertStoredButton
            // 
            this.InsertStoredButton.Location = new System.Drawing.Point(3, 177);
            this.InsertStoredButton.Name = "InsertStoredButton";
            this.InsertStoredButton.Size = new System.Drawing.Size(529, 37);
            this.InsertStoredButton.TabIndex = 17;
            this.InsertStoredButton.Text = "Добавить";
            this.InsertStoredButton.UseVisualStyleBackColor = true;
            this.InsertStoredButton.Click += new System.EventHandler(this.InsertStoredButton_Click);
            // 
            // CountInput
            // 
            this.CountInput.DecimalPlaces = 2;
            this.CountInput.Location = new System.Drawing.Point(157, 79);
            this.CountInput.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.CountInput.Name = "CountInput";
            this.CountInput.Size = new System.Drawing.Size(370, 26);
            this.CountInput.TabIndex = 16;
            this.CountInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(3, 81);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(108, 20);
            this.CountLabel.TabIndex = 15;
            this.CountLabel.Text = "Количество: ";
            // 
            // StoreProductName
            // 
            this.StoreProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreProductName.FormattingEnabled = true;
            this.StoreProductName.Location = new System.Drawing.Point(157, 45);
            this.StoreProductName.Name = "StoreProductName";
            this.StoreProductName.Size = new System.Drawing.Size(370, 28);
            this.StoreProductName.TabIndex = 12;
            // 
            // StoreNameLabel
            // 
            this.StoreNameLabel.AutoSize = true;
            this.StoreNameLabel.Location = new System.Drawing.Point(3, 48);
            this.StoreNameLabel.Name = "StoreNameLabel";
            this.StoreNameLabel.Size = new System.Drawing.Size(91, 20);
            this.StoreNameLabel.TabIndex = 9;
            this.StoreNameLabel.Text = "Название: ";
            // 
            // productsList
            // 
            this.productsList.AllowUserToAddRows = false;
            this.productsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.Category,
            this.Unit,
            this.shelfLife});
            this.productsList.Location = new System.Drawing.Point(13, 240);
            this.productsList.Name = "productsList";
            this.productsList.RowHeadersVisible = false;
            this.productsList.Size = new System.Drawing.Size(434, 467);
            this.productsList.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Название";
            this.ProductName.Name = "ProductName";
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед. измерения";
            this.Unit.Name = "Unit";
            // 
            // shelfLife
            // 
            this.shelfLife.HeaderText = "Срок жизни";
            this.shelfLife.Name = "shelfLife";
            // 
            // storeList
            // 
            this.storeList.AllowUserToAddRows = false;
            this.storeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.storeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreID,
            this.StoreName,
            this.Amount,
            this.StoreUnit,
            this.Price,
            this.ShelfStart});
            this.storeList.Location = new System.Drawing.Point(455, 240);
            this.storeList.Name = "storeList";
            this.storeList.RowHeadersVisible = false;
            this.storeList.Size = new System.Drawing.Size(534, 467);
            this.storeList.TabIndex = 3;
            // 
            // StoreID
            // 
            this.StoreID.HeaderText = "ID";
            this.StoreID.Name = "StoreID";
            this.StoreID.Width = 30;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Название";
            this.StoreName.Name = "StoreName";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            // 
            // StoreUnit
            // 
            this.StoreUnit.HeaderText = "Ед. Измерения";
            this.StoreUnit.Name = "StoreUnit";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена за ед.";
            this.Price.Name = "Price";
            // 
            // ShelfStart
            // 
            this.ShelfStart.HeaderText = "Дата изготовления";
            this.ShelfStart.Name = "ShelfStart";
            // 
            // OldProductsPanel
            // 
            this.OldProductsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OldProductsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OldProductsPanel.Controls.Add(this.RemoveOldProducts);
            this.OldProductsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldProductsPanel.Location = new System.Drawing.Point(995, 13);
            this.OldProductsPanel.Name = "OldProductsPanel";
            this.OldProductsPanel.Size = new System.Drawing.Size(536, 221);
            this.OldProductsPanel.TabIndex = 4;
            // 
            // oldProductsList
            // 
            this.oldProductsList.AllowUserToAddRows = false;
            this.oldProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oldProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oldProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oldProductID,
            this.oldProductName,
            this.oldProductCount,
            this.oldProductUnit,
            this.oldProductPrice,
            this.oldPeriod});
            this.oldProductsList.Location = new System.Drawing.Point(995, 240);
            this.oldProductsList.Name = "oldProductsList";
            this.oldProductsList.ReadOnly = true;
            this.oldProductsList.RowHeadersVisible = false;
            this.oldProductsList.Size = new System.Drawing.Size(536, 467);
            this.oldProductsList.TabIndex = 5;
            // 
            // RemoveOldProducts
            // 
            this.RemoveOldProducts.Location = new System.Drawing.Point(3, 3);
            this.RemoveOldProducts.Name = "RemoveOldProducts";
            this.RemoveOldProducts.Size = new System.Drawing.Size(526, 211);
            this.RemoveOldProducts.TabIndex = 0;
            this.RemoveOldProducts.Text = "Списать просроченные продукты";
            this.RemoveOldProducts.UseVisualStyleBackColor = true;
            this.RemoveOldProducts.Click += new System.EventHandler(this.RemoveOldProducts_Click);
            // 
            // oldProductID
            // 
            this.oldProductID.HeaderText = "ID";
            this.oldProductID.Name = "oldProductID";
            this.oldProductID.ReadOnly = true;
            this.oldProductID.Width = 30;
            // 
            // oldProductName
            // 
            this.oldProductName.HeaderText = "Название";
            this.oldProductName.Name = "oldProductName";
            this.oldProductName.ReadOnly = true;
            // 
            // oldProductCount
            // 
            this.oldProductCount.HeaderText = "Количество";
            this.oldProductCount.Name = "oldProductCount";
            this.oldProductCount.ReadOnly = true;
            // 
            // oldProductUnit
            // 
            this.oldProductUnit.HeaderText = "Ед. Измерения";
            this.oldProductUnit.Name = "oldProductUnit";
            this.oldProductUnit.ReadOnly = true;
            // 
            // oldProductPrice
            // 
            this.oldProductPrice.HeaderText = "Цена за ед.";
            this.oldProductPrice.Name = "oldProductPrice";
            this.oldProductPrice.ReadOnly = true;
            // 
            // oldPeriod
            // 
            this.oldPeriod.HeaderText = "Просрочено на";
            this.oldPeriod.Name = "oldPeriod";
            this.oldPeriod.ReadOnly = true;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 721);
            this.Controls.Add(this.oldProductsList);
            this.Controls.Add(this.OldProductsPanel);
            this.Controls.Add(this.storeList);
            this.Controls.Add(this.productsList);
            this.Controls.Add(this.FillStorePanel);
            this.Controls.Add(this.addProductPanel);
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageKeeper";
            this.Load += new System.EventHandler(this.Storage_Load);
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShelfLifeInput)).EndInit();
            this.FillStorePanel.ResumeLayout(false);
            this.FillStorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimalPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeList)).EndInit();
            this.OldProductsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldProductsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.Panel FillStorePanel;
        private System.Windows.Forms.DataGridView productsList;
        private System.Windows.Forms.DataGridView storeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfStart;
        private System.Windows.Forms.NumericUpDown ShelfLifeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UnitInput;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.ComboBox CategoryInput;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitProduct;
        private System.Windows.Forms.DateTimePicker ShelfStartDate;
        private System.Windows.Forms.Label ShelfStartDateLabel;
        private System.Windows.Forms.NumericUpDown PrimalPriceInput;
        private System.Windows.Forms.Label PrimalPrice;
        private System.Windows.Forms.Button InsertStoredButton;
        private System.Windows.Forms.NumericUpDown CountInput;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.ComboBox StoreProductName;
        private System.Windows.Forms.Label StoreNameLabel;
        private System.Windows.Forms.Label HeadLabel1;
        private System.Windows.Forms.Label HeadLabel2;
        private System.Windows.Forms.Panel OldProductsPanel;
        private System.Windows.Forms.DataGridView oldProductsList;
        private System.Windows.Forms.Button RemoveOldProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldPeriod;
    }
}

