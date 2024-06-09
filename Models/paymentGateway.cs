using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class paymentGateway
    {
        public string PaymentName { get; set; }
        public string DealerID { get; set; }
        public string CardNo { get; set; }
        public int BankCode { get; set; }
        public string VertNo { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
