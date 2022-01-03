namespace store_side
{
    partial class StockManagementandIncome
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
            this.instockTable = new System.Windows.Forms.DataGridView();
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.soldTable = new System.Windows.Forms.DataGridView();
            this.cnpmDataSet1 = new store_side.cnpmDataSet1();
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter = new store_side.cnpmDataSet1TableAdapters.product2TableAdapter();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new store_side.cnpmDataSet1TableAdapters.billTableAdapter();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverystatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.Label();
            this.rp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instockTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
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
            this.backButton.TabIndex = 22;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // instockTable
            // 
            this.instockTable.AllowUserToAddRows = false;
            this.instockTable.AllowUserToDeleteRows = false;
            this.instockTable.AutoGenerateColumns = false;
            this.instockTable.BackgroundColor = System.Drawing.Color.Violet;
            this.instockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.produnitDataGridViewTextBoxColumn,
            this.prodcostDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.prodbelongDataGridViewTextBoxColumn});
            this.instockTable.DataSource = this.productBindingSource;
            this.instockTable.Location = new System.Drawing.Point(30, 266);
            this.instockTable.Name = "instockTable";
            this.instockTable.ReadOnly = true;
            this.instockTable.RowHeadersWidth = 51;
            this.instockTable.RowTemplate.Height = 24;
            this.instockTable.Size = new System.Drawing.Size(555, 451);
            this.instockTable.TabIndex = 23;
            this.instockTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.instockTable_DataBindingComplete);
            // 
            // cnpmDataSet
            // 
            this.cnpmDataSet.DataSetName = "cnpmDataSet";
            this.cnpmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.cnpmDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // soldTable
            // 
            this.soldTable.AllowUserToAddRows = false;
            this.soldTable.AllowUserToDeleteRows = false;
            this.soldTable.AutoGenerateColumns = false;
            this.soldTable.BackgroundColor = System.Drawing.Color.Violet;
            this.soldTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn1,
            this.prodnameDataGridViewTextBoxColumn1,
            this.produnitDataGridViewTextBoxColumn1,
            this.prodpriceDataGridViewTextBoxColumn1,
            this.prodbelongDataGridViewTextBoxColumn1});
            this.soldTable.DataSource = this.product2BindingSource;
            this.soldTable.Location = new System.Drawing.Point(629, 266);
            this.soldTable.Name = "soldTable";
            this.soldTable.ReadOnly = true;
            this.soldTable.RowHeadersWidth = 51;
            this.soldTable.RowTemplate.Height = 24;
            this.soldTable.Size = new System.Drawing.Size(518, 451);
            this.soldTable.TabIndex = 24;
            this.soldTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.soldTable_DataBindingComplete);
            // 
            // cnpmDataSet1
            // 
            this.cnpmDataSet1.DataSetName = "cnpmDataSet1";
            this.cnpmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.produnitDataGridViewTextBoxColumn.HeaderText = "Product Unit";
            this.produnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produnitDataGridViewTextBoxColumn.Name = "produnitDataGridViewTextBoxColumn";
            this.produnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodcostDataGridViewTextBoxColumn
            // 
            this.prodcostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodcostDataGridViewTextBoxColumn.DataPropertyName = "prod_cost";
            this.prodcostDataGridViewTextBoxColumn.HeaderText = "Product Cost";
            this.prodcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodcostDataGridViewTextBoxColumn.Name = "prodcostDataGridViewTextBoxColumn";
            this.prodcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodbelongDataGridViewTextBoxColumn
            // 
            this.prodbelongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodbelongDataGridViewTextBoxColumn.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.HeaderText = "Receipt ID";
            this.prodbelongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn.Name = "prodbelongDataGridViewTextBoxColumn";
            this.prodbelongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodidDataGridViewTextBoxColumn1
            // 
            this.prodidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodidDataGridViewTextBoxColumn1.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.prodidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn1.Name = "prodidDataGridViewTextBoxColumn1";
            this.prodidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodnameDataGridViewTextBoxColumn1
            // 
            this.prodnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodnameDataGridViewTextBoxColumn1.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.prodnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn1.Name = "prodnameDataGridViewTextBoxColumn1";
            this.prodnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // produnitDataGridViewTextBoxColumn1
            // 
            this.produnitDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produnitDataGridViewTextBoxColumn1.DataPropertyName = "prod_unit";
            this.produnitDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.produnitDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.produnitDataGridViewTextBoxColumn1.Name = "produnitDataGridViewTextBoxColumn1";
            this.produnitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodpriceDataGridViewTextBoxColumn1
            // 
            this.prodpriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodpriceDataGridViewTextBoxColumn1.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.prodpriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn1.Name = "prodpriceDataGridViewTextBoxColumn1";
            this.prodpriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodbelongDataGridViewTextBoxColumn1
            // 
            this.prodbelongDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodbelongDataGridViewTextBoxColumn1.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn1.HeaderText = "Note ID";
            this.prodbelongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn1.Name = "prodbelongDataGridViewTextBoxColumn1";
            this.prodbelongDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Goods In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Goods Sold";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.rp);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.month);
            this.groupBox1.Location = new System.Drawing.Point(315, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 173);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revenue";
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Location = new System.Drawing.Point(112, 41);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(122, 24);
            this.month.TabIndex = 28;
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(324, 41);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(122, 24);
            this.year.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Year:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(386, 113);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 36);
            this.okButton.TabIndex = 32;
            this.okButton.Text = "VIEW";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(629, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(52, 21);
            this.dataGridView1.TabIndex = 28;
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
            // report
            // 
            this.report.AutoSize = true;
            this.report.Location = new System.Drawing.Point(714, 39);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(0, 17);
            this.report.TabIndex = 29;
            this.report.Visible = false;
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp.Location = new System.Drawing.Point(54, 120);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(59, 20);
            this.rp.TabIndex = 30;
            this.rp.Text = "label5";
            this.rp.Visible = false;
            // 
            // StockManagementandIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.report);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soldTable);
            this.Controls.Add(this.instockTable);
            this.Controls.Add(this.backButton);
            this.Name = "StockManagementandIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management and Income";
            this.Load += new System.EventHandler(this.StockManagementandIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instockTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView instockTable;
        private cnpmDataSet cnpmDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cnpmDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView soldTable;
        private cnpmDataSet1 cnpmDataSet1;
        private System.Windows.Forms.BindingSource product2BindingSource;
        private cnpmDataSet1TableAdapters.product2TableAdapter product2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox month;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private cnpmDataSet1TableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverystatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label report;
        private System.Windows.Forms.Label rp;
    }
}