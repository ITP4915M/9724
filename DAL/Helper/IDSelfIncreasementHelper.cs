using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class IDSelfIncreasementHelper
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());
        public string QueryDatabaseForLastCharId()
        {
            string lastCharId = "";
            string sql = "SELECT OrderID FROM `order` ORDER BY OrderID DESC LIMIT 1";
            try
            {
                object result = msh.ExecuteScalar(sql);
                if (result != null)
                {
                    lastCharId = result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lastCharId;




        }       

    }
}
