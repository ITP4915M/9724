using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;
using Common;
using BLL;


namespace ITP4915MProject
{
    public partial class FrmForgetPassword : Form
    {
        static  string randomCode;
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            SMTPHelper smtpHelper = new SMTPHelper();
            string to = txtEmail.Text;
            try
            {
                randomCode = smtpHelper.sendRestCode(to);
                MessageBox.Show("send resetcode successful");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {

            if (randomCode == (txtCode.Text).ToString())
            {
                FrmResetPassword rp = new FrmResetPassword();
                this.Hide();
                rp.Show();
            }
            else if (txtCode.Text.Length== 0) {
                MessageBox.Show("please send reset code first");
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
