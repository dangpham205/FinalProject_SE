namespace store_side
{
    partial class GoodsReceipt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receiptName = new System.Windows.Forms.TextBox();
            this.receiptID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productUnit = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addReceiptButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new store_side.cnpmDataSetTableAdapters.TableAdapterManager();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.receiptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new store_side.cnpmDataSetTableAdapters.receiptTableAdapter();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.receiptName);
            this.groupBox1.Controls.Add(this.receiptID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods Receipt Info";
            // 
            // receiptName
            // 
            this.receiptName.Location = new System.Drawing.Point(106, 118);
            this.receiptName.Name = "receiptName";
            this.receiptName.Size = new System.Drawing.Size(262, 22);
            this.receiptName.TabIndex = 3;
            // 
            // receiptID
            // 
            this.receiptID.Location = new System.Drawing.Point(106, 51);
            this.receiptID.Name = "receiptID";
            this.receiptID.Size = new System.Drawing.Size(262, 22);
            this.receiptID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.productCost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.productName);
            this.groupBox2.Controls.Add(this.productPrice);
            this.groupBox2.Controls.Add(this.productUnit);
            this.groupBox2.Controls.Add(this.productID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(529, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // productCost
            // 
            this.productCost.Location = new System.Drawing.Point(230, 118);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(120, 22);
            this.productCost.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cost:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(329, 51);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(235, 22);
            this.productName.TabIndex = 5;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(437, 118);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(127, 22);
            this.productPrice.TabIndex = 8;
            // 
            // productUnit
            // 
            this.productUnit.Location = new System.Drawing.Point(72, 118);
            this.productUnit.Name = "productUnit";
            this.productUnit.Size = new System.Drawing.Size(68, 22);
            this.productUnit.TabIndex = 6;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(72, 51);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(148, 22);
            this.productID.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGreen;
            this.backButton.BackgroundImage = global::store_side.Properties.Resources.b;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 43);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productTable
            // 
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.productTable.Location = new System.Drawing.Point(59, 284);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(1061, 444);
            this.productTable.TabIndex = 20;
            this.productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellClick);
            this.productTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productTable_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Unit";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Cost (VNĐ)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Sell Price (VNĐ)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // addReceiptButton
            // 
            this.addReceiptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReceiptButton.Location = new System.Drawing.Point(1017, 230);
            this.addReceiptButton.Name = "addReceiptButton";
            this.addReceiptButton.Size = new System.Drawing.Size(103, 48);
            this.addReceiptButton.TabIndex = 12;
            this.addReceiptButton.Text = "SAVE";
            this.addReceiptButton.UseVisualStyleBackColor = true;
            this.addReceiptButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProductButton.Location = new System.Drawing.Point(908, 230);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(103, 48);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "DELETE ";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductButton.Location = new System.Drawing.Point(692, 230);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(102, 48);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "ADD ";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.accountantTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.productTableAdapter = null;
            this.tableAdapterManager1.receiptTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = store_side.cnpmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // updateProductButton
            // 
            this.updateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProductButton.Location = new System.Drawing.Point(800, 230);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(102, 48);
            this.updateProductButton.TabIndex = 10;
            this.updateProductButton.Text = "UPDATE ";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.produnitDataGridViewTextBoxColumn,
            this.prodcostDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.prodbelongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(52, 26);
            this.dataGridView1.TabIndex = 21;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // produnitDataGridViewTextBoxColumn
            // 
            this.produnitDataGridViewTextBoxColumn.DataPropertyName = "prod_unit";
            this.produnitDataGridViewTextBoxColumn.HeaderText = "prod_unit";
            this.produnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produnitDataGridViewTextBoxColumn.Name = "produnitDataGridViewTextBoxColumn";
            this.produnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodcostDataGridViewTextBoxColumn
            // 
            this.prodcostDataGridViewTextBoxColumn.DataPropertyName = "prod_cost";
            this.prodcostDataGridViewTextBoxColumn.HeaderText = "prod_cost";
            this.prodcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodcostDataGridViewTextBoxColumn.Name = "prodcostDataGridViewTextBoxColumn";
            this.prodcostDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodbelongDataGridViewTextBoxColumn
            // 
            this.prodbelongDataGridViewTextBoxColumn.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.HeaderText = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn.Name = "prodbelongDataGridViewTextBoxColumn";
            this.prodbelongDataGridViewTextBoxColumn.Width = 125;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptidDataGridViewTextBoxColumn,
            this.receiptnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.receiptBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(59, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(52, 26);
            this.dataGridView2.TabIndex = 22;
            // 
            // receiptidDataGridViewTextBoxColumn
            // 
            this.receiptidDataGridViewTextBoxColumn.DataPropertyName = "receipt_id";
            this.receiptidDataGridViewTextBoxColumn.HeaderText = "receipt_id";
            this.receiptidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptidDataGridViewTextBoxColumn.Name = "receiptidDataGridViewTextBoxColumn";
            this.receiptidDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptnameDataGridViewTextBoxColumn
            // 
            this.receiptnameDataGridViewTextBoxColumn.DataPropertyName = "receipt_name";
            this.receiptnameDataGridViewTextBoxColumn.HeaderText = "receipt_name";
            this.receiptnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptnameDataGridViewTextBoxColumn.Name = "receiptnameDataGridViewTextBoxColumn";
            this.receiptnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.cnpmDataSet;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(529, 230);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 48);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // GoodsReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addReceiptButton);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GoodsReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsReceipt";
            this.Load += new System.EventHandler(this.GoodsReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox receiptName;
        private System.Windows.Forms.TextBox receiptID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productUnit;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Button addReceiptButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        private cnpmDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.TextBox productCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cnpmDataSet cnpmDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cnpmDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private cnpmDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearButton;
    }
}