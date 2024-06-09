using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string DealerID { get; set; }
        public string PaymentName { get; set; }
        public string StaffID { get; set; }
        public string Status { get; set; }
        public string Descrption { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderAmounts { get; set; }
        public int TotalItem { get; set; }



    }
}
