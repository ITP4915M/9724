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
    public partial class FrmStockRecord : Form
    {
        StockRecordBLL stockRecordBLL = new StockRecordBLL();
        public FrmStockRecord()
        {
            InitializeComponent();
        }

        private void FrmStockRecord_Load(object sender, EventArgs e)
        {
           dgvStockRecordList.DataSource =  stockRecordBLL.GetStockRecords();

            //bind record type
            string[] recordTypes  = new string[] { "--Select RecordType--","In","Out"};
            cbxRecordType.Items.Clear();
            foreach (string recordType in recordTypes)
            {
                cbxRecordType.Items.Add(recordType);
            }
            cbxRecordType.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StockRecordBLL stockRecordBLL = new StockRecordBLL();
            string recordType = null;
            if (cbxRecordType.Text!= "--Select RecordType--") {
                recordType = cbxRecordType.Text;
            }
           
            DateTime? recordTime = null;
            if (dtpDate.Checked)
            {
                recordTime = dtpDate.Value.Date;
            }
            List<StockRecord> stockRecords = stockRecordBLL.GetStockRecordsByType(recordType, recordTime);
            dgvStockRecordList.DataSource = stockRecords;



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxRecordType.SelectedIndex = 0;
            dgvStockRecordList.DataSource = stockRecordBLL.GetStockRecords();

        }
    }
}
