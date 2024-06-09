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
    public partial class FrmMainPage : Form
    {
        public Point mouseLocation;
        private Point mouseOffset;
        int panelWidth;
        bool isCollapsed;
        bool orderCollasped;
        public FrmMainPage()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e) //click Meun icon can collapsed
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    Slidetimer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 55)
                {
                    Slidetimer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); //display time
            Lbl_Data.Text = DateTime.Now.ToLongDateString();//display data
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slidetimer1.Start();
        }

        private void btnOrder_Click(object sender, EventArgs e)

        {
            SalseTimer.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void loadform(object Form) {
            if (this.panMain.Controls.Count > 0) {
                this.panMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(f);
            this.panMain.Tag = f;
            f.Show();
        
        
        }

     

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            ContainerCollection();
        }

        private void ContainerCollection()
        {
            if (orderCollasped)
            {
                containerSalesContainerSales.Height += 180;
                if (containerSalesContainerSales.Height == containerSalesContainerSales.MaximumSize.Height) ;
                orderCollasped = false;
                SalseTimer.Stop();
            }
            else
            {
                containerSalesContainerSales.Height -= 180;
                if (containerSalesContainerSales.Height == containerSalesContainerSales.MinimumSize.Height) ;
                orderCollasped = true;
                SalseTimer.Stop();
            }
        }

        private void btnItemManagment_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_OrderList_Click(object sender, EventArgs e)
        {
            loadform(new FrmOrderList());
        }

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            loadform(new FrmCreateOrder());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseOffset = new Point(e.X, e.Y);
        }
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(e.X - mouseOffset.X, e.Y - mouseOffset.Y);
                Location = PointToScreen(newLocation);
            }
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            SalseTimer.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click_1(object sender, EventArgs e)
        {

        }
    }
}
