
namespace ITP4915MProject
{
    partial class FrmStockRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxRecordType = new System.Windows.Forms.ComboBox();
            this.lblRecordType = new System.Windows.Forms.Label();
            this.grpStockRecord = new System.Windows.Forms.GroupBox();
            this.dgvStockRecordList = new System.Windows.Forms.DataGridView();
            this.grpFilter.SuspendLayout();
            this.grpStockRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.lblDate);
            this.grpFilter.Controls.Add(this.dtpDate);
            this.grpFilter.Controls.Add(this.cbxRecordType);
            this.grpFilter.Controls.Add(this.lblRecordType);
            this.grpFilter.Location = new System.Drawing.Point(42, 31);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1264, 224);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(343, 151);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(226, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(32, 151);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(226, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Record";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(508, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(154, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Record Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(697, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(338, 35);
            this.dtpDate.TabIndex = 2;
            // 
            // cbxRecordType
            // 
            this.cbxRecordType.FormattingEnabled = true;
            this.cbxRecordType.Location = new System.Drawing.Point(225, 57);
            this.cbxRecordType.Name = "cbxRecordType";
            this.cbxRecordType.Size = new System.Drawing.Size(163, 32);
            this.cbxRecordType.TabIndex = 1;
            // 
            // lblRecordType
            // 
            this.lblRecordType.AutoSize = true;
            this.lblRecordType.Location = new System.Drawing.Point(42, 57);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Size = new System.Drawing.Size(154, 24);
            this.lblRecordType.TabIndex = 0;
            this.lblRecordType.Text = "Record Type:";
            // 
            // grpStockRecord
            // 
            this.grpStockRecord.Controls.Add(this.dgvStockRecordList);
            this.grpStockRecord.Location = new System.Drawing.Point(42, 261);
            this.grpStockRecord.Name = "grpStockRecord";
            this.grpStockRecord.Size = new System.Drawing.Size(1268, 588);
            this.grpStockRecord.TabIndex = 1;
            this.grpStockRecord.TabStop = false;
            this.grpStockRecord.Text = "grpStockRecord";
            // 
            // dgvStockRecordList
            // 
            this.dgvStockRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockRecordList.Location = new System.Drawing.Point(3, 31);
            this.dgvStockRecordList.Name = "dgvStockRecordList";
            this.dgvStockRecordList.RowHeadersWidth = 82;
            this.dgvStockRecordList.RowTemplate.Height = 37;
            this.dgvStockRecordList.Size = new System.Drawing.Size(1262, 554);
            this.dgvStockRecordList.TabIndex = 0;
            // 
            // FrmStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 898);
            this.Controls.Add(this.grpStockRecord);
            this.Controls.Add(this.grpFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStockRecord";
            this.Text = "FrmStockRecord";
            this.Load += new System.EventHandler(this.FrmStockRecord_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpStockRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecordList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxRecordType;
        private System.Windows.Forms.Label lblRecordType;
        private System.Windows.Forms.GroupBox grpStockRecord;
        private System.Windows.Forms.DataGridView dgvStockRecordList;
        private System.Windows.Forms.Button btnReset;
    }
}