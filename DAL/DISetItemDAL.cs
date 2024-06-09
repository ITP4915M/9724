using Common;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DISetItemDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        public List<DISetItem> SelectAllDISetItems(string orderid)
        {
            List<DISetItem> dISetItems = new List<DISetItem>();
            string sql = "SELECT Image,diset.ItemID,ItemName,diset.Quantity,Remark,Price " +
                "FROM diset, iteminfo WHERE diset.ItemID = iteminfo.ItemID AND diset.OrderID = @OrderID";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@OrderID", orderid));
            foreach (DataRow dr in dt.Rows)
            {
                dISetItems.Add(dr.DataRowToModel<DISetItem>());
            }
            return dISetItems;

        }
    }
}
