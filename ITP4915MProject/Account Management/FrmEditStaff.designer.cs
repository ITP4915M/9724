﻿
namespace ITP4915MProject.Account_Management
{
    partial class FrmEditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeteleStaff = new System.Windows.Forms.Button();
            this.btnStaffList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmModify = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputStaffID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeteleStaff);
            this.panel1.Controls.Add(this.btnStaffList);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnDeteleStaff
            // 
            this.btnDeteleStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnDeteleStaff.ForeColor = System.Drawing.Color.Red;
            this.btnDeteleStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnDeteleStaff.Image")));
            this.btnDeteleStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeteleStaff.Location = new System.Drawing.Point(550, 495);
            this.btnDeteleStaff.Name = "btnDeteleStaff";
            this.btnDeteleStaff.Padding = new System.Windows.Forms.Padding(2);
            this.btnDeteleStaff.Size = new System.Drawing.Size(185, 41);
            this.btnDeteleStaff.TabIndex = 16;
            this.btnDeteleStaff.Text = "Remove Staff";
            this.btnDeteleStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeteleStaff.UseVisualStyleBackColor = false;
            this.btnDeteleStaff.Click += new System.EventHandler(this.btnDeteleStaff_Click);
            // 
            // btnStaffList
            // 
            this.btnStaffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnStaffList.ForeColor = System.Drawing.Color.White;
            this.btnStaffList.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffList.Image")));
            this.btnStaffList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffList.Location = new System.Drawing.Point(41, 495);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Padding = new System.Windows.Forms.Padding(2);
            this.btnStaffList.Size = new System.Drawing.Size(108, 41);
            this.btnStaffList.TabIndex = 15;
            this.btnStaffList.Text = "Staff List";
            this.btnStaffList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffList.UseVisualStyleBackColor = false;
            this.btnStaffList.Click += new System.EventHandler(this.btnStaffList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmModify);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.outputStaffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Staff";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConfirmModify
            // 
            this.btnConfirmModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConfirmModify.ForeColor = System.Drawing.Color.White;
            this.btnConfirmModify.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmModify.Image")));
            this.btnConfirmModify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmModify.Location = new System.Drawing.Point(475, 280);
            this.btnConfirmModify.Name = "btnConfirmModify";
            this.btnConfirmModify.Padding = new System.Windows.Forms.Padding(2);
            this.btnConfirmModify.Size = new System.Drawing.Size(195, 41);
            this.btnConfirmModify.TabIndex = 14;
            this.btnConfirmModify.Text = "Confirm Modify";
            this.btnConfirmModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmModify.UseVisualStyleBackColor = false;
            this.btnConfirmModify.Click += new System.EventHandler(this.btnConfirmModify_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(180, 294);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 32);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(180, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 32);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(581, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(581, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "CNID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone No. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Name:";
            // 
            // outputStaffID
            // 
            this.outputStaffID.AutoSize = true;
            this.outputStaffID.Location = new System.Drawing.Point(225, 39);
            this.outputStaffID.Name = "outputStaffID";
            this.outputStaffID.Size = new System.Drawing.Size(71, 23);
            this.outputStaffID.TabIndex = 1;
            this.outputStaffID.Text = "StaffID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID:";
            // 
            // FrmEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditStaff";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "FrmEditStaff";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStaffList;
        private System.Windows.Forms.Button btnConfirmModify;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeteleStaff;
    }
}