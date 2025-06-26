namespace InventoryApp.Forms
{
    partial class ProductForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPurchase = new TextBox();
            txtReorder = new TextBox();
            txtSale = new TextBox();
            cmbCategory = new ComboBox();
            dgvProductsList = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnManageCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 42);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 119);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 2;
            label3.Text = "Purchase Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 119);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 3;
            label4.Text = "Sale Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 175);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 4;
            label5.Text = "Reorder Level";
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 31);
            txtName.TabIndex = 5;
            // 
            // txtPurchase
            // 
            txtPurchase.Location = new Point(161, 119);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(232, 31);
            txtPurchase.TabIndex = 6;
            // 
            // txtReorder
            // 
            txtReorder.Location = new Point(161, 172);
            txtReorder.Name = "txtReorder";
            txtReorder.Size = new Size(232, 31);
            txtReorder.TabIndex = 7;
            // 
            // txtSale
            // 
            txtSale.Location = new Point(491, 119);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(216, 31);
            txtSale.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fruit", "Vegtables", "Drinks", "Local dish", "Foreign dish" });
            cmbCategory.Location = new Point(489, 42);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(218, 33);
            cmbCategory.TabIndex = 9;
            // 
            // dgvProductsList
            // 
            dgvProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsList.Location = new Point(255, 220);
            dgvProductsList.Name = "dgvProductsList";
            dgvProductsList.RowHeadersWidth = 62;
            dgvProductsList.Size = new Size(515, 261);
            dgvProductsList.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(38, 344);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(38, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Location = new Point(38, 468);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(185, 34);
            btnManageCategories.TabIndex = 14;
            btnManageCategories.Text = "Manage Categories";
            btnManageCategories.UseVisualStyleBackColor = true;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(btnManageCategories);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProductsList);
            Controls.Add(cmbCategory);
            Controls.Add(txtSale);
            Controls.Add(txtReorder);
            Controls.Add(txtPurchase);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPurchase;
        private TextBox txtReorder;
        private TextBox txtSale;
        private ComboBox cmbCategory;
        private DataGridView dgvProductsList;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnManageCategories;
    }
}