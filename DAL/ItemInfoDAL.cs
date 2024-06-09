using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ItemInfoDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        /// <summary>
        /// add item
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <returns></returns>
        public int InsertItem(ItemInfo itemInfo) {
            string sql = "INSERT INTO VALUES iteminfo (@Picture,@ItemID,@ItemName,@Quantity,@Category,@Weight,@Description,@Price,@StockLevel)";
            int row = msh.ExecuteNonQuery(sql,
               new MySqlParameter("@Picture", itemInfo.Picture),
               new MySqlParameter("@ItemID", itemInfo.ItemID),
               new MySqlParameter("@ItemName", itemInfo.ItemName),
               new MySqlParameter("@Quantity", itemInfo.Quantity),
               new MySqlParameter("@Category", itemInfo.Category),
               new MySqlParameter("@Weight", itemInfo.Weight),
               new MySqlParameter("@Description", itemInfo.Description),
               new MySqlParameter("@Price", itemInfo.Price),
               new MySqlParameter("@StockLevel", itemInfo.StockLevel)
               );
            return row;

            
        }

        /// <summary>
        /// delete all item
        /// </summary>
        public void DeleteAllItem()
        {
            msh.ExecuteNonQuery(@"DELETE FROM iteminfo");
        }

        /// <summary>
        /// delete item by id
        /// </summary>
        /// <param name="ItemID"></param>
        public void DeleteItemByID(string ItemID)
        {
            msh.ExecuteNonQuery(@"DELETE FROM order WHERE ItemID = @ItemID", new MySqlParameter("@ItemID", ItemID));
        }

        /// <summary>
        /// update item info
        /// </summary>
        /// <param name="itemInfo"></param>
        public void UpdateItem(ItemInfo  itemInfo)
        {
            string sql = "UPDATE order SET  " +
    "Picture = @Picture, ItemID=@ItemID,ItemName = @ItemName,Quantity=@Quantity," +
    "Category=@Category,Weight=@Weight,Descrption=@Descrption, Price=@Price,StockLevel=@StockLevel WHERE ItemID = @ItemID";
            int row = msh.ExecuteNonQuery(sql,
               new MySqlParameter("@Picture", itemInfo.Picture),
               new MySqlParameter("@ItemID", itemInfo.ItemID),
               new MySqlParameter("@ItemName", itemInfo.ItemName),
               new MySqlParameter("@Quantity", itemInfo.Quantity),
               new MySqlParameter("@Category", itemInfo.Category),
               new MySqlParameter("@Weight", itemInfo.Weight),
               new MySqlParameter("@Description", itemInfo.Description),
               new MySqlParameter("@Price", itemInfo.Price),
               new MySqlParameter("@StockLevel", itemInfo.StockLevel)
               );
        }
        /// <summary>
        /// select all items
        /// </summary>
        /// <returns></returns>
        public List<ItemInfo> SelectItems()
        {
            List<ItemInfo> items = new List<ItemInfo>();
            string sql = "SELECT *  FROM `iteminfo`";
            DataTable dt = msh.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                items.Add(dr.DataRowToModel<ItemInfo>());
            }
            return items;

        }


        /// <summary>
        /// search item
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="ItemName"></param>
        /// <param name="Category"></param>
        /// <returns></returns>
        public List<ItemInfo> SearchItem(string ItemID=null, string ItemName=null, string Category = null) {
            List<ItemInfo> items= new List<ItemInfo>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            string sql = "SELECT * FROM `iteminfo` " +
             "WHERE 1=1";

            if (!string.IsNullOrEmpty(ItemID))
            {
                sql += " AND ItemID = @ItemID";
                parameters.Add(new MySqlParameter("@ItemID", ItemID));
            }
            if (!string.IsNullOrEmpty(ItemName))
            {
                sql += " AND ItemName = @ItemName";
                parameters.Add(new MySqlParameter("@ItemName", ItemName));
            }
            if (!string.IsNullOrEmpty(Category))
            {
                sql += " AND Category = @Category";
                parameters.Add(new MySqlParameter("@Category", Category));
            }
            DataTable dt = msh.ExecuteDataTable(sql, parameters.ToArray());

            foreach (DataRow dr in dt.Rows)
            {
                items.Add(dr.DataRowToModel<ItemInfo>());
            }
            return items;
        }


    }
}
