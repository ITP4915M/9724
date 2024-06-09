using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public  class StockLevel
    {

        public int Low { get; set; }
        public int Safe { get; set; }
        public int Danger { get; set; }
        public int Overflow { get; set; }
        public string ItemID { get; set; }

    }
}
