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
    public partial class FrmItemList : Form
    {
        ItemInfoBLL itemInfoBll = new ItemInfoBLL();
        public FrmItemList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();

        }

        private void BindDgv()
        {
            string itemID = txtItemID.Text;
            string itemName = txtItemName.Text;
            string catagory = cbxCatagory.SelectedItem.ToString();
            if (catagory == "--Select Catagory--")
            {
                catagory = null;
            }
            dgvItemInfo.DataSource = itemInfoBll.GetSearchItem(itemID, itemName, catagory);
        }

        private void FrmItemList_Load(object sender, EventArgs e)
        {
            BindCbx();
            dgvItemInfo.DataSource = itemInfoBll.GetItems();

            DataGridViewButtonColumn btnSetStockLevel = new DataGridViewButtonColumn();
            btnSetStockLevel.HeaderText = "Set Stock Level";
            btnSetStockLevel.Text = "Edit";
            btnSetStockLevel.Name = "SetStockLevel";
            btnSetStockLevel.UseColumnTextForButtonValue = true; 

            dgvItemInfo.Columns.Add(btnSetStockLevel); 
            dgvItemInfo.CellContentClick += new DataGridViewCellEventHandler(dgvItemList_CellContentClick);

        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // make sure enter the button
            if (dgvItemInfo.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // get the itemid
                string itemId = dgvItemInfo.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(); 

                //opent stock level and send the itemid 
                FrmStockLevel frmSetStockLevel = new FrmStockLevel(itemId);
                frmSetStockLevel.ShowDialog();


            }
        }

        private void BindCbx()
        {
            string[] categories = new string[] { "--Select Catagory--", "A - Sheet Metal", "B - Major Assemblies", "C - Light Components", "D - Accessories" };
            cbxCatagory.Items.Clear();
            foreach (string category in categories)
            {
                cbxCatagory.Items.Add(category);
            }
            cbxCatagory.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemName.Clear();
            cbxCatagory.SelectedIndex = 0;
            dgvItemInfo.DataSource = itemInfoBll.GetItems();
        }
    }
}
