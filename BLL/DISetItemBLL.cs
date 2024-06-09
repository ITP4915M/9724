using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    
    public class DISetItemBLL
    {
        DISetItemDAL dISetItemDAL = new DISetItemDAL();
        public List<DISetItem> GetDISetItems(string orderid) {
            return dISetItemDAL.SelectAllDISetItems(orderid);



        }
    }
}
