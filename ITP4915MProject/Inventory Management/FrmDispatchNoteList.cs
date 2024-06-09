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

namespace ITP4915MProject
{
    public partial class FrmDispatchNoteList : Form
    {
        DealerOrderBLL dealerOrderBLL = new DealerOrderBLL();
        public FrmDispatchNoteList()
        {
            InitializeComponent();
        }

        private void FrmDispatchNoteList_Load(object sender, EventArgs e)
        {
            dgvDISet.DataSource = dealerOrderBLL.getAllDealerOrders();
            //set the status color 
            dgvDISet.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvOrderList_CellFormatting);
            //initialize the view detail button
    
            DataGridViewButtonColumn viewDetailColumn = new DataGridViewButtonColumn();
            viewDetailColumn.Name = "ViewDetail";
            viewDetailColumn.Text = "View Detail";
            viewDetailColumn.UseColumnTextForButtonValue = true; 
            dgvDISet.Columns.Add(viewDetailColumn);

            dgvDISet.CellClick += new DataGridViewCellEventHandler(dgvDISet_CellClick);
        }
        private void dgvDISet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgvDISet.Columns["ViewDetail"].Index && e.RowIndex >= 0)
            {
                // collect the orderid in specific row
                string  orderId = dgvDISet.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();

                // show the diset detail form
                FrmDispatchNoteDetail frmDispatchNoteDetail = new FrmDispatchNoteDetail(orderId);
                frmDispatchNoteDetail.ShowDialog();
            }
        }
        private void dgvOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvDISet.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string statusValue = e.Value.ToString();
                    switch (statusValue)
                    {
                        case "Draft":
                            e.CellStyle.ForeColor = Color.Orange;
                            break;
                        case "Cancelled":
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                        case "Pending":
                            e.CellStyle.ForeColor = Color.DarkGray;
                            break;
                        case "Processing":
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case "Delivered":
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                        case "Shipped":
                            e.CellStyle.ForeColor = Color.Green;
                            break;
                        default:
                            e.CellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }

       
    }
}
