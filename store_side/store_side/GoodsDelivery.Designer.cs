namespace store_side
{
    partial class GoodsDelivery
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
            this.backButton = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.billTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.billPayment = new System.Windows.Forms.ComboBox();
            this.billDelivery = new System.Windows.Forms.ComboBox();
            this.billAdress = new System.Windows.Forms.TextBox();
            this.billName = new System.Windows.Forms.TextBox();
            this.billID = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.á = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.GroupBox();
            this.billPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.quantityDialog = new System.Windows.Forms.GroupBox();
            this.quantityButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmDataSet1 = new store_side.cnpmDataSet1();
            this.billTableAdapter = new store_side.cnpmDataSet1TableAdapters.billTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter = new store_side.cnpmDataSet1TableAdapters.product2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.x.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.quantityDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGreen;
            this.backButton.BackgroundImage = global::store_side.Properties.Resources.b;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 43);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AutoGenerateColumns = false;
            this.productTable.BackgroundColor = System.Drawing.Color.Violet;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prod_unit,
            this.prodpriceDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.productBindingSource;
            this.productTable.Location = new System.Drawing.Point(30, 50);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(526, 679);
            this.productTable.TabIndex = 9;
            this.productTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productTable_DataBindingComplete);
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prod_unit
            // 
            this.prod_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prod_unit.DataPropertyName = "prod_unit";
            this.prod_unit.HeaderText = "In Stock";
            this.prod_unit.MinimumWidth = 6;
            this.prod_unit.Name = "prod_unit";
            this.prod_unit.ReadOnly = true;
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Product Price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.cnpmDataSet;
            // 
            // cnpmDataSet
            // 
            this.cnpmDataSet.DataSetName = "cnpmDataSet";
            this.cnpmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // billTable
            // 
            this.billTable.AllowUserToAddRows = false;
            this.billTable.AllowUserToDeleteRows = false;
            this.billTable.BackgroundColor = System.Drawing.Color.Violet;
            this.billTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.billTable.Location = new System.Drawing.Point(595, 229);
            this.billTable.Name = "billTable";
            this.billTable.ReadOnly = true;
            this.billTable.RowHeadersWidth = 51;
            this.billTable.RowTemplate.Height = 24;
            this.billTable.Size = new System.Drawing.Size(556, 399);
            this.billTable.TabIndex = 6;
            this.billTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.billTable_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.billPayment);
            this.groupBox1.Controls.Add(this.billDelivery);
            this.groupBox1.Controls.Add(this.billAdress);
            this.groupBox1.Controls.Add(this.billName);
            this.groupBox1.Controls.Add(this.billID);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.á);
            this.groupBox1.Location = new System.Drawing.Point(595, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note Information";
            // 
            // billPayment
            // 
            this.billPayment.FormattingEnabled = true;
            this.billPayment.Location = new System.Drawing.Point(412, 125);
            this.billPayment.Name = "billPayment";
            this.billPayment.Size = new System.Drawing.Size(101, 24);
            this.billPayment.TabIndex = 5;
            // 
            // billDelivery
            // 
            this.billDelivery.FormattingEnabled = true;
            this.billDelivery.Location = new System.Drawing.Point(147, 125);
            this.billDelivery.Name = "billDelivery";
            this.billDelivery.Size = new System.Drawing.Size(121, 24);
            this.billDelivery.TabIndex = 4;
            // 
            // billAdress
            // 
            this.billAdress.Location = new System.Drawing.Point(98, 83);
            this.billAdress.Name = "billAdress";
            this.billAdress.Size = new System.Drawing.Size(415, 22);
            this.billAdress.TabIndex = 3;
            // 
            // billName
            // 
            this.billName.Location = new System.Drawing.Point(348, 36);
            this.billName.Name = "billName";
            this.billName.Size = new System.Drawing.Size(165, 22);
            this.billName.TabIndex = 2;
            // 
            // billID
            // 
            this.billID.Location = new System.Drawing.Point(98, 38);
            this.billID.Name = "billID";
            this.billID.Size = new System.Drawing.Size(122, 22);
            this.billID.TabIndex = 1;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(34, 86);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(64, 17);
            this.B.TabIndex = 4;
            this.B.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Status:";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(252, 39);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(90, 17);
            this.A.TabIndex = 1;
            this.A.Text = "Agent Name:";
            // 
            // á
            // 
            this.á.AutoSize = true;
            this.á.Location = new System.Drawing.Point(34, 41);
            this.á.Name = "á";
            this.á.Size = new System.Drawing.Size(25, 17);
            this.á.TabIndex = 0;
            this.á.Text = "ID:";
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.Gainsboro;
            this.x.Controls.Add(this.billPrice);
            this.x.Controls.Add(this.label1);
            this.x.Location = new System.Drawing.Point(595, 629);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(556, 31);
            this.x.TabIndex = 8;
            this.x.TabStop = false;
            // 
            // billPrice
            // 
            this.billPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.billPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billPrice.Enabled = false;
            this.billPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billPrice.Location = new System.Drawing.Point(342, 5);
            this.billPrice.Name = "billPrice";
            this.billPrice.Size = new System.Drawing.Size(208, 23);
            this.billPrice.TabIndex = 1;
            this.billPrice.Text = "0";
            this.billPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price (VNĐ):";
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(787, 684);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 45);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductButton.Location = new System.Drawing.Point(595, 684);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(90, 45);
            this.addProductButton.TabIndex = 11;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProductButton.Location = new System.Drawing.Point(691, 684);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(90, 45);
            this.deleteProductButton.TabIndex = 12;
            this.deleteProductButton.Text = "DELETE";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(1053, 684);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 45);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(62, 36);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(152, 30);
            this.quantity.TabIndex = 14;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Visible = false;
            // 
            // quantityDialog
            // 
            this.quantityDialog.BackColor = System.Drawing.Color.MidnightBlue;
            this.quantityDialog.Controls.Add(this.quantityButton);
            this.quantityDialog.Controls.Add(this.quantity);
            this.quantityDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityDialog.Location = new System.Drawing.Point(440, 304);
            this.quantityDialog.Name = "quantityDialog";
            this.quantityDialog.Size = new System.Drawing.Size(265, 140);
            this.quantityDialog.TabIndex = 15;
            this.quantityDialog.TabStop = false;
            this.quantityDialog.Text = "Quantity";
            this.quantityDialog.Visible = false;
            // 
            // quantityButton
            // 
            this.quantityButton.ForeColor = System.Drawing.Color.Navy;
            this.quantityButton.Location = new System.Drawing.Point(172, 98);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(87, 36);
            this.quantityButton.TabIndex = 15;
            this.quantityButton.Text = "OK";
            this.quantityButton.UseVisualStyleBackColor = true;
            this.quantityButton.Visible = false;
            this.quantityButton.Click += new System.EventHandler(this.quantityButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billidDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.billtimeDataGridViewTextBoxColumn,
            this.deliverystatusDataGridViewTextBoxColumn,
            this.paymentstatusDataGridViewTextBoxColumn,
            this.billtotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(595, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(52, 26);
            this.dataGridView1.TabIndex = 16;
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "bill_id";
            this.billidDataGridViewTextBoxColumn.HeaderText = "bill_id";
            this.billidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            this.cusaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // billtimeDataGridViewTextBoxColumn
            // 
            this.billtimeDataGridViewTextBoxColumn.DataPropertyName = "bill_time";
            this.billtimeDataGridViewTextBoxColumn.HeaderText = "bill_time";
            this.billtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billtimeDataGridViewTextBoxColumn.Name = "billtimeDataGridViewTextBoxColumn";
            this.billtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverystatusDataGridViewTextBoxColumn
            // 
            this.deliverystatusDataGridViewTextBoxColumn.DataPropertyName = "delivery_status";
            this.deliverystatusDataGridViewTextBoxColumn.HeaderText = "delivery_status";
            this.deliverystatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverystatusDataGridViewTextBoxColumn.Name = "deliverystatusDataGridViewTextBoxColumn";
            this.deliverystatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverystatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentstatusDataGridViewTextBoxColumn
            // 
            this.paymentstatusDataGridViewTextBoxColumn.DataPropertyName = "payment_status";
            this.paymentstatusDataGridViewTextBoxColumn.HeaderText = "payment_status";
            this.paymentstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentstatusDataGridViewTextBoxColumn.Name = "paymentstatusDataGridViewTextBoxColumn";
            this.paymentstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // billtotalDataGridViewTextBoxColumn
            // 
            this.billtotalDataGridViewTextBoxColumn.DataPropertyName = "bill_total";
            this.billtotalDataGridViewTextBoxColumn.HeaderText = "bill_total";
            this.billtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billtotalDataGridViewTextBoxColumn.Name = "billtotalDataGridViewTextBoxColumn";
            this.billtotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.billtotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.cnpmDataSet1;
            // 
            // cnpmDataSet1
            // 
            this.cnpmDataSet1.DataSetName = "cnpmDataSet1";
            this.cnpmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn1,
            this.prodnameDataGridViewTextBoxColumn1,
            this.produnitDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn1,
            this.prodbelongDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.product2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(595, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(52, 26);
            this.dataGridView2.TabIndex = 17;
            // 
            // prodidDataGridViewTextBoxColumn1
            // 
            this.prodidDataGridViewTextBoxColumn1.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn1.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn1.Name = "prodidDataGridViewTextBoxColumn1";
            this.prodidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prodidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prodnameDataGridViewTextBoxColumn1
            // 
            this.prodnameDataGridViewTextBoxColumn1.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn1.Name = "prodnameDataGridViewTextBoxColumn1";
            this.prodnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prodnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // produnitDataGridViewTextBoxColumn
            // 
            this.produnitDataGridViewTextBoxColumn.DataPropertyName = "prod_unit";
            this.produnitDataGridViewTextBoxColumn.HeaderText = "prod_unit";
            this.produnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produnitDataGridViewTextBoxColumn.Name = "produnitDataGridViewTextBoxColumn";
            this.produnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.produnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodpriceDataGridViewTextBoxColumn1
            // 
            this.prodpriceDataGridViewTextBoxColumn1.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn1.HeaderText = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn1.Name = "prodpriceDataGridViewTextBoxColumn1";
            this.prodpriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prodpriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prodbelongDataGridViewTextBoxColumn
            // 
            this.prodbelongDataGridViewTextBoxColumn.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.HeaderText = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn.Name = "prodbelongDataGridViewTextBoxColumn";
            this.prodbelongDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodbelongDataGridViewTextBoxColumn.Width = 125;
            // 
            // product2BindingSource
            // 
            this.product2BindingSource.DataMember = "product2";
            this.product2BindingSource.DataSource = this.cnpmDataSet1;
            // 
            // product2TableAdapter
            // 
            this.product2TableAdapter.ClearBeforeFill = true;
            // 
            // GoodsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantityDialog);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.x);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.billTable);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.backButton);
            this.Name = "GoodsDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Goods Delivery Note";
            this.Load += new System.EventHandler(this.GoodsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.x.ResumeLayout(false);
            this.x.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.quantityDialog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView productTable;
        private cnpmDataSet cnpmDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cnpmDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView billTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox billPayment;
        private System.Windows.Forms.ComboBox billDelivery;
        private System.Windows.Forms.TextBox billAdress;
        private System.Windows.Forms.TextBox billName;
        private System.Windows.Forms.TextBox billID;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label á;
        private System.Windows.Forms.GroupBox x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billPrice;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.GroupBox quantityDialog;
        private System.Windows.Forms.Button quantityButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cnpmDataSet1 cnpmDataSet1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private cnpmDataSet1TableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverystatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource product2BindingSource;
        private cnpmDataSet1TableAdapters.product2TableAdapter product2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
    }
}