using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemInfo
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StockLevel { get; set; }
        public string Picture { get; set; } //path of the picture
    }
}
