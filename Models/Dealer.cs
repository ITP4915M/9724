using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dealer
    {
        public string DealerID { get; set; }
        public string DealerName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string  DealerAddress { get; set; }
        public string PhoneNo { get; set; }  
        public string Email { get; set; }
        public string HandlerName { get; set; }
        public string HandlerPosition { get; set; }
        public string HandlerPhoneNo { get; set; }
    }
}
