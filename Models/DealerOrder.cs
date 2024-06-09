using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DealerOrder
    {
        public string OrderID { get; set; }
        public string DealerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int TotalItem { get; set; }

    }
}
