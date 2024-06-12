
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpStockRecord = new System.Windows.Forms.GroupBox();
            this.dgvStockRecordList = new System.Windows.Forms.DataGridView();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxRecordType = new System.Windows.Forms.ComboBox();
            this.lblRecordType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpStockRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecordList)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpStockRecord);
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 725);
            this.panel1.TabIndex = 0;
            // 
            // grpStockRecord
            // 
            this.grpStockRecord.Controls.Add(this.dgvStockRecordList);
            this.grpStockRecord.Location = new System.Drawing.Point(3, 208);
            this.grpStockRecord.Name = "grpStockRecord";
            this.grpStockRecord.Size = new System.Drawing.Size(876, 514);
            this.grpStockRecord.TabIndex = 3;
            this.grpStockRecord.TabStop = false;
            this.grpStockRecord.Text = "grpStockRecord";
            // 
            // dgvStockRecordList
            // 
            this.dgvStockRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockRecordList.Location = new System.Drawing.Point(3, 23);
            this.dgvStockRecordList.Name = "dgvStockRecordList";
            this.dgvStockRecordList.RowHeadersWidth = 82;
            this.dgvStockRecordList.RowTemplate.Height = 37;
            this.dgvStockRecordList.Size = new System.Drawing.Size(870, 488);
            this.dgvStockRecordList.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.lblDate);
            this.grpFilter.Controls.Add(this.dtpDate);
            this.grpFilter.Controls.Add(this.cbxRecordType);
            this.grpFilter.Controls.Add(this.lblRecordType);
            this.grpFilter.Location = new System.Drawing.Point(6, 17);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(870, 187);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(221, 120);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(2);
            this.btnReset.Size = new System.Drawing.Size(110, 45);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(24, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(110, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(381, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Record Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(522, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(254, 27);
            this.dtpDate.TabIndex = 2;
            // 
            // cbxRecordType
            // 
            this.cbxRecordType.FormattingEnabled = true;
            this.cbxRecordType.Location = new System.Drawing.Point(168, 44);
            this.cbxRecordType.Name = "cbxRecordType";
            this.cbxRecordType.Size = new System.Drawing.Size(124, 27);
            this.cbxRecordType.TabIndex = 1;
            // 
            // lblRecordType
            // 
            this.lblRecordType.AutoSize = true;
            this.lblRecordType.Location = new System.Drawing.Point(32, 44);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Size = new System.Drawing.Size(109, 19);
            this.lblRecordType.TabIndex = 0;
            this.lblRecordType.Text = "Record Type:";
            // 
            // FrmStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 745);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStockRecord";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmStockRecord";
            this.Load += new System.EventHandler(this.FrmStockRecord_Load);
            this.panel1.ResumeLayout(false);
            this.grpStockRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRecordList)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpStockRecord;
        private System.Windows.Forms.DataGridView dgvStockRecordList;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxRecordType;
        private System.Windows.Forms.Label lblRecordType;
    }
}