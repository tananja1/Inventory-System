using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Data
{
    public class Product
    {
        
        public int ProductId { get; set; }
        required
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string Supplier { get; set; } = string.Empty;

        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int QuantityOnHand { get; set; }
        public int ReorderLevel { get; set; }
    }

}
