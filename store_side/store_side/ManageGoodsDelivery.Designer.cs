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
            this.product2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product2TableAdapter = new store_side.cnpmDataSet1TableAdapters.product2TableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.cnpmDataSet2 = new store_side.cnpmDataSet2();
            this.exportProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportProductTableAdapter = new store_side.cnpmDataSet2TableAdapters.exportProductTableAdapter();
            this.product2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodbelongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 333);
            this.dataGridView1.TabIndex = 0;
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
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.produnitDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.prodbelongDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.product2BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(291, 418);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(758, 192);
            this.dataGridView2.TabIndex = 1;
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
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(46, 439);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "button1";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cnpmDataSet2
            // 
            this.cnpmDataSet2.DataSetName = "cnpmDataSet2";
            this.cnpmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exportProductBindingSource
            // 
            this.exportProductBindingSource.DataMember = "exportProduct";
            this.exportProductBindingSource.DataSource = this.cnpmDataSet2;
            // 
            // exportProductTableAdapter
            // 
            this.exportProductTableAdapter.ClearBeforeFill = true;
            // 
            // product2BindingSource1
            // 
            this.product2BindingSource1.DataMember = "product2";
            this.product2BindingSource1.DataSource = this.cnpmDataSet1;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodidDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodnameDataGridViewTextBoxColumn.Width = 125;
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
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodpriceDataGridViewTextBoxColumn.Width = 125;
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
            // ManageGoodsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageGoodsDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGoodsDelivery";
            this.Load += new System.EventHandler(this.ManageGoodsDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpmDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button backButton;
        private cnpmDataSet2 cnpmDataSet2;
        private System.Windows.Forms.BindingSource exportProductBindingSource;
        private cnpmDataSet2TableAdapters.exportProductTableAdapter exportProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodbelongDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource product2BindingSource1;
    }
}