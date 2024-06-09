
namespace ITP4915MProject.Inventory_Management
{
    partial class FrmCreateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxItemCategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemWeight = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.TxtItemDescrption = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.picItemPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateitem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(882, 585);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateitem);
            this.groupBox1.Controls.Add(this.cbxItemCategory);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtItemPrice);
            this.groupBox1.Controls.Add(this.txtItemWeight);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.TxtItemDescrption);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.picItemPicture);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create item";
            // 
            // cbxItemCategory
            // 
            this.cbxItemCategory.FormattingEnabled = true;
            this.cbxItemCategory.Location = new System.Drawing.Point(578, 62);
            this.cbxItemCategory.Name = "cbxItemCategory";
            this.cbxItemCategory.Size = new System.Drawing.Size(133, 31);
            this.cbxItemCategory.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(90, 494);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Item List";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(188, 210);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(167, 32);
            this.txtItemPrice.TabIndex = 13;
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.Location = new System.Drawing.Point(578, 135);
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(100, 32);
            this.txtItemWeight.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(188, 136);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(167, 32);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(188, 62);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(167, 32);
            this.txtItemName.TabIndex = 9;
            // 
            // TxtItemDescrption
            // 
            this.TxtItemDescrption.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.TxtItemDescrption.Location = new System.Drawing.Point(188, 284);
            this.TxtItemDescrption.Name = "TxtItemDescrption";
            this.TxtItemDescrption.Size = new System.Drawing.Size(167, 95);
            this.TxtItemDescrption.TabIndex = 8;
            this.TxtItemDescrption.Text = "";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = global::ITP4915MProject.Properties.Resources.image_upload_24;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.Location = new System.Drawing.Point(491, 249);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 34);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // picItemPicture
            // 
            this.picItemPicture.Location = new System.Drawing.Point(578, 208);
            this.picItemPicture.Name = "picItemPicture";
            this.picItemPicture.Size = new System.Drawing.Size(230, 205);
            this.picItemPicture.TabIndex = 1;
            this.picItemPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrption:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            // 
            // btnCreateitem
            // 
            this.btnCreateitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnCreateitem.ForeColor = System.Drawing.Color.White;
            this.btnCreateitem.Image = global::ITP4915MProject.Properties.Resources.plus_24;
            this.btnCreateitem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateitem.Location = new System.Drawing.Point(674, 494);
            this.btnCreateitem.Name = "btnCreateitem";
            this.btnCreateitem.Padding = new System.Windows.Forms.Padding(2);
            this.btnCreateitem.Size = new System.Drawing.Size(134, 34);
            this.btnCreateitem.TabIndex = 18;
            this.btnCreateitem.Text = "Create Item";
            this.btnCreateitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateitem.UseVisualStyleBackColor = false;
            this.btnCreateitem.Click += new System.EventHandler(this.btnCreateitem_Click);
            // 
            // FrmCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 605);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCreateItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateItem";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemWeight;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.RichTextBox TxtItemDescrption;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.PictureBox picItemPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItemCategory;
        private System.Windows.Forms.Button btnCreateitem;
    }
}