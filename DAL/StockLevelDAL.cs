using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class StockLevelDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());


        public int InsertStockLevel(StockLevel stocklevel)
        {

            int row = msh.ExecuteNonQuery("INSERT INTO stocklevel VALUES (@Low,@Safe,@Danger,@Overflow,@ItemID) ",
            new MySqlParameter("@Low", stocklevel.Low),
            new MySqlParameter("@Safe", stocklevel.Safe),
            new MySqlParameter("@Danger", stocklevel.Danger),
            new MySqlParameter("@Overflow", stocklevel.Overflow),
            new MySqlParameter("@ItemID", stocklevel.ItemID)
            );
            return row;


        }
    }
}
