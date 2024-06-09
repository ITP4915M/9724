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
    public class OrderDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());
        IDSelfIncreasementHelper idIncrease = new IDSelfIncreasementHelper();

        /// <summary>
        /// add order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int InsertOrder(Order order) {
            string OrderID = GetNextCharId();
            string sql = "INSERT INTO `order` (OrderID, DealerID, Status, OrderDate) VALUES (@OrderID, @DealerID, @Status, @OrderDate)";
            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@OrderID", OrderID),
                new MySqlParameter("@DealerID", order.DealerID),
                new MySqlParameter("@Status", order.Status),
                new MySqlParameter("@OrderDate", order.OrderDate)
                );

                return row;
        }

        private string GetNextCharId()
        {
            string lastId = idIncrease.QueryDatabaseForLastCharId();
            long numericPart = long.Parse(lastId); 
            numericPart++;
            string newId = numericPart.ToString(); 
            return newId;
        }

        /// <summary>
        /// delete all order
        /// </summary>
        public void DeleteOrder() {
            msh.ExecuteNonQuery(@"DELETE FROM order");
        }

        /// <summary>
        /// Delete order by orderID
        /// </summary>
        /// <param name="OrderID"></param>
        public void DeleteOrderByID(string OrderID)
        {
            msh.ExecuteNonQuery(@"DELETE FROM order WHERE OrderID = @OrderID", new MySqlParameter("@OrderID", OrderID));
        }


        /// <summary>
        /// Update order info by order id
        /// </summary>
        /// <param name="order"></param>
        public void UpdateOrder(Order order) {
            string sql = "UPDATE order SET  " +
                "DealerID = @DealerID,PaymentName=@PaymentName," +
                "StaffID=@StaffID,Status=@Status,Descrption=@Descrption, OrderDate=@OrderDate,OrderAmounts=@OrderAmounts, TotalItem = @TotalItem WHERE OrderID = @OrderID";
            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@OrderID", order.OrderID),
                new MySqlParameter("@DealerID", order.DealerID),
                new MySqlParameter("@PaymentName", order.PaymentName),
                new MySqlParameter("@StaffID", order.StaffID),
                new MySqlParameter("@Status", order.Status),
                new MySqlParameter("@Descrption", order.Descrption),
                new MySqlParameter("@OrderDate", order.OrderDate),
                new MySqlParameter("@OrderAmounts", order.OrderAmounts),
                new MySqlParameter("@TotalItem", order.TotalItem)
                );

        }

        /// <summary>
        /// view all orders with no condition 
        /// </summary>
        /// <returns></returns>
        public List<Order> SelectAllOrders()
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT *  FROM `order`";
            DataTable dt = msh.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                orders.Add(dr.DataRowToModel<Order>());
            }
            return orders;

        }

        /// <summary>
        /// select order with condition
        /// </summary>
        /// <returns></returns>
        public List<Order> SelectOrder(DateTime? orderDate=null, string orderID = null, string status = null)
        {
            List<Order> orders = new List<Order>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            string sql = "SELECT * FROM `order` " +
             "WHERE 1=1";

            if (!string.IsNullOrEmpty(orderID))
            {
                sql += " AND OrderID = @OrderID";
                parameters.Add(new MySqlParameter("@OrderID", orderID));
            }
            if (orderDate.HasValue)
            {
                sql += " AND OrderDate = @OrderDate";
                parameters.Add(new MySqlParameter("@OrderDate", orderDate));
            }
    /*        if (!string.IsNullOrEmpty(staffID))
            {
                sql += " AND StaffID = @StaffID";
                parameters.Add(new MySqlParameter("@StaffID", staffID));
            }*/
            if (!string.IsNullOrEmpty(status))
            {
                sql += " AND Status = @Status";
                parameters.Add(new MySqlParameter("@Status", status));
            }

            DataTable dt = msh.ExecuteDataTable(sql, parameters.ToArray());

            foreach (DataRow dr in dt.Rows)
            {
                orders.Add(dr.DataRowToModel<Order>());
            }
            return orders;

        }

    }
}
