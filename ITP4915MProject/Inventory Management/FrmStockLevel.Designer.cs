
namespace ITP4915MProject
{
    partial class FrmStockLevel
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
            this.grpStockLevel = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.nudOverflowLevel = new System.Windows.Forms.NumericUpDown();
            this.nudDangerLevel = new System.Windows.Forms.NumericUpDown();
            this.nudLowLevel = new System.Windows.Forms.NumericUpDown();
            this.nudSafeLevel = new System.Windows.Forms.NumericUpDown();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSafeLevel = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.grpStockLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverflowLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDangerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpStockLevel
            // 
            this.grpStockLevel.BackColor = System.Drawing.Color.White;
            this.grpStockLevel.Controls.Add(this.btnCancel);
            this.grpStockLevel.Controls.Add(this.btnConfirm);
            this.grpStockLevel.Controls.Add(this.nudOverflowLevel);
            this.grpStockLevel.Controls.Add(this.nudDangerLevel);
            this.grpStockLevel.Controls.Add(this.nudLowLevel);
            this.grpStockLevel.Controls.Add(this.nudSafeLevel);
            this.grpStockLevel.Controls.Add(this.txtItemID);
            this.grpStockLevel.Controls.Add(this.label5);
            this.grpStockLevel.Controls.Add(this.label4);
            this.grpStockLevel.Controls.Add(this.label3);
            this.grpStockLevel.Controls.Add(this.lblSafeLevel);
            this.grpStockLevel.Controls.Add(this.lblItemID);
            this.grpStockLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.grpStockLevel.Location = new System.Drawing.Point(13, 13);
            this.grpStockLevel.Name = "grpStockLevel";
            this.grpStockLevel.Size = new System.Drawing.Size(679, 495);
            this.grpStockLevel.TabIndex = 0;
            this.grpStockLevel.TabStop = false;
            this.grpStockLevel.Text = "Set Stock Level";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(40, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(184, 406);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(105, 40);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // nudOverflowLevel
            // 
            this.nudOverflowLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.nudOverflowLevel.Location = new System.Drawing.Point(155, 327);
            this.nudOverflowLevel.Name = "nudOverflowLevel";
            this.nudOverflowLevel.Size = new System.Drawing.Size(135, 27);
            this.nudOverflowLevel.TabIndex = 9;
            // 
            // nudDangerLevel
            // 
            this.nudDangerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.nudDangerLevel.Location = new System.Drawing.Point(155, 258);
            this.nudDangerLevel.Name = "nudDangerLevel";
            this.nudDangerLevel.Size = new System.Drawing.Size(135, 27);
            this.nudDangerLevel.TabIndex = 8;
            // 
            // nudLowLevel
            // 
            this.nudLowLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.nudLowLevel.Location = new System.Drawing.Point(155, 189);
            this.nudLowLevel.Name = "nudLowLevel";
            this.nudLowLevel.Size = new System.Drawing.Size(135, 27);
            this.nudLowLevel.TabIndex = 7;
            // 
            // nudSafeLevel
            // 
            this.nudSafeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.nudSafeLevel.Location = new System.Drawing.Point(155, 120);
            this.nudSafeLevel.Name = "nudSafeLevel";
            this.nudSafeLevel.Size = new System.Drawing.Size(135, 27);
            this.nudSafeLevel.TabIndex = 6;
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.Color.White;
            this.txtItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.txtItemID.Location = new System.Drawing.Point(155, 51);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(135, 27);
            this.txtItemID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "OverFlow Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danger Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low Level:";
            // 
            // lblSafeLevel
            // 
            this.lblSafeLevel.AutoSize = true;
            this.lblSafeLevel.Location = new System.Drawing.Point(48, 124);
            this.lblSafeLevel.Name = "lblSafeLevel";
            this.lblSafeLevel.Size = new System.Drawing.Size(90, 19);
            this.lblSafeLevel.TabIndex = 1;
            this.lblSafeLevel.Text = "Safe Level:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(80, 54);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(62, 19);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "ItemID:";
            // 
            // FrmStockLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(705, 521);
            this.Controls.Add(this.grpStockLevel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStockLevel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmStockLevel";
            this.Load += new System.EventHandler(this.FrmStockLevel_Load);
            this.grpStockLevel.ResumeLayout(false);
            this.grpStockLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverflowLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDangerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSafeLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockLevel;
        private System.Windows.Forms.NumericUpDown nudOverflowLevel;
        private System.Windows.Forms.NumericUpDown nudDangerLevel;
        private System.Windows.Forms.NumericUpDown nudLowLevel;
        private System.Windows.Forms.NumericUpDown nudSafeLevel;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSafeLevel;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}