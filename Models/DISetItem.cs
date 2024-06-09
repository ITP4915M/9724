using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class DISetItem
    {
        public string OrderID { get; set; }
        public int Quantity { get; set; }
        public string Remark { get; set; }
        public byte[] Picture { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StockLevel { get; set; }


    }
}
