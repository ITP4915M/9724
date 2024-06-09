using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;
using Common;

namespace DAL
{
    public class GRNItemDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        public int InsertGRNitem(GRNItem grnitem)
        {
            int row = msh.ExecuteNonQuery(
                "INSERT INTO GRNItem VALUES(@GRNID,@itemID,@quantity)",
                new MySqlParameter("@GRNID", grnitem.GRNID),
                new MySqlParameter("@itemID", grnitem.ItemID),
                new MySqlParameter("@quantity", grnitem.quantity)
                );
            return row;
        }

        //get grnitem list by GRNID
        public List<GRNItem> GetGRNItemsByGRNID(string grnID)
        {
            List<GRNItem> grnItems = new List<GRNItem>();
            string sql = "SELECT * FROM GRNItem WHERE GRNID = @GRNID";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@GRNID", grnID));

            foreach (DataRow row in dt.Rows)
            {
                GRNItem grnItem = ToModel(row);
                grnItems.Add(grnItem);
            }

            return grnItems;
        }

        private GRNItem ToModel(DataRow dr)
        {
            GRNItem grnItem = new GRNItem();
            grnItem.GRNID = dr["GRNID"].ToString();
            grnItem.ItemID = dr["ItemID"].ToString();
            grnItem.quantity = dr["quantity"].ToString();
            return grnItem;
        }


        //remove GRNitem by selected item
        public int DeleteGRNItem(string grnID, string itemID)
        {
            string sql = "DELETE FROM GRNItem WHERE GRNID = @GRNID AND ItemID = @ItemID";
            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@GRNID", grnID),
                new MySqlParameter("@ItemID", itemID)
            );
            return row;
        }

        public int DeleteGRNItemsByGRNID(string grnID)
        {
            string sql = "DELETE FROM GRNItem WHERE GRNID = @GRNID";
            int row = msh.ExecuteNonQuery(sql, new MySqlParameter("@GRNID", grnID));
            return row;
        }

        public int UpdateGRNItem(GRNItem grnItem)
        {
            string sql = "UPDATE GRNItem " +
                         "SET quantity = @quantity " +
                         "WHERE GRNID = @GRNID AND ItemID = @ItemID";

            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@quantity", grnItem.quantity),
                new MySqlParameter("@GRNID", grnItem.GRNID),
                new MySqlParameter("@ItemID", grnItem.ItemID)
            );

            return row;
        }

    }
}
