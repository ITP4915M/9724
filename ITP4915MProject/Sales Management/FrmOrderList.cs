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
    public partial class FrmOrderList : Form
    {
        OrderBLL orderBll = new OrderBLL();
        StaffBLL staffBll = new StaffBLL();
        public FrmOrderList()
        {

            InitializeComponent();
        }
        private void dgvOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvOrderList.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string statusValue = e.Value.ToString();
                    switch (statusValue)
                    {
                        case "Draft":
                            e.CellStyle.ForeColor = Color.Orange;
                            break;
                        case "Cancelled":
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                        case "Pending":
                            e.CellStyle.ForeColor = Color.Yellow;
                            break;
                        case "Processing":
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case "Delivered":
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Shipped":
                            e.CellStyle.ForeColor = Color.Green;
                            break;
                        default:
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {


            dgvOrderList.DataSource = orderBll.getAllOrders();
            dgvOrderList.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvOrderList_CellFormatting);
            dgvOrderList.Columns["DealerID"].Visible = false;
            dgvOrderList.Columns["TotalItem"].Visible = false;
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "btnColumnDetails";
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "View Detail";
            btnColumn.UseColumnTextForButtonValue = true;

            // add the buttton to the datagrid view
            dgvOrderList.Columns.Add(btnColumn);



            //binding combo box status
            string[] status = new string[] { "--Select Order Status--", "Pending", "Processing", "Shipped", "Delivered", "Cancelled", "Draft" };
            cbxStatus.Items.Clear();
            foreach (string st in status)
            {
                cbxStatus.Items.Add(st);
            }
            cbxStatus.SelectedIndex = 0;




            /*          //Bingd Combo box staffID
                      List<Order> orders = orderBll.getAllOrders();
                      orders.Insert(0, new Order { OrderID = "--Select Operator--" , StaffID = "--Select Operator--"} );
                      cbxStaffID.DataSource = orders;
                      cbxStaffID.DisplayMember = "StaffID";
                      cbxStaffID.ValueMember = "StaffID";*/


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();


        }
        private void BindDgv()
        {

            string orderNumber = txtOrderNumber.Text;
            string status = null;
            if (cbxStatus.SelectedItem.ToString() != "--Select Order Status--")
            {
                status = cbxStatus.SelectedItem.ToString();
            }


            DateTime? selectedDate = null;
            if (dtpOrderDate.Checked)
            {
                selectedDate = dtpOrderDate.Value.Date;
            }

            dgvOrderList.DataSource = orderBll.GetSearchOrder(selectedDate, orderNumber, status);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Clear();
            cbxStatus.SelectedIndex = 0;
            dgvOrderList.DataSource = orderBll.getAllOrders();
        }




    }
}
