using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Data
{
    public class Category
    {
        public int CategoryId { get; set; }

        required
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }

}
