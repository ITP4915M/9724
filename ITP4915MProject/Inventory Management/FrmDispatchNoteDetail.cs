using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace ITP4915MProject
{

    public partial class FrmDispatchNoteDetail : Form
           
    {
        private string _orderid;
        
       
        public FrmDispatchNoteDetail(string orderid)
        {
            InitializeComponent();

            _orderid = orderid;
        }

        private void FrmDispatchNoteDetail_Load(object sender, EventArgs e)
        {
            //load the order info
            txtOrderID.Text = _orderid;

            OrderBLL orderBLL = new OrderBLL();
           List<Order> orders =  orderBLL.GetSearchOrder(null,_orderid,null);
            Order order = orders[0];
            txtOrderDate.Text = order.OrderDate.ToString();

            //get the dealer info
            DealerBLL dealerBLL = new DealerBLL();
            List<Dealer> dealers = dealerBLL.getSearchDealer(order.DealerID, null);
            Dealer dealer = dealers[0];
            rtbShippingAddress.Text = dealer.DealerAddress;
            txtDealerName.Text = dealer.DealerName;

            //load the diset info
            DISetBLL dISetBLL = new DISetBLL();
            List<DISet> disets = dISetBLL.GetDISets(_orderid);
            dgvOrderItem.DataSource = disets;
        }

        private void grpOrderInfo_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
