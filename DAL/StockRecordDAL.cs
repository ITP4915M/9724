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
    public class StockRecordDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        /// <summary>
        /// add stockrecord
        /// </summary>
        /// <param name="stockRecord"></param>
        /// <returns></returns>
        public int InsertStockRecord(StockRecord stockRecord)
        {
            string sql = "INSERT INTO `stockrecord` VALUES (@StockRecordID, @ItemID, @Quantity, @RecordType, @CurrentStock, @DangerLevelStock, @RecordTime,@ReorderStock)";
            int row = msh.ExecuteNonQuery(sql,
                new MySqlParameter("@StockRecordID", stockRecord.StockRecordID),
                new MySqlParameter("@ItemID", stockRecord.ItemID),
                new MySqlParameter("@Quantity", stockRecord.Quantity),
                new MySqlParameter("@RecordType", stockRecord.RecordType),
                new MySqlParameter("@CurrentStock", stockRecord.CurrentStock),
                new MySqlParameter("@DangerLevelStock", stockRecord.DangerLevelStock),
                new MySqlParameter("@ReorderStock", stockRecord.ReorderStock),
                new MySqlParameter("@RecordTime", stockRecord.RecordTime)
                );

            return row;
        }


        /// <summary>
        /// delete all stock record
        /// </summary>
        public void DeleteStockAllRecord()
        {
            msh.ExecuteNonQuery(@"DELETE FROM stockrecord");
        }


        /// <summary>
        /// delete sotck record by id
        /// </summary>
        /// <param name="StockRecordID"></param>
        public void DeleteStockRecordByID(string StockRecordID)
        {
            msh.ExecuteNonQuery(@"DELETE FROM stockrecord WHERE StockRecordID = @StockRecordID", new MySqlParameter("@StockRecordID", StockRecordID));
        }


        /// <summary>
        /// select all stock record
        /// </summary>
        /// <returns></returns>
        public List<StockRecord> SelectAllStockRecords()
        {
            List<StockRecord> stockRecords = new List<StockRecord>();
            string sql = "SELECT *  FROM `stockrecord`";
            DataTable dt = msh.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                stockRecords.Add(dr.DataRowToModel<StockRecord>());
            }
            return stockRecords;

        }


        /// <summary>
        /// select stock record by type
        /// </summary>
        /// <param name="recordType"></param>
        /// <returns></returns>
        public List<StockRecord> SelectStockRecordByType(string RecordType=null, DateTime? RecordTime=null) {
            List<StockRecord> stockRecords = new List<StockRecord>();
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            string sql = "SELECT *  FROM `stockrecord` WHERE 1=1 "; 
                 if (!string.IsNullOrEmpty(RecordType))
            {
                sql += "AND RecordType = @RecordType ";
                parameters.Add(new MySqlParameter("@RecordType", RecordType));
            }
            if (RecordTime.HasValue)
            {
                sql += "AND RecordTime = @RecordTime ";
                parameters.Add(new MySqlParameter("@RecordTime", RecordTime));
            }


            DataTable dt = msh.ExecuteDataTable(sql, parameters.ToArray());
            foreach (DataRow dr in dt.Rows)
            {
                stockRecords.Add(dr.DataRowToModel<StockRecord>());
            }
            return stockRecords;

        }
    }
}
