namespace store_side
{
    partial class ManageGoodsReceipts
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
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.receiptTable = new System.Windows.Forms.DataGridView();
            this.receiptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new store_side.cnpmDataSetTableAdapters.receiptTableAdapter();
            this.allProductButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productReceipt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.clearButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.deleteReceiptButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.prodbelongDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.produnitDataGridViewTextBoxColumn,
            this.prodcostDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.productBindingSource;
            this.productTable.Location = new System.Drawing.Point(30, 332);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(1120, 397);
            this.productTable.TabIndex = 19;
            this.productTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellClick);
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
            // prodbelongDataGridViewTextBoxColumn
            // 
            this.prodbelongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodbelongDataGridViewTextBoxColumn.DataPropertyName = "prod_belong";
            this.prodbelongDataGridViewTextBoxColumn.HeaderText = "Receipt ID";
            this.prodbelongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodbelongDataGridViewTextBoxColumn.Name = "prodbelongDataGridViewTextBoxColumn";
            this.prodbelongDataGridViewTextBoxColumn.ReadOnly = true;
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
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
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
            // receiptTable
            // 
            this.receiptTable.AllowUserToAddRows = false;
            this.receiptTable.AllowUserToDeleteRows = false;
            this.receiptTable.AutoGenerateColumns = false;
            this.receiptTable.BackgroundColor = System.Drawing.Color.Violet;
            this.receiptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptidDataGridViewTextBoxColumn,
            this.receiptnameDataGridViewTextBoxColumn});
            this.receiptTable.DataSource = this.receiptBindingSource;
            this.receiptTable.Location = new System.Drawing.Point(30, 50);
            this.receiptTable.Name = "receiptTable";
            this.receiptTable.ReadOnly = true;
            this.receiptTable.RowHeadersWidth = 51;
            this.receiptTable.RowTemplate.Height = 24;
            this.receiptTable.Size = new System.Drawing.Size(437, 225);
            this.receiptTable.TabIndex = 12;
            this.receiptTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptTable_CellClick);
            this.receiptTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.receiptTable_DataBindingComplete);
            // 
            // receiptidDataGridViewTextBoxColumn
            // 
            this.receiptidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiptidDataGridViewTextBoxColumn.DataPropertyName = "receipt_id";
            this.receiptidDataGridViewTextBoxColumn.HeaderText = "Receipt ID";
            this.receiptidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptidDataGridViewTextBoxColumn.Name = "receiptidDataGridViewTextBoxColumn";
            this.receiptidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptnameDataGridViewTextBoxColumn
            // 
            this.receiptnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiptnameDataGridViewTextBoxColumn.DataPropertyName = "receipt_name";
            this.receiptnameDataGridViewTextBoxColumn.HeaderText = "Receipt Name";
            this.receiptnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptnameDataGridViewTextBoxColumn.Name = "receiptnameDataGridViewTextBoxColumn";
            this.receiptnameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // allProductButton
            // 
            this.allProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allProductButton.Location = new System.Drawing.Point(30, 281);
            this.allProductButton.Name = "allProductButton";
            this.allProductButton.Size = new System.Drawing.Size(123, 45);
            this.allProductButton.TabIndex = 13;
            this.allProductButton.Text = "ALL PRODUCT";
            this.allProductButton.UseVisualStyleBackColor = true;
            this.allProductButton.Click += new System.EventHandler(this.allProductButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.productReceipt);
            this.groupBox2.Controls.Add(this.label1);
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
            this.groupBox2.Location = new System.Drawing.Point(559, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // productReceipt
            // 
            this.productReceipt.Location = new System.Drawing.Point(111, 106);
            this.productReceipt.Name = "productReceipt";
            this.productReceipt.Size = new System.Drawing.Size(148, 22);
            this.productReceipt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Receipt ID";
            // 
            // productCost
            // 
            this.productCost.Location = new System.Drawing.Point(346, 163);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(218, 22);
            this.productCost.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cost:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(346, 51);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(218, 22);
            this.productName.TabIndex = 2;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(346, 106);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(218, 22);
            this.productPrice.TabIndex = 4;
            // 
            // productUnit
            // 
            this.productUnit.Location = new System.Drawing.Point(111, 163);
            this.productUnit.Name = "productUnit";
            this.productUnit.Size = new System.Drawing.Size(148, 22);
            this.productUnit.TabIndex = 5;
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(111, 51);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(148, 22);
            this.productID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 166);
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
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(559, 281);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 45);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductButton.Location = new System.Drawing.Point(831, 281);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(102, 45);
            this.addProductButton.TabIndex = 16;
            this.addProductButton.Text = "ADD";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // updateProductButton
            // 
            this.updateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProductButton.Location = new System.Drawing.Point(939, 281);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(102, 45);
            this.updateProductButton.TabIndex = 17;
            this.updateProductButton.Text = "UPDATE ";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProductButton.Location = new System.Drawing.Point(1047, 281);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(103, 45);
            this.deleteProductButton.TabIndex = 18;
            this.deleteProductButton.Text = "DELETE ";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // deleteReceiptButton
            // 
            this.deleteReceiptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteReceiptButton.Location = new System.Drawing.Point(310, 281);
            this.deleteReceiptButton.Name = "deleteReceiptButton";
            this.deleteReceiptButton.Size = new System.Drawing.Size(157, 45);
            this.deleteReceiptButton.TabIndex = 14;
            this.deleteReceiptButton.Text = "REMOVE RECEIPT";
            this.deleteReceiptButton.UseVisualStyleBackColor = true;
            this.deleteReceiptButton.Click += new System.EventHandler(this.deleteReceiptButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGreen;
            this.backButton.BackgroundImage = global::store_side.Properties.Resources.b;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(1, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 43);
            this.backButton.TabIndex = 20;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageGoodsReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteReceiptButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.allProductButton);
            this.Controls.Add(this.receiptTable);
            this.Controls.Add(this.productTable);
            this.Name = "ManageGoodsReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Goods Receipts";
            this.Load += new System.EventHandler(this.ManageGoodsReceipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView productTable;
        private cnpmDataSet cnpmDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cnpmDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView receiptTable;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private cnpmDataSetTableAdapters.receiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button allProductButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox productCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productUnit;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.TextBox productReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteReceiptButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backButton;
    }
}