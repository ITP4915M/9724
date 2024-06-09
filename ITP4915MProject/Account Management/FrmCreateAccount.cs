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
    public partial class FrmCreateAccount : Form
    {
        private DelBindDgv _delBindDgv;
        public FrmCreateAccount(DelBindDgv delBindDgv)
        {
            InitializeComponent();
            _delBindDgv = delBindDgv;

        }



        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            BindDepartmentCbx();

            BindPositionCbx();
        }

        private void BindPositionCbx()
        {
            List<Position> positions = new List<Position> {
                new Position { PositionName = "Warehouse Manager" },
                new Position { PositionName = "Warehouse Assistant" },
                 new Position { PositionName = "Warehouse Spare Despatch Manger" },
                 new Position { PositionName = "Sales Manager" },
                 new Position { PositionName = "Sales Assistant" },
                 new Position { PositionName = "Purchasing Manager" },
                 new Position { PositionName = "Purchasing Assistant" },
                 new Position { PositionName = "IT Manager" },
                 new Position { PositionName = "IT deloveper " },
                 new Position { PositionName = "Accounting Managerr " },
                 new Position { PositionName = "Accounting assistant" },
            };

            
            cbxPosition.DataSource = positions;
            cbxPosition.DisplayMember = "PositionName";
            cbxPosition.ValueMember = "PositionName";
        }

        private void BindDepartmentCbx()
        {
            DepartmentBLL departmentBll = new DepartmentBLL();
            List<Department> departments = departmentBll.GetDepartments();
            
            cbxDepartment.DataSource = departments;
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            string staffName = txtName.Text;
            string staffID = txtStaffID.Text;
            string cnid = txtCNID.Text;
            string departmentID = cbxDepartment.SelectedValue.ToString();
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string pwdValidate = txtConfirmPassword.Text;
            int age = (int)nudAge.Value;
            string phoneNo = txtPhoneNo.Text;
            string position = cbxPosition.SelectedValue.ToString();
            StaffBLL staffBLL = new StaffBLL();
            List<Staff> staffs = staffBLL.GetAllStaffs();
/*            foreach (Staff staff in staffs) { 
            }
*/
            if (string.IsNullOrEmpty(staffName))
            {
                MessageBox.Show("Please enter staff name", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(staffID))
            {
                MessageBox.Show("Please enter Staff ID", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStaffID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cnid))
            {
                MessageBox.Show("Please enter Staff CNID", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCNID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(departmentID))
            {
                MessageBox.Show("Please enter Department", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxDepartment.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Please enter password", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (pwd != pwdValidate)
            {
                MessageBox.Show("twice passwords are not the same", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }
            if (age <= 0)
            {
                MessageBox.Show("Please enter a valid age", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudAge.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phoneNo))
            {
                MessageBox.Show("Please enter a phone number", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please select a position", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxPosition.Focus();
                return;
            }

            Staff staff = new Staff
            {
                StaffID = staffID,
                StaffName = staffName,
                DepartmentID = departmentID,
                Age = age,
                CNID = cnid,
                Email = email,
                Password = pwd,
                PhoneNo = phoneNo,
                Position = position
            };
            StaffBLL staffBll = new StaffBLL();
            bool isAdd = staffBll.addStaff(staff);
            if (isAdd)
            {
                MessageBox.Show("Create Staff Account Successfu!l");

                _delBindDgv();
                Close();

            }
            else
            {
                MessageBox.Show("Can not  create Staff Account! ");
            }




        }
    }
}
