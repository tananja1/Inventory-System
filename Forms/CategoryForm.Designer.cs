namespace InventoryApp.Forms
{
    partial class CategoryForm
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
            dgvCategory = new DataGridView();
            label1 = new Label();
            txtCategoryName = new TextBox();
            btnAddCategory = new Button();
            btnRename = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(40, 79);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 62;
            dgvCategory.Size = new Size(975, 451);
            dgvCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 1;
            label1.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(208, 26);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(295, 31);
            txtCategoryName.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(89, 555);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 34);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(257, 555);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(112, 34);
            btnRename.TabIndex = 4;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(428, 555);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 601);
            Controls.Add(btnDelete);
            Controls.Add(btnRename);
            Controls.Add(btnAddCategory);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Controls.Add(dgvCategory);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategory;
        private Label label1;
        private TextBox txtCategoryName;
        private Button btnAddCategory;
        private Button btnRename;
        private Button btnDelete;
    }
}