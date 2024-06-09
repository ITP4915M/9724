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
    public class GRNDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        public int InsertGRN(GoodReceivenote goodReceivenote)
        {
            string sql = "INSERT INTO VALUES" + "@GRNID, @SupplierID,@Price,@Date";
            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@GRNID", goodReceivenote.GRNID),
                new MySqlParameter("@SupplierID", goodReceivenote.SupplierID),
                new MySqlParameter("@Price", goodReceivenote.Price),
                new MySqlParameter("@Date", goodReceivenote.Date)
                );

            return row;
        }

        public List<GoodReceivenote> GetAllGRNs()
        {
            List<GoodReceivenote> grnList = new List<GoodReceivenote>();
            string sql = "SELECT * FROM GoodReceivenote";
            DataTable dt = msh.ExecuteDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                GoodReceivenote grn = ToModel(row);
                grnList.Add(grn);
            }

            return grnList;
        }

        private GoodReceivenote ToModel(DataRow dr)
        {
            GoodReceivenote grn = new GoodReceivenote();
            grn.GRNID = dr["GRNID"].ToString();
            grn.SupplierID = dr["SupplierID"].ToString();
            grn.Price = Convert.ToDouble(dr["Price"]);
            grn.Date = Convert.ToDateTime(dr["Date"]);
            return grn;
        }

        public int DeleteGRN(string grnID)
        {
            string sql = "DELETE FROM GoodReceivenote WHERE GRNID = @GRNID";
            int row = msh.ExecuteNonQuery(sql, new MySqlParameter("@GRNID", grnID));
            return row;
        }

        public int UpdateGRN(GoodReceivenote grn)
        {
            string sql = "UPDATE GoodReceivenote " +
                         "SET SupplierID = @SupplierID, " +
                             "Price = @Price, " +
                             "Date = @Date " +
                         "WHERE GRNID = @GRNID";

            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@SupplierID", grn.SupplierID),
                new MySqlParameter("@Price", grn.Price),
                new MySqlParameter("@Date", grn.Date),
                new MySqlParameter("@GRNID", grn.GRNID)
            );

            return row;
        }
        public GoodReceivenote GetGRNByID(string grnID)
        {
            GoodReceivenote grn = null;
            string sql = "SELECT * FROM GoodReceivenote WHERE GRNID = @GRNID";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@GRNID", grnID));

            if (dt.Rows.Count > 0)
            {
                grn = ToModel(dt.Rows[0]);
            }

            return grn;
        }
    }
}
