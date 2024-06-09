using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GoodReceivenote
    {
        public string GRNID { get; set; }
        public string SupplierID { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}
