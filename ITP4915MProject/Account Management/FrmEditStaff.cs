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
    public partial class FrmEditStaff : Form
    {
        public FrmEditStaff()
        {
            InitializeComponent();
        }

        private void btnConfirmModify_Click(object sender, EventArgs e)
        {
            /*
            // 獲取修改後的 Staff 對象
            Staff modifiedStaff = new Staff
            {
                StaffID = txtStaffID.Text,
                StaffName = txtStaffName.Text,
                DepartmentID = txtDepartmentID.Text,
                Age = int.Parse(txtAge.Text),
                Password = txtPassword.Text,
                CNID = txtCNID.Text,
                PhoneNo = txtPhoneNo.Text,
                Email = txtEmail.Text,
                Position = txtPosition.Text
            };

            // 彈出提示框確認是否保存修改
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 更新 Staff 對象
                _staffDAL.UpdateStaff(modifiedStaff);

                // 顯示成功信息
                MessageBox.Show("Staff information updated successfully.");

                // 刷新頁面或執行其他相關操作
            }

            */
        }

    private void btnDeteleStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
