using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{

    public class DealerOrderBLL
    {
        DealerOrderDAL dealerOrderDAL = new DealerOrderDAL();
        public List<DealerOrder> getAllDealerOrders() {
            return dealerOrderDAL.SelectAlldealerOrders();
        }
    }
}
