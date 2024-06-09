using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
   
    public  class ItemInfoBLL
    {
        ItemInfoDAL itemInfoDal = new ItemInfoDAL();
        public List<ItemInfo> GetItems() {
            return itemInfoDal.SelectItems();
        }

        public List<ItemInfo> GetSearchItem(string itemID,string itemName,string catagory) {
            return itemInfoDal.SearchItem(itemID, itemName, catagory);
        
        }



    }

   
}
