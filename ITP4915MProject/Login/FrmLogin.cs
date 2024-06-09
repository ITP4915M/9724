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
using Common;
using Models;

namespace ITP4915MProject
{
    
    public partial class FrmLogin : Form
    {
        public Point mouseLocation;
        StaffBLL staffBLL = new StaffBLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //獲取用戶輸入的數值
            string staffID = txtStaffID.Text;
            string password = txtPassword.Text;

            //將用戶密碼進行MD5加密
            //string pwdMd5 = MD5Helper.GetMD5_32(password);

            if (staffID.Length == 0 ||
            password.Length == 0)
            {
                MessageBox.Show("Missing username or password. "
                            + "Please try again.");
                txtStaffID.Clear();
                txtPassword.Clear();
            }
            else if (staffBLL.checkValidation(staffID, password))                         //調用staffBBL的checkValidation方法 驗證登錄信息
            {
                MessageBox.Show("Login Successful!");
                GlobalVariables.StaffID = txtStaffID.Text;
                this.Hide();                                                                             // 隱藏當前窗口
                FrmMainPage mainForm = new FrmMainPage(GlobalVariables.StaffID);
                mainForm.Closed += (s, args) => this.Close();   // 當主頁面關閉時，登錄頁面也關閉
                mainForm.Show();
            }
            else {
                MessageBox.Show("Incorrect user name or password. "
                           + "Please try again.");


            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e) //右上角個X,離開程式
        {
            Application.Exit();
        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertChinese_Click(object sender, EventArgs e)
        {
            lblStaffID.Text = "员工ID:";
            lblPassword.Text = "密码:";
            btnForgerPassword.Text = "忘记密码?";
            btnLogin.Text = "登录";
            grpLogin.Text = "登录";
            btnConvertEng.ForeColor = Color.Black;
            btnConvertEng.BackColor = Color.White;
            btnConvertChinese.ForeColor = Color.White;
            btnConvertChinese.BackColor = Color.Black;
        }

        private void btnConvertEng_Click(object sender, EventArgs e)
        {
            lblStaffID.Text = "StaffID:";
            lblPassword.Text = "Password:";
            btnForgerPassword.Text = "Forgot Password?";
            btnLogin.Text = "Login";
            grpLogin.Text = "Login";
            btnConvertChinese.ForeColor = Color.Black;
            btnConvertChinese.BackColor = Color.White;
            btnConvertEng.ForeColor = Color.White;
            btnConvertEng.BackColor = Color.Black;
        }

        private void btnForgerPassword_Click(object sender, EventArgs e)
        {
            
            FrmForgetPassword fp = new FrmForgetPassword();
            fp.ShowDialog();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(Cursor.Position.X - mouseLocation.X, Cursor.Position.Y - mouseLocation.Y);
                Location = newLocation;
            }
        }
            private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
