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
    public class DISetDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());


        /// <summary>
        /// add diset 
        /// </summary>
        /// <param name="diset"></param>
        /// <returns></returns>
        public int InsertDISet(DISet diset) {
            string sql = "INSERT INTO VALUES diset (@OrderID,@ItemID,@Quantity,@Remark)";
            int row = msh.ExecuteNonQuery(sql,
               new MySqlParameter("@OrderID", diset.OrderID),
               new MySqlParameter("@ItemID", diset.ItemID),
               new MySqlParameter("@Quantity", diset.Quantity),
               new MySqlParameter("@Remark", diset.Remark));
            return row;
        }

        /// <summary>
        /// delete all diset
        /// </summary>
        public void DeleteAllDISet()
        {
            msh.ExecuteNonQuery(@"DELETE FROM diset");
        }

        /// <summary>
        /// delete diset by id
        /// </summary>
        /// <param name="ItemID"></param>
        public void DeleteDISetByID(string ItemID)
        {
            msh.ExecuteNonQuery(@"DELETE FROM diset WHERE ItemID = @ItemID", new MySqlParameter("@ItemID", ItemID));
        }

        public List<DISet> SelectDIset(string orderID)
        {
            List<DISet> disets = new List<DISet>();
            string sql = "SELECT *  FROM `diset` WHERE OrderID = @OrderID";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@OrderID", orderID));
            foreach (DataRow dr in dt.Rows)
            {
                disets.Add(dr.DataRowToModel<DISet>());
            }
            return disets;

        }
    }
}
