using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StockRecordBLL
    {
        StockRecordDAL StockRecordDAL = new StockRecordDAL();
        public List<StockRecord> GetStockRecords() {

            return StockRecordDAL.SelectAllStockRecords();
        
        }

        public List<StockRecord> GetStockRecordsByType(string recordtype,DateTime? RecordTime)
        {

            return StockRecordDAL.SelectStockRecordByType(recordtype, RecordTime);

        }
    }
}
