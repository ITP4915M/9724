
namespace ITP4915MProject
{
    partial class FrmOrderAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderAddItem));
            this.grpItemList = new System.Windows.Forms.GroupBox();
            this.dgvItemInfo = new System.Windows.Forms.DataGridView();
            this.cbxCatagory = new System.Windows.Forms.ComboBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpItemList
            // 
            this.grpItemList.Controls.Add(this.dgvItemInfo);
            this.grpItemList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpItemList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.grpItemList.Location = new System.Drawing.Point(0, 189);
            this.grpItemList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpItemList.Name = "grpItemList";
            this.grpItemList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpItemList.Size = new System.Drawing.Size(874, 528);
            this.grpItemList.TabIndex = 3;
            this.grpItemList.TabStop = false;
            this.grpItemList.Text = "Item List";
            // 
            // dgvItemInfo
            // 
            this.dgvItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemInfo.Location = new System.Drawing.Point(3, 24);
            this.dgvItemInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvItemInfo.Name = "dgvItemInfo";
            this.dgvItemInfo.RowHeadersWidth = 82;
            this.dgvItemInfo.RowTemplate.Height = 37;
            this.dgvItemInfo.Size = new System.Drawing.Size(868, 500);
            this.dgvItemInfo.TabIndex = 0;
            // 
            // cbxCatagory
            // 
            this.cbxCatagory.FormattingEnabled = true;
            this.cbxCatagory.Location = new System.Drawing.Point(478, 49);
            this.cbxCatagory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCatagory.Name = "cbxCatagory";
            this.cbxCatagory.Size = new System.Drawing.Size(164, 27);
            this.cbxCatagory.TabIndex = 5;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Location = new System.Drawing.Point(390, 52);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(82, 19);
            this.lblCatagory.TabIndex = 4;
            this.lblCatagory.Text = "Catagory";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(126, 114);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(227, 27);
            this.txtItemName.TabIndex = 3;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(127, 49);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(227, 27);
            this.txtItemID.TabIndex = 2;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(24, 117);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 19);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(10, 49);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(111, 19);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "Item Number";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnConfirm);
            this.grpFilter.Controls.Add(this.button1);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.cbxCatagory);
            this.grpFilter.Controls.Add(this.lblCatagory);
            this.grpFilter.Controls.Add(this.txtItemName);
            this.grpFilter.Controls.Add(this.txtItemID);
            this.grpFilter.Controls.Add(this.lblItemName);
            this.grpFilter.Controls.Add(this.lblItemID);
            this.grpFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.grpFilter.Location = new System.Drawing.Point(0, 19);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Size = new System.Drawing.Size(874, 162);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(7, 7);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.grpItemList);
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 717);
            this.panel1.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(832, -2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 30);
            this.btn_close.TabIndex = 12;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = global::ITP4915MProject.Properties.Resources.checked_24;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirm.Location = new System.Drawing.Point(664, 117);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Padding = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Size = new System.Drawing.Size(103, 38);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ITP4915MProject.Properties.Resources.search_242;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(529, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(103, 38);
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
            this.btnReset.Image = global::ITP4915MProject.Properties.Resources.reset_242;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(394, 117);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(2);
            this.btnReset.Size = new System.Drawing.Size(103, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmOrderAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 745);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrderAddItem";
            this.Text = "pan";
            this.Load += new System.EventHandler(this.FrmOrderAddItem_Load);
            this.grpItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemInfo)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemList;
        private System.Windows.Forms.DataGridView dgvItemInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbxCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
    }
}