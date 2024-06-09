
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
            this.grpStockLevel.Location = new System.Drawing.Point(52, 45);
            this.grpStockLevel.Name = "grpStockLevel";
            this.grpStockLevel.Size = new System.Drawing.Size(838, 566);
            this.grpStockLevel.TabIndex = 0;
            this.grpStockLevel.TabStop = false;
            this.grpStockLevel.Text = "Set Stock Level";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(460, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(653, 488);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 50);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // nudOverflowLevel
            // 
            this.nudOverflowLevel.Location = new System.Drawing.Point(227, 421);
            this.nudOverflowLevel.Name = "nudOverflowLevel";
            this.nudOverflowLevel.Size = new System.Drawing.Size(180, 35);
            this.nudOverflowLevel.TabIndex = 9;
            // 
            // nudDangerLevel
            // 
            this.nudDangerLevel.Location = new System.Drawing.Point(227, 338);
            this.nudDangerLevel.Name = "nudDangerLevel";
            this.nudDangerLevel.Size = new System.Drawing.Size(180, 35);
            this.nudDangerLevel.TabIndex = 8;
            // 
            // nudLowLevel
            // 
            this.nudLowLevel.Location = new System.Drawing.Point(227, 265);
            this.nudLowLevel.Name = "nudLowLevel";
            this.nudLowLevel.Size = new System.Drawing.Size(180, 35);
            this.nudLowLevel.TabIndex = 7;
            // 
            // nudSafeLevel
            // 
            this.nudSafeLevel.Location = new System.Drawing.Point(227, 183);
            this.nudSafeLevel.Name = "nudSafeLevel";
            this.nudSafeLevel.Size = new System.Drawing.Size(180, 35);
            this.nudSafeLevel.TabIndex = 6;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(207, 67);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(242, 35);
            this.txtItemID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "OverFlow Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danger Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Low Level:";
            // 
            // lblSafeLevel
            // 
            this.lblSafeLevel.AutoSize = true;
            this.lblSafeLevel.Location = new System.Drawing.Point(40, 185);
            this.lblSafeLevel.Name = "lblSafeLevel";
            this.lblSafeLevel.Size = new System.Drawing.Size(142, 24);
            this.lblSafeLevel.TabIndex = 1;
            this.lblSafeLevel.Text = "Safe Level:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(64, 70);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(82, 24);
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "ItemID";
            // 
            // FrmStockLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 658);
            this.Controls.Add(this.grpStockLevel);
            this.Name = "FrmStockLevel";
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