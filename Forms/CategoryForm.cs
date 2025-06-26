using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Data;

namespace InventoryApp.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            var category = new Category { Name = txtCategoryName.Text };
            db.Categories.Add(category);
            db.SaveChanges();
            txtCategoryName.Clear(); //  Clear input
            LoadCategories();
        }
        private void LoadCategories()
        {
            using var db = new AppDbContext();
            var categories = db.Categories
                .Select(c => new { c.CategoryId, c.Name })
                .ToList();

            dgvCategory.DataSource = null;
            dgvCategory.DataSource = categories;
         

        }


        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
