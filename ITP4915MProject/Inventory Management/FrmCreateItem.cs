using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915MProject.Inventory_Management
{
    public partial class FrmCreateItem : Form
    {
        public FrmCreateItem()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picItemPicture.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured. Photo upload failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        private void btnCreateButton_Click(object sender, EventArgs e)
        {

        }
        */
        private void btnCreateitem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            int quantity = int.Parse(txtQuantity.Text);
            string category = cbxItemCategory.Text;
            decimal weight = decimal.Parse(txtItemWeight.Text);
            string description = TxtItemDescrption.Text;
            decimal price = decimal.Parse(txtItemPrice.Text);
            string stockLevel = "not yet setting";
            string picturePath = txtPicturePath.Text;
            string itemID = category + ;
        }
    }
}
