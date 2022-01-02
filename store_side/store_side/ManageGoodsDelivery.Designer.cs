namespace store_side
{
    partial class ManageGoodsDelivery
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
            this.productTable = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmDataSet1 = new store_side.cnpmDataSet1();
            this.product2TableAdapter = new store_side.cnpmDataSet1TableAdapters.product2TableAdapter();
            this.billTable = new System.Windows.Forms.DataGridView();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new store_side.cnpmDataSet1TableAdapters.billTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.billPayment = new System.Windows.Forms.ComboBox();
            this.billDelivery = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.deleteReceiptButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AutoGenerateColumns = false;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.produnitDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.prodbelongDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.product2BindingSource;
            this.productTable.Location = new System.Drawing.Point(30, 313);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(609, 414);
            this.productTable.TabIndex = 1;
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
            // produnitDataGridViewTextBoxColumn
            // 
            this.produnitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produnitDataGridViewTextBoxColumn.DataPropertyName = "prod_unit";
            this.produnitDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.produnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produnitDataGridViewTextBoxColumn.Name = "produnitDataGridViewTextBoxColumn";
            this.produnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodbelongDataGridViewTextBoxColumn
            // 
            this.prodbelongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodbelongDataGridViewTextBoxColumn.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.HeaderText = "Note ID";
            this.prodbelongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn.Name = "prodbelongDataGridViewTextBoxColumn";
            this.prodbelongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // product2BindingSource
            // 
            this.product2BindingSource.DataMember = "product2";
            this.product2BindingSource.DataSource = this.cnpmDataSet1;
            // 
            // cnpmDataSet1
            // 
            this.cnpmDataSet1.DataSetName = "cnpmDataSet1";
            this.cnpmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product2TableAdapter
            // 
            this.product2TableAdapter.ClearBeforeFill = true;
            // 
            // billTable
            // 
            this.billTable.AllowUserToAddRows = false;
            this.billTable.AllowUserToDeleteRows = false;
            this.billTable.AutoGenerateColumns = false;
            this.billTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billidDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.billtimeDataGridViewTextBoxColumn,
            this.deliverystatusDataGridViewTextBoxColumn,
            this.paymentstatusDataGridViewTextBoxColumn,
            this.billtotalDataGridViewTextBoxColumn});
            this.billTable.DataSource = this.billBindingSource;
            this.billTable.Location = new System.Drawing.Point(30, 50);
            this.billTable.Name = "billTable";
            this.billTable.ReadOnly = true;
            this.billTable.RowHeadersWidth = 51;
            this.billTable.RowTemplate.Height = 24;
            this.billTable.Size = new System.Drawing.Size(1120, 242);
            this.billTable.TabIndex = 2;
            this.billTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billTable_CellClick);
            this.billTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.billTable_DataBindingComplete);
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "bill_id";
            this.billidDataGridViewTextBoxColumn.HeaderText = "Note ID";
            this.billidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "Agent Name";
            this.cusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "Agent Address";
            this.cusaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            this.cusaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billtimeDataGridViewTextBoxColumn
            // 
            this.billtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billtimeDataGridViewTextBoxColumn.DataPropertyName = "bill_time";
            this.billtimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.billtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billtimeDataGridViewTextBoxColumn.Name = "billtimeDataGridViewTextBoxColumn";
            this.billtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverystatusDataGridViewTextBoxColumn
            // 
            this.deliverystatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliverystatusDataGridViewTextBoxColumn.DataPropertyName = "delivery_status";
            this.deliverystatusDataGridViewTextBoxColumn.HeaderText = "Delivery Status";
            this.deliverystatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverystatusDataGridViewTextBoxColumn.Name = "deliverystatusDataGridViewTextBoxColumn";
            this.deliverystatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentstatusDataGridViewTextBoxColumn
            // 
            this.paymentstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentstatusDataGridViewTextBoxColumn.DataPropertyName = "payment_status";
            this.paymentstatusDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.paymentstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentstatusDataGridViewTextBoxColumn.Name = "paymentstatusDataGridViewTextBoxColumn";
            this.paymentstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billtotalDataGridViewTextBoxColumn
            // 
            this.billtotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billtotalDataGridViewTextBoxColumn.DataPropertyName = "bill_total";
            this.billtotalDataGridViewTextBoxColumn.HeaderText = "Total Price (VNĐ)";
            this.billtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.billtotalDataGridViewTextBoxColumn.Name = "billtotalDataGridViewTextBoxColumn";
            this.billtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.cnpmDataSet1;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
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
            this.backButton.TabIndex = 21;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.billPayment);
            this.groupBox1.Controls.Add(this.billDelivery);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(667, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 128);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note Information";
            // 
            // billPayment
            // 
            this.billPayment.FormattingEnabled = true;
            this.billPayment.Location = new System.Drawing.Point(168, 79);
            this.billPayment.Name = "billPayment";
            this.billPayment.Size = new System.Drawing.Size(152, 24);
            this.billPayment.TabIndex = 5;
            // 
            // billDelivery
            // 
            this.billDelivery.FormattingEnabled = true;
            this.billDelivery.Location = new System.Drawing.Point(168, 32);
            this.billDelivery.Name = "billDelivery";
            this.billDelivery.Size = new System.Drawing.Size(152, 24);
            this.billDelivery.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Status:";
            // 
            // updateProductButton
            // 
            this.updateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProductButton.Location = new System.Drawing.Point(993, 447);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(157, 45);
            this.updateProductButton.TabIndex = 23;
            this.updateProductButton.Text = "UPDATE STATUS";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // deleteReceiptButton
            // 
            this.deleteReceiptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteReceiptButton.Location = new System.Drawing.Point(830, 447);
            this.deleteReceiptButton.Name = "deleteReceiptButton";
            this.deleteReceiptButton.Size = new System.Drawing.Size(157, 45);
            this.deleteReceiptButton.TabIndex = 24;
            this.deleteReceiptButton.Text = "REMOVE NOTE";
            this.deleteReceiptButton.UseVisualStyleBackColor = true;
            this.deleteReceiptButton.Click += new System.EventHandler(this.deleteReceiptButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Location = new System.Drawing.Point(667, 447);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 45);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ManageGoodsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteReceiptButton);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.billTable);
            this.Controls.Add(this.productTable);
            this.Name = "ManageGoodsDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Goods Delivery Notes";
            this.Load += new System.EventHandler(this.ManageGoodsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView productTable;
        private cnpmDataSet1 cnpmDataSet1;
        private System.Windows.Forms.BindingSource product2BindingSource;
        private cnpmDataSet1TableAdapters.product2TableAdapter product2TableAdapter;
        private System.Windows.Forms.DataGridView billTable;
        private System.Windows.Forms.BindingSource billBindingSource;
        private cnpmDataSet1TableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverystatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox billPayment;
        private System.Windows.Forms.ComboBox billDelivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button deleteReceiptButton;
        private System.Windows.Forms.Button refreshButton;
    }
}