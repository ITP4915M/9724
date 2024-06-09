using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915MProject
{
    public partial class FrmOrderDetail : Form
    {
        private string _orderid;
        public FrmOrderDetail(string orderid)
        {
            InitializeComponent();
            _orderid = orderid;
        }

        private void FrmOrderDetail_Load(object sender, EventArgs e)
        {
            //load the order info
            txtOrderID.Text = _orderid;

            OrderBLL orderBLL = new OrderBLL();
            List<Order> orders = orderBLL.GetSearchOrder(null, _orderid, null);
            Order order = orders[0];
            txtOrderDate.Text = order.OrderDate.ToString();

            //get the dealer info
            DealerBLL dealerBLL = new DealerBLL();
            List<Dealer> dealers = dealerBLL.getSearchDealer(order.DealerID, null);
            Dealer dealer = dealers[0];
            rtbShippingAddress.Text = dealer.DealerAddress;
            txtDealerName.Text = dealer.DealerName;

            //get the item list
            DISetItemBLL dISetItemBLL = new DISetItemBLL();
            List<DISetItem> dISetItems = new List<DISetItem>();
            dgvOrderItem.DataSource =   dISetItemBLL.GetDISetItems(_orderid);
            dgvOrderItem.Columns["OrderID"].Visible = false;
            dgvOrderItem.Columns["Category"].Visible = false;
            dgvOrderItem.Columns["StockLevel"].Visible = false;
        }
    }

}
