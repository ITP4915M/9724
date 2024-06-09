
namespace ITP4915MProject
{
    partial class FrmDispatchNoteDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpOrderItem = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.grpDealerInfo = new System.Windows.Forms.GroupBox();
            this.rtbShippingAddress = new System.Windows.Forms.RichTextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.grpDealerInfo.SuspendLayout();
            this.grpOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.grpOrderItem);
            this.panel1.Controls.Add(this.grpDealerInfo);
            this.panel1.Controls.Add(this.grpOrderInfo);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 715);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::ITP4915MProject.Properties.Resources.printer_24;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(603, 662);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(2);
            this.btnPrint.Size = new System.Drawing.Size(99, 43);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::ITP4915MProject.Properties.Resources.delete_241;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(747, 662);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(2);
            this.btnBack.Size = new System.Drawing.Size(99, 43);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // grpOrderItem
            // 
            this.grpOrderItem.Controls.Add(this.dgvOrderItem);
            this.grpOrderItem.Location = new System.Drawing.Point(4, 230);
            this.grpOrderItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderItem.Name = "grpOrderItem";
            this.grpOrderItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderItem.Size = new System.Drawing.Size(868, 427);
            this.grpOrderItem.TabIndex = 12;
            this.grpOrderItem.TabStop = false;
            this.grpOrderItem.Text = "Order Item";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.Location = new System.Drawing.Point(4, 30);
            this.dgvOrderItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 82;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(860, 392);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // grpDealerInfo
            // 
            this.grpDealerInfo.Controls.Add(this.rtbShippingAddress);
            this.grpDealerInfo.Controls.Add(this.txtDealerName);
            this.grpDealerInfo.Controls.Add(this.lblShippingAddress);
            this.grpDealerInfo.Controls.Add(this.lblDealerName);
            this.grpDealerInfo.Location = new System.Drawing.Point(381, 21);
            this.grpDealerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDealerInfo.Name = "grpDealerInfo";
            this.grpDealerInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDealerInfo.Size = new System.Drawing.Size(465, 201);
            this.grpDealerInfo.TabIndex = 10;
            this.grpDealerInfo.TabStop = false;
            this.grpDealerInfo.Text = "Dealer Information";
            // 
            // rtbShippingAddress
            // 
            this.rtbShippingAddress.BackColor = System.Drawing.Color.White;
            this.rtbShippingAddress.Location = new System.Drawing.Point(183, 111);
            this.rtbShippingAddress.Name = "rtbShippingAddress";
            this.rtbShippingAddress.ReadOnly = true;
            this.rtbShippingAddress.Size = new System.Drawing.Size(266, 81);
            this.rtbShippingAddress.TabIndex = 5;
            this.rtbShippingAddress.Text = "";
            // 
            // txtDealerName
            // 
            this.txtDealerName.BackColor = System.Drawing.Color.White;
            this.txtDealerName.Location = new System.Drawing.Point(183, 46);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(266, 32);
            this.txtDealerName.TabIndex = 4;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Location = new System.Drawing.Point(18, 111);
            this.lblShippingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(183, 23);
            this.lblShippingAddress.TabIndex = 2;
            this.lblShippingAddress.Text = "Shipping Address:";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(40, 49);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(146, 23);
            this.lblDealerName.TabIndex = 0;
            this.lblDealerName.Text = "Dealer Name:";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.txtOrderDate);
            this.grpOrderInfo.Controls.Add(this.txtOrderID);
            this.grpOrderInfo.Controls.Add(this.lblOrderDate);
            this.grpOrderInfo.Controls.Add(this.lblOrderID);
            this.grpOrderInfo.Location = new System.Drawing.Point(33, 21);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderInfo.Size = new System.Drawing.Size(306, 201);
            this.grpOrderInfo.TabIndex = 11;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.White;
            this.txtOrderDate.Location = new System.Drawing.Point(144, 113);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(133, 32);
            this.txtOrderDate.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.White;
            this.txtOrderID.Location = new System.Drawing.Point(144, 51);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(133, 32);
            this.txtOrderID.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(22, 116);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(123, 23);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(40, 54);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(97, 23);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // FrmDispatchNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 745);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDispatchNoteDetail";
            this.Text = "FrmDispatchNoteDetail";
            this.Load += new System.EventHandler(this.FrmDispatchNoteDetail_Load);
            this.panel1.ResumeLayout(false);
            this.grpOrderItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.grpDealerInfo.ResumeLayout(false);
            this.grpDealerInfo.PerformLayout();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpOrderItem;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.GroupBox grpDealerInfo;
        private System.Windows.Forms.RichTextBox rtbShippingAddress;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
    }
}