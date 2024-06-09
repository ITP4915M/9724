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
    public partial class FrmOrderAddItem : Form
    {
        private DelBindSelectedItem _delBindSelectedItem;
        private List<ItemInfo> _currentItems;
        ItemInfoBLL itemInfoBll = new ItemInfoBLL();


        public FrmOrderAddItem(DelBindSelectedItem delBindSelectedItem, List<ItemInfo> currentItems)
        {
            InitializeComponent();
            _delBindSelectedItem = delBindSelectedItem;
            _currentItems = currentItems;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemName.Clear();
            cbxCatagory.SelectedIndex = 0;
            dgvItemInfo.DataSource = itemInfoBll.GetItems();

        }

        private void FrmOrderAddItem_Load(object sender, EventArgs e)
        {
            dgvItemInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BindCbx();
            dgvItemInfo.DataSource = itemInfoBll.GetItems();
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select item";
            checkBoxColumn.Width = 50;
            checkBoxColumn.Name = "checkBoxColumn";
            dgvItemInfo.Columns.Insert(0, checkBoxColumn);

            foreach (DataGridViewRow row in dgvItemInfo.Rows)
            {
                ItemInfo item = row.DataBoundItem as ItemInfo;
                if (item != null && _currentItems.Any(si => si.ItemID == item.ItemID))
                {
                    DataGridViewCheckBoxCell checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;
                    checkBoxCell.Value = true;
                }
            }
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<ItemInfo> selectedItems = new List<ItemInfo>();

            foreach (DataGridViewRow row in dgvItemInfo.Rows)
            {
                if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value) == true)
                {

                    ItemInfo item = row.DataBoundItem as ItemInfo;
                    if (item != null)
                    {
                        selectedItems.Add(item);
                    }
                }
            }
            _delBindSelectedItem(selectedItems);
            MessageBox.Show("Add item successful");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }

}
