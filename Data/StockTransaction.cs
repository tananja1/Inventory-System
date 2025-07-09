using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Data
{
    public class StockTransaction
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string Type { get; set; } = ""; // "Purchase" or "Sale"
        public int Quantity { get; set; }

        public decimal PricePerUnit { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        

    }

}
