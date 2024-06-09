
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnForgerPassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertChinese = new System.Windows.Forms.Button();
            this.btnConvertEng = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
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
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(39, 73);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(1);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(277, 23);
            this.txtStaffID.TabIndex = 1;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
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
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(523, 62);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(193, 25);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "Legend Motor Ltd.";
            // 
            // lblSystem
            // 
            this.lblSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(381, 119);
            this.lblSystem.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(480, 25);
            this.lblSystem.TabIndex = 7;
            this.lblSystem.Text = "Order Processing and Stock Recording System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.grpLogin.Location = new System.Drawing.Point(631, 220);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(1);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(1);
            this.grpLogin.Size = new System.Drawing.Size(354, 307);
            this.grpLogin.TabIndex = 0;
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
            this.btnForgerPassword.Click += new System.EventHandler(this.btnForgerPassword_Click);
            // 
            // btnClose
            // 
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 694);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "© group2 2024";
            // 
            // btnConvertChinese
            // 
            this.btnConvertChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertChinese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConvertChinese.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertChinese.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvertChinese.Location = new System.Drawing.Point(818, 581);
            this.btnConvertChinese.Name = "btnConvertChinese";
            this.btnConvertChinese.Size = new System.Drawing.Size(81, 52);
            this.btnConvertChinese.TabIndex = 4;
            this.btnConvertChinese.Text = "簡中";
            this.btnConvertChinese.UseVisualStyleBackColor = false;
            this.btnConvertChinese.Click += new System.EventHandler(this.btnConvertChinese_Click);
            // 
            // btnConvertEng
            // 
            this.btnConvertEng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertEng.BackColor = System.Drawing.Color.White;
            this.btnConvertEng.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertEng.Location = new System.Drawing.Point(905, 581);
            this.btnConvertEng.Name = "btnConvertEng";
            this.btnConvertEng.Size = new System.Drawing.Size(80, 52);
            this.btnConvertEng.TabIndex = 12;
            this.btnConvertEng.Text = "ENG";
            this.btnConvertEng.UseVisualStyleBackColor = false;
            this.btnConvertEng.Click += new System.EventHandler(this.btnConvertEng_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 40);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConvertEng);
            this.Controls.Add(this.btnConvertChinese);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertChinese;
        private System.Windows.Forms.Button btnConvertEng;
        private System.Windows.Forms.Button btnForgerPassword;
        private System.Windows.Forms.Panel panel1;
    }
}

