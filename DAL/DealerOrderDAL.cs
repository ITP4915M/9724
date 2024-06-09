using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DealerOrderDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        public List<DealerOrder> SelectAlldealerOrders() {
            string sql = "SELECT OrderID,DealerName,OrderDate,Status,TotalItem" +
                 " FROM `order`,dealer WHERE order.DealerID=dealer.DealerID AND Status = 'Pending'";
            List<DealerOrder> dealerOrders = new List<DealerOrder>();
            DataTable dt = msh.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                dealerOrders.Add(dr.DataRowToModel<DealerOrder>());
            }
            return dealerOrders;
        }
    }
}
