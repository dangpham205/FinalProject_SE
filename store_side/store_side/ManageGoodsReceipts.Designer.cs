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
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnpmDataSet = new store_side.cnpmDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new store_side.cnpmDataSetTableAdapters.productTableAdapter();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(957, 152);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(280, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 150);
            this.dataGridView1.TabIndex = 1;
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
            // ManageGoodsReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Name = "ManageGoodsReceipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGoodsReceipts";
            this.Load += new System.EventHandler(this.ManageGoodsReceipts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
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
    }
}