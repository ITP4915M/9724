﻿
namespace ITP4915MProject
{
    partial class FrmMainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.btn_SalesManagement = new System.Windows.Forms.Button();
            this.TopLeftpannel = new System.Windows.Forms.Panel();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.btnMeun = new System.Windows.Forms.Button();
            this.companyLogo = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnFrmDispatchNoteList = new System.Windows.Forms.Button();
            this.btnItemManagment = new System.Windows.Forms.Button();
            this.btnFrmItem = new System.Windows.Forms.Button();
            this.btnWorks = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.topRemovableBar = new System.Windows.Forms.Panel();
            this.LblData = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.Slidetimer1 = new System.Windows.Forms.Timer(this.components);
            this.SalseTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_OrderList = new System.Windows.Forms.Button();
            this.btn_CreateOrder = new System.Windows.Forms.Button();
            this.SalesContainer = new System.Windows.Forms.Panel();
            this.btn_draft = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.TopLeftpannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.topRemovableBar.SuspendLayout();
            this.SalesContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SalesManagement
            // 
            this.btn_SalesManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btn_SalesManagement.FlatAppearance.BorderSize = 0;
            this.btn_SalesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalesManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalesManagement.ForeColor = System.Drawing.Color.White;
            this.btn_SalesManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalesManagement.Image")));
            this.btn_SalesManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SalesManagement.Location = new System.Drawing.Point(0, 0);
            this.btn_SalesManagement.MaximumSize = new System.Drawing.Size(294, 45);
            this.btn_SalesManagement.MinimumSize = new System.Drawing.Size(294, 45);
            this.btn_SalesManagement.Name = "btn_SalesManagement";
            this.btn_SalesManagement.Size = new System.Drawing.Size(294, 45);
            this.btn_SalesManagement.TabIndex = 1;
            this.btn_SalesManagement.Text = "     Sales Management";
            this.btn_SalesManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalesManagement.UseVisualStyleBackColor = false;
            this.btn_SalesManagement.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // TopLeftpannel
            // 
            this.TopLeftpannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.TopLeftpannel.Controls.Add(this.lblSystemName);
            this.TopLeftpannel.Controls.Add(this.btnMeun);
            this.TopLeftpannel.Controls.Add(this.companyLogo);
            this.TopLeftpannel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftpannel.Margin = new System.Windows.Forms.Padding(0);
            this.TopLeftpannel.Name = "TopLeftpannel";
            this.TopLeftpannel.Size = new System.Drawing.Size(294, 149);
            this.TopLeftpannel.TabIndex = 0;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(36, 74);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(254, 60);
            this.lblSystemName.TabIndex = 14;
            this.lblSystemName.Text = "Order Processing and Stock Recording System";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMeun
            // 
            this.btnMeun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeun.FlatAppearance.BorderSize = 0;
            this.btnMeun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeun.ForeColor = System.Drawing.Color.White;
            this.btnMeun.Image = ((System.Drawing.Image)(resources.GetObject("btnMeun.Image")));
            this.btnMeun.Location = new System.Drawing.Point(-2, 0);
            this.btnMeun.Name = "btnMeun";
            this.btnMeun.Size = new System.Drawing.Size(46, 44);
            this.btnMeun.TabIndex = 1;
            this.btnMeun.UseVisualStyleBackColor = true;
            this.btnMeun.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyLogo
            // 
            this.companyLogo.Image = ((System.Drawing.Image)(resources.GetObject("companyLogo.Image")));
            this.companyLogo.Location = new System.Drawing.Point(105, 10);
            this.companyLogo.Name = "companyLogo";
            this.companyLogo.Size = new System.Drawing.Size(72, 58);
            this.companyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogo.TabIndex = 13;
            this.companyLogo.TabStop = false;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(3, 152);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(280, 44);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "     Stock Record";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnFrmDispatchNoteList
            // 
            this.btnFrmDispatchNoteList.FlatAppearance.BorderSize = 0;
            this.btnFrmDispatchNoteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmDispatchNoteList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmDispatchNoteList.ForeColor = System.Drawing.Color.White;
            this.btnFrmDispatchNoteList.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmDispatchNoteList.Image")));
            this.btnFrmDispatchNoteList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmDispatchNoteList.Location = new System.Drawing.Point(3, 302);
            this.btnFrmDispatchNoteList.Name = "btnFrmDispatchNoteList";
            this.btnFrmDispatchNoteList.Size = new System.Drawing.Size(280, 44);
            this.btnFrmDispatchNoteList.TabIndex = 1;
            this.btnFrmDispatchNoteList.Text = "     DispatchNoteList";
            this.btnFrmDispatchNoteList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmDispatchNoteList.UseVisualStyleBackColor = true;
            this.btnFrmDispatchNoteList.Click += new System.EventHandler(this.btnStockRecord_Click);
            // 
            // btnItemManagment
            // 
            this.btnItemManagment.FlatAppearance.BorderSize = 0;
            this.btnItemManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemManagment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManagment.ForeColor = System.Drawing.Color.White;
            this.btnItemManagment.Image = ((System.Drawing.Image)(resources.GetObject("btnItemManagment.Image")));
            this.btnItemManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemManagment.Location = new System.Drawing.Point(3, 202);
            this.btnItemManagment.Name = "btnItemManagment";
            this.btnItemManagment.Size = new System.Drawing.Size(280, 44);
            this.btnItemManagment.TabIndex = 1;
            this.btnItemManagment.Text = "     Inventory";
            this.btnItemManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemManagment.UseVisualStyleBackColor = true;
            this.btnItemManagment.Click += new System.EventHandler(this.btnItemManagment_Click);
            // 
            // btnFrmItem
            // 
            this.btnFrmItem.FlatAppearance.BorderSize = 0;
            this.btnFrmItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmItem.ForeColor = System.Drawing.Color.White;
            this.btnFrmItem.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmItem.Image")));
            this.btnFrmItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmItem.Location = new System.Drawing.Point(3, 352);
            this.btnFrmItem.Name = "btnFrmItem";
            this.btnFrmItem.Size = new System.Drawing.Size(280, 44);
            this.btnFrmItem.TabIndex = 1;
            this.btnFrmItem.Text = "     ItemList";
            this.btnFrmItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFrmItem.UseVisualStyleBackColor = true;
            this.btnFrmItem.Click += new System.EventHandler(this.btnFrmItem_Click);
            // 
            // btnWorks
            // 
            this.btnWorks.FlatAppearance.BorderSize = 0;
            this.btnWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorks.ForeColor = System.Drawing.Color.White;
            this.btnWorks.Image = ((System.Drawing.Image)(resources.GetObject("btnWorks.Image")));
            this.btnWorks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorks.Location = new System.Drawing.Point(3, 252);
            this.btnWorks.Name = "btnWorks";
            this.btnWorks.Size = new System.Drawing.Size(280, 44);
            this.btnWorks.TabIndex = 1;
            this.btnWorks.Text = "     Invoice Management";
            this.btnWorks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorks.UseVisualStyleBackColor = true;
            this.btnWorks.Click += new System.EventHandler(this.btnWorks_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblRole);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1452, 110);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(749, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Role:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(915, 47);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(62, 19);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(412, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 33);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Home Page";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(904, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(120, 19);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "SaLaaR HuSyN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(749, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Staff ID:";
            // 
            // topRemovableBar
            // 
            this.topRemovableBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.topRemovableBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.topRemovableBar.Controls.Add(this.LblData);
            this.topRemovableBar.Controls.Add(this.lblTime);
            this.topRemovableBar.Controls.Add(this.btnCancel);
            this.topRemovableBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRemovableBar.ForeColor = System.Drawing.Color.White;
            this.topRemovableBar.Location = new System.Drawing.Point(0, 0);
            this.topRemovableBar.Name = "topRemovableBar";
            this.topRemovableBar.Size = new System.Drawing.Size(1200, 39);
            this.topRemovableBar.TabIndex = 4;
            this.topRemovableBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.topRemovableBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.Color.White;
            this.LblData.Location = new System.Drawing.Point(736, 9);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(131, 19);
            this.LblData.TabIndex = 9;
            this.LblData.Text = "WKD,MMD,YYYY";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(414, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(143, 19);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "HH:MM:SS AM/PM";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1143, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Slidetimer1
            // 
            this.Slidetimer1.Interval = 10;
            this.Slidetimer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SalseTimer
            // 
            this.SalseTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // btn_OrderList
            // 
            this.btn_OrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.btn_OrderList.FlatAppearance.BorderSize = 0;
            this.btn_OrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderList.ForeColor = System.Drawing.Color.White;
            this.btn_OrderList.Image = ((System.Drawing.Image)(resources.GetObject("btn_OrderList.Image")));
            this.btn_OrderList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrderList.Location = new System.Drawing.Point(0, 45);
            this.btn_OrderList.Name = "btn_OrderList";
            this.btn_OrderList.Size = new System.Drawing.Size(298, 45);
            this.btn_OrderList.TabIndex = 2;
            this.btn_OrderList.Text = "     Order List";
            this.btn_OrderList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OrderList.UseVisualStyleBackColor = false;
            this.btn_OrderList.Click += new System.EventHandler(this.btn_OrderList_Click);
            // 
            // btn_CreateOrder
            // 
            this.btn_CreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.btn_CreateOrder.FlatAppearance.BorderSize = 0;
            this.btn_CreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateOrder.ForeColor = System.Drawing.Color.White;
            this.btn_CreateOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreateOrder.Image")));
            this.btn_CreateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateOrder.Location = new System.Drawing.Point(0, 90);
            this.btn_CreateOrder.Name = "btn_CreateOrder";
            this.btn_CreateOrder.Size = new System.Drawing.Size(298, 45);
            this.btn_CreateOrder.TabIndex = 3;
            this.btn_CreateOrder.Text = "     Create Order";
            this.btn_CreateOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateOrder.UseVisualStyleBackColor = false;
            this.btn_CreateOrder.Click += new System.EventHandler(this.btn_CreateOrder_Click);
            // 
            // SalesContainer
            // 
            this.SalesContainer.Controls.Add(this.btn_draft);
            this.SalesContainer.Controls.Add(this.btn_SalesManagement);
            this.SalesContainer.Controls.Add(this.btn_OrderList);
            this.SalesContainer.Controls.Add(this.btn_CreateOrder);
            this.SalesContainer.Location = new System.Drawing.Point(228, 271);
            this.SalesContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SalesContainer.MaximumSize = new System.Drawing.Size(310, 180);
            this.SalesContainer.MinimumSize = new System.Drawing.Size(310, 45);
            this.SalesContainer.Name = "SalesContainer";
            this.SalesContainer.Size = new System.Drawing.Size(310, 180);
            this.SalesContainer.TabIndex = 2;
            // 
            // btn_draft
            // 
            this.btn_draft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(70)))));
            this.btn_draft.FlatAppearance.BorderSize = 0;
            this.btn_draft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_draft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_draft.ForeColor = System.Drawing.Color.White;
            this.btn_draft.Image = ((System.Drawing.Image)(resources.GetObject("btn_draft.Image")));
            this.btn_draft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_draft.Location = new System.Drawing.Point(0, 135);
            this.btn_draft.Name = "btn_draft";
            this.btn_draft.Size = new System.Drawing.Size(298, 45);
            this.btn_draft.TabIndex = 4;
            this.btn_draft.Text = "     Draft";
            this.btn_draft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_draft.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLeft.Controls.Add(this.TopLeftpannel);
            this.panelLeft.Controls.Add(this.btnInventory);
            this.panelLeft.Controls.Add(this.btnItemManagment);
            this.panelLeft.Controls.Add(this.btnWorks);
            this.panelLeft.Controls.Add(this.btnFrmDispatchNoteList);
            this.panelLeft.Controls.Add(this.btnFrmItem);
            this.panelLeft.Controls.Add(this.btn_Account);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 39);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(298, 742);
            this.panelLeft.TabIndex = 6;
            // 
            // btn_Account
            // 
            this.btn_Account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(3, 402);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(280, 44);
            this.btn_Account.TabIndex = 7;
            this.btn_Account.Text = "     Account";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(298, 781);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(902, 0);
            this.panelContainer.TabIndex = 7;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.SalesContainer);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMain.ForeColor = System.Drawing.Color.White;
            this.panMain.Location = new System.Drawing.Point(298, 36);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(902, 745);
            this.panMain.TabIndex = 8;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
            // 
            // FrmMainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 781);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.topRemovableBar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.TopLeftpannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.topRemovableBar.ResumeLayout(false);
            this.topRemovableBar.PerformLayout();
            this.SalesContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFrmDispatchNoteList;
        private System.Windows.Forms.Button btnFrmItem;
        private System.Windows.Forms.Button btnWorks;
        private System.Windows.Forms.Button btnItemManagment;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btn_SalesManagement;
        private System.Windows.Forms.Panel TopLeftpannel;
        private System.Windows.Forms.Button btnMeun;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.PictureBox companyLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel topRemovableBar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer Slidetimer1;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Timer SalseTimer;
        private System.Windows.Forms.Button btn_OrderList;
        private System.Windows.Forms.Button btn_CreateOrder;
        private System.Windows.Forms.Panel SalesContainer;
        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private System.Windows.Forms.Button btn_draft;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Panel panMain;
    }
}