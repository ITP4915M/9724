using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class StockLevelBLL
    {
        StockLevelDAL stockLevelDAL = new StockLevelDAL();
        public int InsertStockLevel(StockLevel stockLevel) {
            return stockLevelDAL.InsertStockLevel(stockLevel);
        
        }
    }
}
