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
            this.receiptButton = new System.Windows.Forms.Button();
            this.manageReceiptsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(159, 136);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(307, 23);
            this.receiptButton.TabIndex = 0;
            this.receiptButton.Text = "CREATE GOODS RECEIPTS";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // manageReceiptsButton
            // 
            this.manageReceiptsButton.Location = new System.Drawing.Point(486, 290);
            this.manageReceiptsButton.Name = "manageReceiptsButton";
            this.manageReceiptsButton.Size = new System.Drawing.Size(400, 23);
            this.manageReceiptsButton.TabIndex = 1;
            this.manageReceiptsButton.Text = "MANAGE GOODS RECEIPTS";
            this.manageReceiptsButton.UseVisualStyleBackColor = true;
            this.manageReceiptsButton.Click += new System.EventHandler(this.manageReceiptsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.manageReceiptsButton);
            this.Controls.Add(this.receiptButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button manageReceiptsButton;
    }
}