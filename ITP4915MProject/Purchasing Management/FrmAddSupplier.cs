using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace ITP4915MProject.Account_Management
{
    public partial class FrmAddSupplier : Form
    {
        public FrmAddSupplier()
        {
            InitializeComponent();
        }

        private void btnSupplierList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            /*
            // 創建一個新的 Supplier 對象
            Supplier newSupplier = new Supplier
            {
                SupplierID = txtSupplierID.Text,
                SupplierName = txtSupplierName.Text,
                SupplierAddress = txtSupplierAddress.Text,
                PhoneNo = long.Parse(txtPhoneNo.Text),
                Website = txtWebsite.Text,
                Payment = txtPayment.Text,
                Email = txtEmail.Text
            };

            // 調用 InsertSupplier 方法插入新供應商
            int rowsAffected = SupplierDAL.InsertSupplier(newSupplier);

            if (rowsAffected > 0)
            {
                // 顯示成功信息
                MessageBox.Show("Supplier added successfully.");

                // 清空表單
                this.Close();

                // 刷新頁面或執行其他相關操作
            }
            else
            {
                // 顯示錯誤信息
                MessageBox.Show("Failed to add supplier.");
            }
            */
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
