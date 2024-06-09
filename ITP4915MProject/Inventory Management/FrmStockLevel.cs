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
    public partial class FrmStockLevel : Form
    {
        private string _itemid;
        public FrmStockLevel(string itemid)
        {
            InitializeComponent();
            _itemid = itemid;
        }

        private void FrmStockLevel_Load(object sender, EventArgs e)
        {
            txtItemID.Text = _itemid;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StockLevelBLL stockLevelBLL = new StockLevelBLL();
            StockLevel stockLevel = new StockLevel();
            stockLevel.Danger =  Convert.ToInt32(nudDangerLevel.Value);
            stockLevel.Safe =  Convert.ToInt32(nudSafeLevel.Value);
            stockLevel.Low =  Convert.ToInt32(nudLowLevel.Value);
            stockLevel.Overflow = Convert.ToInt32(nudOverflowLevel.Value);
            stockLevel.ItemID = _itemid;
    
             int isadd = stockLevelBLL.InsertStockLevel(stockLevel);
            if (isadd > 0)
            {
                MessageBox.Show("Set Stock Level Success");
            }
            else {
                MessageBox.Show("Set Stock Level Fail");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
