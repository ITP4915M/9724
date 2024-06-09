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
    public delegate void DelBindSelectedItem(List<ItemInfo> selectedItems);
    public partial class FrmCreateOrder : Form
    {
        private string staffID;
        List<ItemInfo> currentItems = new List<ItemInfo>();
        DelBindSelectedItem delitemSelected;

        public FrmCreateOrder(string staffID)
        {
            this.staffID = staffID;
            InitializeComponent();
            dgvOrderItem.CellValidating += new DataGridViewCellValidatingEventHandler(dgvOrderItem_CellValidating);
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            FrmOrderAddItem frmOrderAddItem = new FrmOrderAddItem(delitemSelected, currentItems);
            frmOrderAddItem.ShowDialog();

        }

        public void BindSelectedItem(List<ItemInfo> itemInfos)
        {

            currentItems = itemInfos;

            //create a col to let user enter an amount of selected item
            dgvOrderItem.DataSource = itemInfos;
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.ValueType = typeof(int); // set the type to integer
            amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // set content in center
            amountColumn.Width = 60; // set width
            dgvOrderItem.Columns.Add(amountColumn);

            // default value 1
            foreach (DataGridViewRow row in dgvOrderItem.Rows)
            {
                row.Cells["Amount"].Value = 1;
            }
/*            //add the selection box col in the datagrid view
            DataGridViewCheckBoxColumn chkBoxColumn = new DataGridViewCheckBoxColumn();
            chkBoxColumn.HeaderText = "Select";
            chkBoxColumn.Width = 30;
            chkBoxColumn.Name = "chkBoxColumn";
            dgvOrderItem.Columns.Insert(0, chkBoxColumn);*/

        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxDealer.SelectedValue == null || cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dgvOrderItem.Rows.Count == 0)
            {
                MessageBox.Show("Please Selcect an Item", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int totalQuantity = 0;
                decimal totalPrice = 0m;

                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    // get the amount value
                    int quantity = 0;
                    if (row.Cells["Amount"].Value != null)
                    {
                        quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                    }

                    // get the price value
                    decimal price = 0m;
                    if (row.Cells["Price"].Value != null)
                    {
                        price = Convert.ToDecimal(row.Cells["Price"].Value);
                    }

                    //count the total quantity
                    totalQuantity += quantity;
                    totalPrice += quantity * price; // calculate the totalprice
                }
                OrderBLL orderBLL = new OrderBLL();
                Order newPendingOrder = new Order();
                newPendingOrder.OrderDate = DateTime.Now;
                newPendingOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newPendingOrder.Status = "Pending";
                newPendingOrder.StaffID = GlobalVariables.StaffID;
                newPendingOrder.TotalItem = totalQuantity;
                newPendingOrder.OrderAmounts = totalPrice;



                DialogResult result = MessageBox.Show("Are you sure to save and create an order?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    int isAdd = orderBLL.addOrder(newPendingOrder);
                    if (isAdd > 0)
                    {
                        MessageBox.Show("Create Order Successful");
                    }
                    else
                    {
                        MessageBox.Show("Can not create order");
                    }
                    List<DISet> dISets = new List<DISet>();
                    foreach (DataGridViewRow row in dgvOrderItem.Rows)
                    {
                        if (row.IsNewRow) continue;

                        DISet diset = new DISet();
                        diset.ItemID = row.Cells["ItemID"].Value.ToString();
                        diset.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        dISets.Add(diset);
                    }
                }
                else
                {

                    MessageBox.Show(" cancel", "Action cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void FrmCreateOrder_Load(object sender, EventArgs e)
        {
            DealerBLL dealerBLL = new DealerBLL();
            List<Dealer> dealers = dealerBLL.getAllDealer();

            dealers.Insert(0, new Dealer { DealerID = "--Select Dealer--", DealerName = "--Select Dealer--" });
            cbxDealer.DataSource = dealers;
            cbxDealer.DisplayMember = "DealerName";
            cbxDealer.ValueMember = "DealerID";

            dgvOrderItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            delitemSelected = BindSelectedItem;

    




        }
        private void dgvOrderItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (dgvOrderItem.Columns[e.ColumnIndex].Name == "Amount")
            {
                int newQuantity;

                if (!int.TryParse(e.FormattedValue.ToString(), out newQuantity))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter validate amount");
                }
                else
                {

                    int stock = Convert.ToInt32(dgvOrderItem.Rows[e.RowIndex].Cells["Quantity"].Value);
                    if (newQuantity < 0 || newQuantity > stock)
                    {
                        e.Cancel = true;
                        MessageBox.Show($"enter amount must less than inventory quantity {stock}.");
                    }
                }
            }
        }


        private void btn_SaveToDraft_Click_1(object sender, EventArgs e)
        {
            if (cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (dgvOrderItem.Rows.Count == 0) {
                MessageBox.Show("Please Selcect an Item", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int totalQuantity = 0;
                decimal totalPrice = 0m;

                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    // 获取数量列的值
                    int quantity = 0;
                    if (row.Cells["Amount"].Value != null)
                    {
                        quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                    }

                    // 获取价格列的值
                    decimal price = 0m;
                    if (row.Cells["Price"].Value != null)
                    {
                        price = Convert.ToDecimal(row.Cells["Price"].Value);
                    }

                    // 累加总数量和总价格
                    totalQuantity += quantity;
                    totalPrice += quantity * price; // 单个商品的总价是数量乘以单价
                }

                OrderBLL orderBLL = new OrderBLL();
                Order newDraftOrder = new Order();
                newDraftOrder.OrderDate = DateTime.Now;
                newDraftOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newDraftOrder.Status = "Draft";
                newDraftOrder.StaffID = staffID;
                newDraftOrder.TotalItem = totalQuantity;
                newDraftOrder.OrderAmounts = totalPrice;


                int isAdd = orderBLL.addOrder(newDraftOrder);
                if (isAdd > 0)
                {
                    MessageBox.Show("Draft Successful");
                }
                else
                {
                    MessageBox.Show("Can not Save to Draft");
                }

                List<DISet> dISets = new List<DISet>();

                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    if (row.IsNewRow) continue;

                    DISet diset = new DISet();
                    diset.ItemID = row.Cells["ItemID"].Value.ToString();
                    diset.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    dISets.Add(diset);
                }
            }
        }

    }
}
