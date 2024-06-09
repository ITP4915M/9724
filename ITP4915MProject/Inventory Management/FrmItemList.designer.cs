
namespace ITP4915MProject
{
    partial class FrmItemList
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
            this.cbxCatagory = new System.Windows.Forms.ComboBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.grpItemList = new System.Windows.Forms.GroupBox();
            this.dgvItemInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            this.grpItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.White;
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.cbxCatagory);
            this.grpFilter.Controls.Add(this.lblCatagory);
            this.grpFilter.Controls.Add(this.txtItemName);
            this.grpFilter.Controls.Add(this.txtItemID);
            this.grpFilter.Controls.Add(this.lblItemName);
            this.grpFilter.Controls.Add(this.lblItemID);
            this.grpFilter.Location = new System.Drawing.Point(3, 3);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(875, 167);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // cbxCatagory
            // 
            this.cbxCatagory.FormattingEnabled = true;
            this.cbxCatagory.Location = new System.Drawing.Point(598, 41);
            this.cbxCatagory.Name = "cbxCatagory";
            this.cbxCatagory.Size = new System.Drawing.Size(148, 27);
            this.cbxCatagory.TabIndex = 5;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(478, 42);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(86, 19);
            this.lblCatagory.TabIndex = 4;
            this.lblCatagory.Text = "Catagory:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(155, 115);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(205, 27);
            this.txtItemName.TabIndex = 3;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(155, 42);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(205, 27);
            this.txtItemID.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(11, 117);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 19);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(11, 42);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(115, 19);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "Item Number:";
            // 
            // grpItemList
            // 
            this.grpItemList.BackColor = System.Drawing.Color.White;
            this.grpItemList.Controls.Add(this.dgvItemInfo);
            this.grpItemList.Location = new System.Drawing.Point(3, 176);
            this.grpItemList.Name = "grpItemList";
            this.grpItemList.Size = new System.Drawing.Size(875, 545);
            this.grpItemList.TabIndex = 1;
            this.grpItemList.TabStop = false;
            this.grpItemList.Text = "Item List";
            // 
            // dgvItemInfo
            // 
            this.dgvItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInfo.Location = new System.Drawing.Point(6, 23);
            this.dgvItemInfo.Name = "dgvItemInfo";
            this.dgvItemInfo.RowHeadersWidth = 82;
            this.dgvItemInfo.RowTemplate.Height = 37;
            this.dgvItemInfo.Size = new System.Drawing.Size(863, 516);
            this.dgvItemInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Controls.Add(this.grpItemList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 756);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ITP4915MProject.Properties.Resources.search_241;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(635, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(124, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::ITP4915MProject.Properties.Resources.reset_241;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(482, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(2);
            this.btnReset.Size = new System.Drawing.Size(124, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 745);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemList";
            this.Text = "FrmItemList";
            this.Load += new System.EventHandler(this.FrmItemList_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.GroupBox grpItemList;
        private System.Windows.Forms.DataGridView dgvItemInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbxCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Panel panel1;
    }
}