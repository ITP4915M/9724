
namespace ITP4915MProject
{
    partial class FrmDispatchNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDispatchNoteList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDISet = new System.Windows.Forms.DataGridView();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDISet)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(731, 614);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDISet);
            this.groupBox2.Location = new System.Drawing.Point(8, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(716, 413);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispatch Note List";
            // 
            // dgvDISet
            // 
            this.dgvDISet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDISet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDISet.Location = new System.Drawing.Point(4, 25);
            this.dgvDISet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDISet.Name = "dgvDISet";
            this.dgvDISet.RowHeadersWidth = 82;
            this.dgvDISet.RowTemplate.Height = 23;
            this.dgvDISet.Size = new System.Drawing.Size(708, 383);
            this.dgvDISet.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.textBox2);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.textBox1);
            this.grpFilter.Controls.Add(this.lblOrderNumber);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Location = new System.Drawing.Point(8, 31);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFilter.Size = new System.Drawing.Size(716, 155);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 27);
            this.textBox1.TabIndex = 2;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(43, 55);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(125, 19);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order Number:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ITP4915MProject.Properties.Resources.search_241;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(472, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(112, 49);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(683, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // FrmDispatchNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(751, 634);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDispatchNoteList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmDispatchNoteList";
            this.Load += new System.EventHandler(this.FrmDispatchNoteList_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDISet)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDISet;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_close;
    }
}