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
        List<ItemInfo> currentItems = new List<ItemInfo>();
        DelBindSelectedItem delitemSelected;

        public FrmCreateOrder()
        {
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
            amountColumn.ValueType = typeof(int);
            dgvOrderItem.Columns.Add(amountColumn);
            dgvOrderItem.Columns["Amount"].ReadOnly = false;


        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dgvOrderItem == null)
            {
                MessageBox.Show("Please Selcect an Item", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OrderBLL orderBLL = new OrderBLL();
                Order newDraftOrder = new Order();
                newDraftOrder.OrderDate = DateTime.Now;
                newDraftOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newDraftOrder.Status = "Pending";

                DialogResult result = MessageBox.Show("Are you sure to save and create an order?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    int isAdd = orderBLL.addOrder(newDraftOrder);
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

        private void btn_SaveToDraft_Click(object sender, EventArgs e)
        {

            if (cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OrderBLL orderBLL = new OrderBLL();
                Order newDraftOrder = new Order();
                newDraftOrder.OrderDate = DateTime.Now;
                newDraftOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newDraftOrder.Status = "Draft";
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
