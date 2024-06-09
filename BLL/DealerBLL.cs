using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class DealerBLL
    {
        DealerDAL dealerDAL = new DealerDAL();
        public List<Dealer> getAllDealer() {
            
            return dealerDAL.SelecteAllDealer();
        
        }

        public List<Dealer> getSearchDealer(string DealerID,string DealerName) {
            return dealerDAL.SearchDealer(DealerID, DealerName);
        }
    }
}
