using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemInfo
    {
        public byte[] Picture { get; set; }
        public Bitmap Bitmap
        {
            get
            {
                if (Picture == null) return null;
                Bitmap bitmap;
                using (var ms = new MemoryStream(Picture))
                {
                    bitmap = new Bitmap(ms);
                }
                return bitmap;
            }
        }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string StockLevel { get; set; }
    }
}
