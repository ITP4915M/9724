
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpOrderItem = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpDealerInfo = new System.Windows.Forms.GroupBox();
            this.rtbShippingAddress = new System.Windows.Forms.RichTextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.grpOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.grpOrderInfo.SuspendLayout();
            this.grpDealerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1048, 902);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(168, 70);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1264, 902);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 70);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // grpOrderItem
            // 
            this.grpOrderItem.Controls.Add(this.dgvOrderItem);
            this.grpOrderItem.Location = new System.Drawing.Point(64, 314);
            this.grpOrderItem.Margin = new System.Windows.Forms.Padding(6);
            this.grpOrderItem.Name = "grpOrderItem";
            this.grpOrderItem.Padding = new System.Windows.Forms.Padding(6);
            this.grpOrderItem.Size = new System.Drawing.Size(1374, 514);
            this.grpOrderItem.TabIndex = 6;
            this.grpOrderItem.TabStop = false;
            this.grpOrderItem.Text = "Order Item";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.Location = new System.Drawing.Point(6, 34);
            this.dgvOrderItem.Margin = new System.Windows.Forms.Padding(6);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 82;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(1362, 474);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.txtOrderDate);
            this.grpOrderInfo.Controls.Add(this.txtOrderID);
            this.grpOrderInfo.Controls.Add(this.lblOrderDate);
            this.grpOrderInfo.Controls.Add(this.lblOrderID);
            this.grpOrderInfo.Location = new System.Drawing.Point(64, 24);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(6);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(6);
            this.grpOrderInfo.Size = new System.Drawing.Size(590, 278);
            this.grpOrderInfo.TabIndex = 5;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(193, 120);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(241, 35);
            this.txtOrderDate.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(193, 51);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(241, 35);
            this.txtOrderID.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(30, 131);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(142, 24);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(54, 54);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(118, 24);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // grpDealerInfo
            // 
            this.grpDealerInfo.Controls.Add(this.rtbShippingAddress);
            this.grpDealerInfo.Controls.Add(this.txtDealerName);
            this.grpDealerInfo.Controls.Add(this.lblShippingAddress);
            this.grpDealerInfo.Controls.Add(this.lblDealerName);
            this.grpDealerInfo.Location = new System.Drawing.Point(756, 38);
            this.grpDealerInfo.Margin = new System.Windows.Forms.Padding(6);
            this.grpDealerInfo.Name = "grpDealerInfo";
            this.grpDealerInfo.Padding = new System.Windows.Forms.Padding(6);
            this.grpDealerInfo.Size = new System.Drawing.Size(670, 279);
            this.grpDealerInfo.TabIndex = 5;
            this.grpDealerInfo.TabStop = false;
            this.grpDealerInfo.Text = "Dealer Information";
            // 
            // rtbShippingAddress
            // 
            this.rtbShippingAddress.Location = new System.Drawing.Point(243, 128);
            this.rtbShippingAddress.Name = "rtbShippingAddress";
            this.rtbShippingAddress.ReadOnly = true;
            this.rtbShippingAddress.Size = new System.Drawing.Size(376, 136);
            this.rtbShippingAddress.TabIndex = 5;
            this.rtbShippingAddress.Text = "";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Location = new System.Drawing.Point(243, 51);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(6);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(376, 35);
            this.txtDealerName.TabIndex = 4;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Location = new System.Drawing.Point(23, 131);
            this.lblShippingAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(214, 24);
            this.lblShippingAddress.TabIndex = 2;
            this.lblShippingAddress.Text = "Shipping Address:";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(54, 54);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(154, 24);
            this.lblDealerName.TabIndex = 0;
            this.lblDealerName.Text = "Dealer Name:";
            // 
            // FrmDispatchNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 1032);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpOrderItem);
            this.Controls.Add(this.grpDealerInfo);
            this.Controls.Add(this.grpOrderInfo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDispatchNoteDetail";
            this.Text = "FrmDispatchNoteDetail";
            this.Load += new System.EventHandler(this.FrmDispatchNoteDetail_Load);
            this.grpOrderItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpDealerInfo.ResumeLayout(false);
            this.grpDealerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpOrderItem;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.GroupBox grpDealerInfo;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.RichTextBox rtbShippingAddress;
    }
}