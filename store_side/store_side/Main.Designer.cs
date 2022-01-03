namespace store_side
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.receiptButton = new System.Windows.Forms.Button();
            this.manageReceiptsButton = new System.Windows.Forms.Button();
            this.deliveryButton = new System.Windows.Forms.Button();
            this.manageBillsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Label();
            this.stockButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptButton
            // 
            this.receiptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptButton.Location = new System.Drawing.Point(239, 198);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(307, 93);
            this.receiptButton.TabIndex = 0;
            this.receiptButton.Text = "CREATE GOODS RECEIPT";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // manageReceiptsButton
            // 
            this.manageReceiptsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageReceiptsButton.Location = new System.Drawing.Point(657, 198);
            this.manageReceiptsButton.Name = "manageReceiptsButton";
            this.manageReceiptsButton.Size = new System.Drawing.Size(307, 93);
            this.manageReceiptsButton.TabIndex = 1;
            this.manageReceiptsButton.Text = "MANAGE GOODS RECEIPTS";
            this.manageReceiptsButton.UseVisualStyleBackColor = true;
            this.manageReceiptsButton.Click += new System.EventHandler(this.manageReceiptsButton_Click);
            // 
            // deliveryButton
            // 
            this.deliveryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryButton.Location = new System.Drawing.Point(239, 374);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(307, 93);
            this.deliveryButton.TabIndex = 2;
            this.deliveryButton.Text = "CREATE GOODS DELIVERY NOTE";
            this.deliveryButton.UseVisualStyleBackColor = true;
            this.deliveryButton.Click += new System.EventHandler(this.deliveryButton_Click);
            // 
            // manageBillsButton
            // 
            this.manageBillsButton.Location = new System.Drawing.Point(657, 374);
            this.manageBillsButton.Name = "manageBillsButton";
            this.manageBillsButton.Size = new System.Drawing.Size(307, 93);
            this.manageBillsButton.TabIndex = 3;
            this.manageBillsButton.Text = "MANAGE GOODS DELIVERY NOTES";
            this.manageBillsButton.UseVisualStyleBackColor = true;
            this.manageBillsButton.Click += new System.EventHandler(this.manageBillsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(1054, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "admin123";
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(1087, 54);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(5);
            this.logoutButton.Size = new System.Drawing.Size(69, 27);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // stockButton
            // 
            this.stockButton.Location = new System.Drawing.Point(448, 542);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(307, 90);
            this.stockButton.TabIndex = 7;
            this.stockButton.Text = "STOCK AND INCOME";
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-86, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stockButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageBillsButton);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.manageReceiptsButton);
            this.Controls.Add(this.receiptButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button manageReceiptsButton;
        private System.Windows.Forms.Button deliveryButton;
        private System.Windows.Forms.Button manageBillsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logoutButton;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}