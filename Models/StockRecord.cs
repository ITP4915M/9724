using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StockRecord
    {
        public int StockRecordID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public string RecordType { get; set; }
        public int CurrentStock { get; set; }
        public int DangerLevelStock { get; set; }
        public int ReorderStock { get; set; }
        public DateTime RecordTime { get; set; }



    }
}
