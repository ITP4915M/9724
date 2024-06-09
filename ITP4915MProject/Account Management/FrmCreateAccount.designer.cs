
namespace ITP4915MProject
{
    partial class FrmCreateAccount
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpStaffInfo = new System.Windows.Forms.GroupBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCNID = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtCNID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.grpStaffInfo);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 456);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnBack.Location = new System.Drawing.Point(501, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 32);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpStaffInfo
            // 
            this.grpStaffInfo.BackColor = System.Drawing.Color.White;
            this.grpStaffInfo.Controls.Add(this.cbxPosition);
            this.grpStaffInfo.Controls.Add(this.txtConfirmPassword);
            this.grpStaffInfo.Controls.Add(this.cbxDepartment);
            this.grpStaffInfo.Controls.Add(this.label1);
            this.grpStaffInfo.Controls.Add(this.lblPosition);
            this.grpStaffInfo.Controls.Add(this.nudAge);
            this.grpStaffInfo.Controls.Add(this.txtStaffID);
            this.grpStaffInfo.Controls.Add(this.txtPassword);
            this.grpStaffInfo.Controls.Add(this.lblStaffID);
            this.grpStaffInfo.Controls.Add(this.lblPassword);
            this.grpStaffInfo.Controls.Add(this.lblName);
            this.grpStaffInfo.Controls.Add(this.lblDepartment);
            this.grpStaffInfo.Controls.Add(this.txtEmail);
            this.grpStaffInfo.Controls.Add(this.lblCNID);
            this.grpStaffInfo.Controls.Add(this.txtPhoneNo);
            this.grpStaffInfo.Controls.Add(this.lblEmail);
            this.grpStaffInfo.Controls.Add(this.lblPhoneNo);
            this.grpStaffInfo.Controls.Add(this.txtCNID);
            this.grpStaffInfo.Controls.Add(this.txtName);
            this.grpStaffInfo.Controls.Add(this.lblAge);
            this.grpStaffInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaffInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.grpStaffInfo.Location = new System.Drawing.Point(23, 23);
            this.grpStaffInfo.Margin = new System.Windows.Forms.Padding(0);
            this.grpStaffInfo.Name = "grpStaffInfo";
            this.grpStaffInfo.Padding = new System.Windows.Forms.Padding(0);
            this.grpStaffInfo.Size = new System.Drawing.Size(831, 374);
            this.grpStaffInfo.TabIndex = 19;
            this.grpStaffInfo.TabStop = false;
            this.grpStaffInfo.Text = "Staff Information";
            this.grpStaffInfo.Enter += new System.EventHandler(this.grpStaffInfo_Enter);
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(550, 208);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(203, 31);
            this.cbxPosition.TabIndex = 20;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(171, 317);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(203, 32);
            this.txtConfirmPassword.TabIndex = 17;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(171, 149);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(203, 31);
            this.cbxDepartment.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Re-Enter Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(456, 211);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(90, 23);
            this.lblPosition.TabIndex = 17;
            this.lblPosition.Text = "Position:";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(550, 38);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(54, 32);
            this.nudAge.TabIndex = 16;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(171, 37);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(203, 32);
            this.txtStaffID.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 32);
            this.txtPassword.TabIndex = 10;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(101, 40);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(83, 23);
            this.lblStaffID.TabIndex = 14;
            this.lblStaffID.Text = "Staff ID:";
            this.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 268);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(102, 97);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(53, 154);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(138, 23);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Departmemt:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 32);
            this.txtEmail.TabIndex = 13;
            // 
            // lblCNID
            // 
            this.lblCNID.AutoSize = true;
            this.lblCNID.Location = new System.Drawing.Point(474, 97);
            this.lblCNID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCNID.Name = "lblCNID";
            this.lblCNID.Size = new System.Drawing.Size(67, 23);
            this.lblCNID.TabIndex = 4;
            this.lblCNID.Text = "CNID:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(550, 149);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(203, 32);
            this.txtPhoneNo.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(108, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(396, 154);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(161, 23);
            this.lblPhoneNo.TabIndex = 5;
            this.lblPhoneNo.Text = "Phone Number:";
            // 
            // txtCNID
            // 
            this.txtCNID.Location = new System.Drawing.Point(550, 93);
            this.txtCNID.Name = "txtCNID";
            this.txtCNID.Size = new System.Drawing.Size(203, 32);
            this.txtCNID.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 32);
            this.txtName.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(480, 40);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(57, 23);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnCreateAccount.Location = new System.Drawing.Point(231, 412);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(184, 32);
            this.btnCreateAccount.TabIndex = 20;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click_1);
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateAccount";
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.grpStaffInfo.ResumeLayout(false);
            this.grpStaffInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpStaffInfo;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCNID;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtCNID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}