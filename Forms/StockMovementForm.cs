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
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Forms
{
    public partial class StockMovementForm : Form
    {
        public StockMovementForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            int productId = (int)cmbProduct.SelectedValue;
            int qty = int.Parse(txtQuantity.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            string type = cmbType.Text;

            var product = db.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            if (type == "Sale" && product.QuantityOnHand < qty)
            {
                MessageBox.Show("Insufficient stock.");
                return;
            }

            // Update Quantity
            product.QuantityOnHand += (type == "Purchase" ? qty : -qty);

            // Log transaction
            var transaction = new StockTransaction
            {
                ProductId = productId,
                Quantity = qty,
                Type = type,
                PricePerUnit = price
            };

            db.StockTransactions.Add(transaction);
            db.SaveChanges();
            MessageBox.Show($"{type} recorded.");
            LoadTransactionHistory();

        }
        private void LoadProducts()
        {
            using var db = new AppDbContext();
            var products = db.Products.ToList();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ProductId";
            cmbProduct.SelectedIndex = -1;
        }
        private void LoadTransactionHistory()
        {
            using var db = new AppDbContext();
            var history = db.StockTransactions
                .Select(t => new
                {
                    t.Date,
                    Product = t.Product.Name,
                    t.Type,
                    t.Quantity,
                    t.PricePerUnit
                })
                .ToList();

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = history;
        }

        private void LoadProductFilterOptions()
        {
            using var db = new AppDbContext();
            var products = db.Products.ToList();

            cmbFilterProduct.DataSource = products;
            cmbFilterProduct.DisplayMember = "Name";
            cmbFilterProduct.ValueMember = "ProductId";
            cmbFilterProduct.SelectedIndex = -1; // optional
        }

        private void FilterTransactions()
        {
            using var db = new AppDbContext();
            var query = db.StockTransactions.Include(t => t.Product).AsQueryable();

            var from = dtFrom.Value.Date;
            var to = dtTo.Value.Date.AddDays(1).AddTicks(-1);

            query = query.Where(t => t.Date >= from && t.Date <= to);

            if (cmbFilterType.Text == "Purchase" || cmbFilterType.Text == "Sale")
                query = query.Where(t => t.Type == cmbFilterType.Text);

            if (cmbFilterProduct.SelectedValue is int productId)
                query = query.Where(t => t.ProductId == productId);

            var results = query.Select(t => new
            {
                t.Date,
                Product = t.Product.Name,
                t.Type,
                t.Quantity,
                t.PricePerUnit
            }).ToList();

            dgvHistory.DataSource = results;
        }






        private void StockMovementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadTransactionHistory();
            LoadProductFilterOptions();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterTransactions();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvHistory.Width, this.dgvHistory.Height);
            dgvHistory.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvHistory.Width, this.dgvHistory.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

