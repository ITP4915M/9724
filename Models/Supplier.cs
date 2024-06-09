using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Supplier
    {
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public long PhoneNo { get; set; }
        public string Website { get; set; }
        public string Payment { get; set; }
        public string Email { get; set; }
    }
}
