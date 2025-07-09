namespace InventoryApp.Forms
{
    partial class StockMovementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovementForm));
            cmbProduct = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            cmbType = new ComboBox();
            btnSaveTransaction = new Button();
            dgvHistory = new DataGridView();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            cmbFilterType = new ComboBox();
            cmbFilterProduct = new ComboBox();
            btnFilter = new Button();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(30, 23);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 33);
            cmbProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 122);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(140, 73);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(201, 31);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(140, 122);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(201, 31);
            txtPrice.TabIndex = 4;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Purchase", "Sale" });
            cmbType.Location = new Point(30, 178);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(182, 33);
            cmbType.TabIndex = 5;
            cmbType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSaveTransaction
            // 
            btnSaveTransaction.Location = new Point(229, 176);
            btnSaveTransaction.Name = "btnSaveTransaction";
            btnSaveTransaction.Size = new Size(112, 34);
            btnSaveTransaction.TabIndex = 6;
            btnSaveTransaction.Text = "Save";
            btnSaveTransaction.UseVisualStyleBackColor = true;
            btnSaveTransaction.Click += btnSaveTransaction_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(382, 23);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(779, 408);
            dgvHistory.TabIndex = 7;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(30, 232);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(300, 31);
            dtFrom.TabIndex = 8;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(30, 282);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(300, 31);
            dtTo.TabIndex = 9;
            // 
            // cmbFilterType
            // 
            cmbFilterType.FormattingEnabled = true;
            cmbFilterType.Items.AddRange(new object[] { "All", "Purchase", "Sale" });
            cmbFilterType.Location = new Point(30, 319);
            cmbFilterType.Name = "cmbFilterType";
            cmbFilterType.Size = new Size(182, 33);
            cmbFilterType.TabIndex = 10;
            // 
            // cmbFilterProduct
            // 
            cmbFilterProduct.FormattingEnabled = true;
            cmbFilterProduct.Location = new Point(30, 358);
            cmbFilterProduct.Name = "cmbFilterProduct";
            cmbFilterProduct.Size = new Size(182, 33);
            cmbFilterProduct.TabIndex = 11;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(30, 397);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(165, 34);
            btnFilter.TabIndex = 12;
            btnFilter.Text = "Filter Transaction";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(218, 397);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Print Preview";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // StockMovementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 734);
            Controls.Add(btnPrint);
            Controls.Add(btnFilter);
            Controls.Add(cmbFilterProduct);
            Controls.Add(cmbFilterType);
            Controls.Add(dtTo);
            Controls.Add(dtFrom);
            Controls.Add(dgvHistory);
            Controls.Add(btnSaveTransaction);
            Controls.Add(cmbType);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbProduct);
            Name = "StockMovementForm";
            Text = "StockMovementForm";
            Load += StockMovementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private Label label1;
        private Label label2;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cmbType;
        private Button btnSaveTransaction;
        private DataGridView dgvHistory;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private ComboBox cmbFilterType;
        private ComboBox cmbFilterProduct;
        private Button btnFilter;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}