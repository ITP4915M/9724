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
    public class DealerDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());


        /// <summary>
        /// add dealer
        /// </summary>
        /// <param name="dealer"></param>
        /// <returns></returns>
        public int InsertDealer(Dealer  dealer)
        {
            string sql = "INSERT INTO VALUES dealer @DealerID,@DealerName,@RegisterDate,@DealerAddress,@PhoneNo,@Email,@HandlerName,@HandlerPosition,@HandlerPhoneNo";
            int row = msh.ExecuteNonQuery(sql,

               new MySqlParameter("@DealerID", dealer.DealerID),
               new MySqlParameter("@DealerName", dealer.DealerName),
               new MySqlParameter("@RegisterDate", dealer.RegisterDate),
               new MySqlParameter("@DealerAddress", dealer.DealerAddress),
               new MySqlParameter("@PhoneNo", dealer.PhoneNo),
               new MySqlParameter("@Email", dealer.Email),
               new MySqlParameter("@HandlerName", dealer.HandlerName),
               new MySqlParameter("@HandlerPosition", dealer.HandlerPosition),
               new MySqlParameter("@HandlerPhoneNo", dealer.HandlerPhoneNo)
               );
            return row;


        }

        /// <summary>
        /// delete all dealer
        /// </summary>
        public void DeleteAllDealer()
        {
            msh.ExecuteNonQuery(@"DELETE FROM dealer");
        }


        /// <summary>
        /// delete dealer by id
        /// </summary>
        /// <param name="DealerID"></param>
        public void DeleteDealerByID(string DealerID)
        {
            msh.ExecuteNonQuery(@"DELETE FROM dealer WHERE DealerID = @DealerID", new MySqlParameter("@DealerID", DealerID));
        }


        /// <summary>
        /// update dealer information
        /// </summary>
        /// <param name="dealer"></param>
        public void UpdateDealer(Dealer dealer)
        {
            string sql = "UPDATE dealer SET  " +
                "DealerID=@DealerID,DealerName = @DealerName,RegisterDate=@RegisterDate," +
                "DealerAddress=@DealerAddress,PhoneNo=@PhoneNo,Email=@Email, HandlerName=@HandlerName,HandlerPosition=@HandlerPosition,HandlerPhoneNo=@HandlerPhoneNo WHERE DealerID = @DealerID";
            int row = msh.ExecuteNonQuery(sql,

                new MySqlParameter("@DealerID", dealer.DealerID),
               new MySqlParameter("@DealerName", dealer.DealerName),
               new MySqlParameter("@RegisterDate", dealer.RegisterDate),
               new MySqlParameter("@DealerAddress", dealer.DealerAddress),
               new MySqlParameter("@PhoneNo", dealer.PhoneNo),
               new MySqlParameter("@Email", dealer.Email),
               new MySqlParameter("@HandlerName", dealer.HandlerName),
               new MySqlParameter("@HandlerPosition", dealer.HandlerPosition),
               new MySqlParameter("@HandlerPhoneNo", dealer.HandlerPhoneNo)
               );
        }


        /// <summary>
        /// select all dealler information
        /// </summary>
        /// <returns></returns>
        public List<Dealer> SelecteAllDealer()
        {
            List<Dealer> dealers = new List<Dealer>();
            string sql = "SELECT *  FROM `dealer`";
            DataTable dt = msh.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                dealers.Add(dr.DataRowToModel<Dealer>());
            }
            return dealers;

        }


        /// <summary>
        /// search dealer
        /// </summary>
        /// <param name="DealerID"></param>
        /// <param name="DealerName"></param>
        /// <returns></returns>
        public List<Dealer> SearchDealer(string DealerID = null, string DealerName = null)
        {
            List<Dealer> dealers = new List<Dealer>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            string sql = "SELECT * FROM `dealer` " +
             "WHERE 1=1";

            if (!string.IsNullOrEmpty(DealerID))
            {
                sql += " AND DealerID = @DealerID";
                parameters.Add(new MySqlParameter("@DealerID", DealerID));
            }
            if (!string.IsNullOrEmpty(DealerName))
            {
                sql += " AND DealerName = @DealerName";
                parameters.Add(new MySqlParameter("@DealerName", DealerName));
            }
          
            DataTable dt = msh.ExecuteDataTable(sql, parameters.ToArray());

            foreach (DataRow dr in dt.Rows)
            {
                dealers.Add(dr.DataRowToModel<Dealer>());
            }
            return dealers;
        }

    }
}
