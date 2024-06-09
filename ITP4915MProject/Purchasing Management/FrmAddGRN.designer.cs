
namespace ITP4915MProject.Purchasing_Management
{
    partial class FrmAddGRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddGRN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGotoPayment = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnGRN = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpGoodReceiveItem = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGoodReceiveItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 719);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(834, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGotoPayment);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.btnGRN);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grpGoodReceiveItem);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Controls.Add(this.lblSupplierName);
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 685);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Add Item";
            // 
            // btnGotoPayment
            // 
            this.btnGotoPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnGotoPayment.ForeColor = System.Drawing.Color.White;
            this.btnGotoPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnGotoPayment.Image")));
            this.btnGotoPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGotoPayment.Location = new System.Drawing.Point(624, 613);
            this.btnGotoPayment.Name = "btnGotoPayment";
            this.btnGotoPayment.Padding = new System.Windows.Forms.Padding(2);
            this.btnGotoPayment.Size = new System.Drawing.Size(161, 39);
            this.btnGotoPayment.TabIndex = 10;
            this.btnGotoPayment.Text = "Go To Payment";
            this.btnGotoPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGotoPayment.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.Location = new System.Drawing.Point(185, 613);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Size = new System.Drawing.Size(171, 39);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item to GRN";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnGRN
            // 
            this.btnGRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnGRN.ForeColor = System.Drawing.Color.White;
            this.btnGRN.Image = ((System.Drawing.Image)(resources.GetObject("btnGRN.Image")));
            this.btnGRN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGRN.Location = new System.Drawing.Point(30, 613);
            this.btnGRN.Name = "btnGRN";
            this.btnGRN.Padding = new System.Windows.Forms.Padding(2);
            this.btnGRN.Size = new System.Drawing.Size(99, 39);
            this.btnGRN.TabIndex = 8;
            this.btnGRN.Text = "GRN";
            this.btnGRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGRN.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(451, 619);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 32);
            this.textBox5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // grpGoodReceiveItem
            // 
            this.grpGoodReceiveItem.Controls.Add(this.dataGridView1);
            this.grpGoodReceiveItem.Location = new System.Drawing.Point(17, 110);
            this.grpGoodReceiveItem.Name = "grpGoodReceiveItem";
            this.grpGoodReceiveItem.Size = new System.Drawing.Size(794, 486);
            this.grpGoodReceiveItem.TabIndex = 2;
            this.grpGoodReceiveItem.TabStop = false;
            this.grpGoodReceiveItem.Text = "Good Receive Item";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(171, 52);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(176, 32);
            this.txtSupplier.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(26, 55);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(159, 23);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // FrmAddGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 745);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddGRN";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGoodReceiveItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpGoodReceiveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button btnGRN;
        private System.Windows.Forms.Button btnGotoPayment;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btn_close;
    }
}