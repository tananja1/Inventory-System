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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            using var db = new AppDbContext();

            var product = new Product
            {
                Name = txtName.Text,
                CategoryId = (int)cmbCategory.SelectedValue,
                PurchasePrice = decimal.Parse(txtPurchase.Text),
                SalePrice = decimal.Parse(txtSale.Text),
                ReorderLevel = int.Parse(txtReorder.Text),
                QuantityOnHand = 0
            };

            db.Products.Add(product);
            db.SaveChanges();
            LoadProducts();
        }
        private void LoadProducts()
        {
            using var db = new AppDbContext();

            var products = db.Products
                .Select(p => new
                {
                    p.ProductId,
                    p.Name,
                    Category = p.Category.Name,
                    p.PurchasePrice,
                    p.SalePrice,
                    p.QuantityOnHand,
                    p.ReorderLevel
                })
                .ToList();

            dgvProductsList.DataSource = null;
            dgvProductsList.DataSource = products;
        }

        private void LoadCategories()
        {
            using var db = new AppDbContext();
            var categories = db.Categories.ToList();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1; // ensures no default selection


        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryForm();
            categoryForm.ShowDialog(); // Show it as a modal dialog
            LoadCategories();          // Reload the ComboBox after closing
        }
    }
}
