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
    public delegate void DelBindDgv();
    public partial class FrmStaffManagment : Form
    {
        DelBindDgv delBindDgv;

        public FrmStaffManagment()
        {
            InitializeComponent();
          
        }
        private void BindCbx()
        {
            DepartmentBLL departmentBll = new DepartmentBLL();
            List<Department> departments = departmentBll.GetDepartments();
            departments.Insert(0, new Department { DepartmentID = "0", DepartmentName = "Select Department" });
            cbxDepartment.DataSource = departments;
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "DepartmentName";
        }

        private void BindDgv()
        {
            //binding the datagridview with staffdepartment data
            string staffName = txtStaffName.Text.Trim();
            string department = (string)cbxDepartment.SelectedValue;
            StaffDepartmentBLL staffDepartmentBll = new StaffDepartmentBLL();
            List<StaffDepartment> StaffDepartments = staffDepartmentBll.GetStaffDepartmentsList();
            if (department == "Select Department" && staffName == "")
            {
                dgvStaff.DataSource = StaffDepartments;
            }
            else if (department == "Select Department" && staffName != "")
            {

                dgvStaff.DataSource = StaffDepartments.FindAll(m => m.StaffName.Contains(staffName));
            }
            else
            {
                dgvStaff.DataSource = StaffDepartments.FindAll(m => m.StaffName.Contains(staffName) && m.DepartmentName == department);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount(delBindDgv);
            frmCreateAccount.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStaffName.Clear();
            BindCbx();
            BindDgv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void FrmStaffManagment_Load(object sender, EventArgs e)
        {
            //binding the combobox with departmentName
            BindCbx();
            //binding the datagridview with staffdepartment entity
            BindDgv();
            delBindDgv = BindDgv;


        }

    }



}
