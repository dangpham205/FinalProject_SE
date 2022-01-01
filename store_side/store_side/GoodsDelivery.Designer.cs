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
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.backButton.Size = new System.Drawing.Size(53, 44);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.prod_unit,
            this.prodpriceDataGridViewTextBoxColumn});
            this.productTable.DataSource = this.productBindingSource;
            this.productTable.Location = new System.Drawing.Point(30, 53);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.RowHeadersWidth = 51;
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(597, 676);
            this.productTable.TabIndex = 5;
            this.productTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productTable_DataBindingComplete);
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
            // GoodsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.backButton);
            this.Name = "GoodsDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Goods Delivery";
            this.Load += new System.EventHandler(this.GoodsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
    }
}