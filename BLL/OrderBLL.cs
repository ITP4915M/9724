using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;


namespace BLL
{
    
    public class OrderBLL
    {
        OrderDAL orderDal = new OrderDAL();
        public List<Order> getAllOrders() {
            return orderDal.SelectAllOrders();
        }

        public List<Order> GetSearchOrder(DateTime? orderDate,string orderID, string status) {
 
            return orderDal.SelectOrder(orderDate, orderID,status);
        
        }

        public int addOrder(Order order) {
            return orderDal.InsertOrder(order);
        }
    }
}
