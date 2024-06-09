using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP4915MProject
{
    public partial class FrmResetPassword : Form
    {
        public Point mouseLocation;
        public FrmResetPassword()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
