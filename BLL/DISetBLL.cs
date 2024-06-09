using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DISetBLL
    {
        DISetDAL dISetDAL = new DISetDAL();
        public List<DISet> GetDISets(string orderid) {
            return dISetDAL.SelectDIset(orderid);
        }
    }
}
