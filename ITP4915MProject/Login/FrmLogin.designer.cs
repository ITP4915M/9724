
namespace ITP4915MProject
{
    partial class FrmLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnClose = new System.Windows.Forms.Button();
            this.removeableTopBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConvertEng = new System.Windows.Forms.Button();
            this.btnConvertChinese = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnForgerPassword = new System.Windows.Forms.Button();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.removeableTopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1134, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeableTopBar
            // 
            this.removeableTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.removeableTopBar.Controls.Add(this.btnClose);
            this.removeableTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeableTopBar.Location = new System.Drawing.Point(0, 0);
            this.removeableTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.removeableTopBar.Name = "removeableTopBar";
            this.removeableTopBar.Size = new System.Drawing.Size(1200, 40);
            this.removeableTopBar.TabIndex = 13;
            this.removeableTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.removeableTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.removeableTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConvertEng);
            this.panel1.Controls.Add(this.btnConvertChinese);
            this.panel1.Controls.Add(this.copyright);
            this.panel1.Controls.Add(this.grpLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSystem);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 680);
            this.panel1.TabIndex = 14;
            // 
            // btnConvertEng
            // 
            this.btnConvertEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertEng.BackColor = System.Drawing.Color.White;
            this.btnConvertEng.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertEng.Location = new System.Drawing.Point(926, 549);
            this.btnConvertEng.Name = "btnConvertEng";
            this.btnConvertEng.Size = new System.Drawing.Size(80, 52);
            this.btnConvertEng.TabIndex = 19;
            this.btnConvertEng.Text = "ENG";
            this.btnConvertEng.UseVisualStyleBackColor = false;
            // 
            // btnConvertChinese
            // 
            this.btnConvertChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertChinese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConvertChinese.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertChinese.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvertChinese.Location = new System.Drawing.Point(839, 549);
            this.btnConvertChinese.Name = "btnConvertChinese";
            this.btnConvertChinese.Size = new System.Drawing.Size(81, 52);
            this.btnConvertChinese.TabIndex = 14;
            this.btnConvertChinese.Text = "簡中";
            this.btnConvertChinese.UseVisualStyleBackColor = false;
            // 
            // copyright
            // 
            this.copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.copyright.Location = new System.Drawing.Point(60, 648);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(122, 21);
            this.copyright.TabIndex = 18;
            this.copyright.Text = "© group2 2024";
            // 
            // grpLogin
            // 
            this.grpLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpLogin.Controls.Add(this.btnForgerPassword);
            this.grpLogin.Controls.Add(this.lblStaffID);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtStaffID);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(652, 187);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(1);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(1);
            this.grpLogin.Size = new System.Drawing.Size(354, 307);
            this.grpLogin.TabIndex = 13;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login ";
            // 
            // btnForgerPassword
            // 
            this.btnForgerPassword.BackColor = System.Drawing.Color.White;
            this.btnForgerPassword.FlatAppearance.BorderSize = 0;
            this.btnForgerPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnForgerPassword.Location = new System.Drawing.Point(157, 202);
            this.btnForgerPassword.Name = "btnForgerPassword";
            this.btnForgerPassword.Size = new System.Drawing.Size(159, 31);
            this.btnForgerPassword.TabIndex = 13;
            this.btnForgerPassword.Text = "Forget Password?";
            this.btnForgerPassword.UseVisualStyleBackColor = false;
            this.btnForgerPassword.Click += new System.EventHandler(this.btnForgerPassword_Click_1);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(35, 43);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(63, 19);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(35, 120);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 19);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(39, 160);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(39, 73);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(1);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(277, 23);
            this.txtStaffID.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(39, 237);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(277, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 213);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblSystem
            // 
            this.lblSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(402, 85);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(480, 25);
            this.lblSystem.TabIndex = 16;
            this.lblSystem.Text = "Order Processing and Stock Recording System";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(544, 28);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(193, 25);
            this.lblCompany.TabIndex = 15;
            this.lblCompany.Text = "Legend Motor Ltd.";
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeableTopBar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.removeableTopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel removeableTopBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConvertEng;
        private System.Windows.Forms.Button btnConvertChinese;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnForgerPassword;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblCompany;
    }
}

