﻿namespace Main
{
	// Token: 0x0200000D RID: 13
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00007490 File Offset: 0x00005690
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000074C8 File Offset: 0x000056C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::BunifuAnimatorNS.Animation animation6 = new global::BunifuAnimatorNS.Animation();
			global::BunifuAnimatorNS.Animation animation7 = new global::BunifuAnimatorNS.Animation();
			global::BunifuAnimatorNS.Animation animation8 = new global::BunifuAnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Main.Main));
			this.MainEclipse = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.sideBar = new global::System.Windows.Forms.Panel();
			this.productsPanel = new global::System.Windows.Forms.Panel();
			this.Notification = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.memberUsername = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.memberAvatar = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.slidingPanel = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.topBar = new global::System.Windows.Forms.Panel();
			this.SupportTicketsNumber = new global::System.Windows.Forms.Label();
			this.NewsfeedNumber = new global::System.Windows.Forms.Label();
			this.NotificationsNumber = new global::System.Windows.Forms.Label();
			this.NewsfeedImage = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.headerPicture = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.SupportTicketsImage = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.NotificationsImage = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.ShowLogs = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.loading = new global::System.Windows.Forms.PictureBox();
			this.dropdownPanel = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.flowLayoutPanel3 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.launchButton = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.requestFailed = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuTransition3 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.dropdownEclipse = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuTransition1 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.bunifuTransition2 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.NewsfeedList = new global::CustomTheme.CustomListBox();
			this.NotificationList = new global::CustomTheme.CustomListBox();
			this.SupportTicketList = new global::CustomTheme.CustomListBox();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.sideBar.SuspendLayout();
			this.productsPanel.SuspendLayout();
			this.memberAvatar.BeginInit();
			this.slidingPanel.BeginInit();
			this.topBar.SuspendLayout();
			this.NewsfeedImage.BeginInit();
			this.headerPicture.BeginInit();
			this.SupportTicketsImage.BeginInit();
			this.NotificationsImage.BeginInit();
			this.bunifuImageButton1.BeginInit();
			this.ShowLogs.BeginInit();
			this.MainPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.loading).BeginInit();
			this.dropdownPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.MainEclipse.ElipseRadius = 5;
			this.MainEclipse.TargetControl = this;
			this.sideBar.BackColor = global::System.Drawing.Color.FromArgb(30, 37, 47);
			this.sideBar.Controls.Add(this.productsPanel);
			this.sideBar.Controls.Add(this.memberUsername);
			this.sideBar.Controls.Add(this.memberAvatar);
			this.sideBar.Controls.Add(this.slidingPanel);
			this.bunifuTransition3.SetDecoration(this.sideBar, 0);
			this.bunifuTransition1.SetDecoration(this.sideBar, 0);
			this.bunifuTransition2.SetDecoration(this.sideBar, 0);
			this.sideBar.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.sideBar.ForeColor = global::System.Drawing.Color.FromArgb(30, 37, 47);
			this.sideBar.Location = new global::System.Drawing.Point(0, 0);
			this.sideBar.Margin = new global::System.Windows.Forms.Padding(2);
			this.sideBar.Name = "sideBar";
			this.sideBar.Size = new global::System.Drawing.Size(300, 550);
			this.sideBar.TabIndex = 0;
			this.productsPanel.BackColor = global::System.Drawing.Color.FromArgb(30, 37, 47);
			this.productsPanel.Controls.Add(this.Notification);
			this.productsPanel.Controls.Add(this.flowLayoutPanel1);
			this.bunifuTransition3.SetDecoration(this.productsPanel, 0);
			this.bunifuTransition1.SetDecoration(this.productsPanel, 0);
			this.bunifuTransition2.SetDecoration(this.productsPanel, 0);
			this.productsPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.productsPanel.Location = new global::System.Drawing.Point(0, 150);
			this.productsPanel.Name = "productsPanel";
			this.productsPanel.Size = new global::System.Drawing.Size(300, 400);
			this.productsPanel.TabIndex = 9;
			this.Notification.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.bunifuTransition2.SetDecoration(this.Notification, 0);
			this.bunifuTransition1.SetDecoration(this.Notification, 0);
			this.bunifuTransition3.SetDecoration(this.Notification, 0);
			this.Notification.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Notification.ForeColor = global::System.Drawing.Color.White;
			this.Notification.Location = new global::System.Drawing.Point(0, 360);
			this.Notification.Name = "Notification";
			this.Notification.Size = new global::System.Drawing.Size(297, 40);
			this.Notification.TabIndex = 102;
			this.Notification.Text = "Notification Message";
			this.Notification.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Notification.Visible = false;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bunifuTransition2.SetDecoration(this.flowLayoutPanel1, 0);
			this.bunifuTransition1.SetDecoration(this.flowLayoutPanel1, 0);
			this.bunifuTransition3.SetDecoration(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(0, 0);
			this.flowLayoutPanel1.TabIndex = 3;
			this.memberUsername.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition2.SetDecoration(this.memberUsername, 0);
			this.bunifuTransition1.SetDecoration(this.memberUsername, 0);
			this.bunifuTransition3.SetDecoration(this.memberUsername, 0);
			this.memberUsername.Font = new global::System.Drawing.Font("Calibri", 14f);
			this.memberUsername.ForeColor = global::System.Drawing.Color.White;
			this.memberUsername.Location = new global::System.Drawing.Point(69, 105);
			this.memberUsername.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.memberUsername.Name = "memberUsername";
			this.memberUsername.Size = new global::System.Drawing.Size(148, 28);
			this.memberUsername.TabIndex = 7;
			this.memberUsername.Text = "Username";
			this.memberUsername.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.memberAvatar.BackColor = global::System.Drawing.Color.Transparent;
			this.memberAvatar.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.memberAvatar, 0);
			this.bunifuTransition1.SetDecoration(this.memberAvatar, 0);
			this.bunifuTransition2.SetDecoration(this.memberAvatar, 0);
			this.memberAvatar.Image = (global::System.Drawing.Image)resources.GetObject("memberAvatar.Image");
			this.memberAvatar.ImageActive = null;
			this.memberAvatar.Location = new global::System.Drawing.Point(96, 12);
			this.memberAvatar.Name = "memberAvatar";
			this.memberAvatar.Size = new global::System.Drawing.Size(90, 90);
			this.memberAvatar.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.memberAvatar.TabIndex = 8;
			this.memberAvatar.TabStop = false;
			this.memberAvatar.Zoom = 10;
			this.memberAvatar.Click += new global::System.EventHandler(this.memberAvatar_Click);
			this.slidingPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.slidingPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition3.SetDecoration(this.slidingPanel, 0);
			this.bunifuTransition1.SetDecoration(this.slidingPanel, 0);
			this.bunifuTransition2.SetDecoration(this.slidingPanel, 0);
			this.slidingPanel.Image = (global::System.Drawing.Image)resources.GetObject("slidingPanel.Image");
			this.slidingPanel.ImageActive = null;
			this.slidingPanel.Location = new global::System.Drawing.Point(263, 7);
			this.slidingPanel.Margin = new global::System.Windows.Forms.Padding(2);
			this.slidingPanel.Name = "slidingPanel";
			this.slidingPanel.Size = new global::System.Drawing.Size(27, 26);
			this.slidingPanel.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.slidingPanel.TabIndex = 0;
			this.slidingPanel.TabStop = false;
			this.slidingPanel.Zoom = 10;
			this.slidingPanel.Click += new global::System.EventHandler(this.slidingPanel_Click);
			this.topBar.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.topBar.Controls.Add(this.SupportTicketsNumber);
			this.topBar.Controls.Add(this.NewsfeedNumber);
			this.topBar.Controls.Add(this.NotificationsNumber);
			this.topBar.Controls.Add(this.NewsfeedImage);
			this.topBar.Controls.Add(this.headerPicture);
			this.topBar.Controls.Add(this.SupportTicketsImage);
			this.topBar.Controls.Add(this.NotificationsImage);
			this.topBar.Controls.Add(this.bunifuImageButton1);
			this.topBar.Controls.Add(this.ShowLogs);
			this.bunifuTransition3.SetDecoration(this.topBar, 0);
			this.bunifuTransition1.SetDecoration(this.topBar, 0);
			this.bunifuTransition2.SetDecoration(this.topBar, 0);
			this.topBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.topBar.Location = new global::System.Drawing.Point(300, 0);
			this.topBar.Margin = new global::System.Windows.Forms.Padding(2);
			this.topBar.Name = "topBar";
			this.topBar.Size = new global::System.Drawing.Size(650, 40);
			this.topBar.TabIndex = 1;
			this.topBar.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
			this.topBar.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
			this.SupportTicketsNumber.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SupportTicketsNumber.AutoSize = true;
			this.SupportTicketsNumber.BackColor = global::System.Drawing.Color.Red;
			this.bunifuTransition2.SetDecoration(this.SupportTicketsNumber, 0);
			this.bunifuTransition1.SetDecoration(this.SupportTicketsNumber, 0);
			this.bunifuTransition3.SetDecoration(this.SupportTicketsNumber, 0);
			this.SupportTicketsNumber.ForeColor = global::System.Drawing.SystemColors.Control;
			this.SupportTicketsNumber.Location = new global::System.Drawing.Point(604, 2);
			this.SupportTicketsNumber.Name = "SupportTicketsNumber";
			this.SupportTicketsNumber.Size = new global::System.Drawing.Size(13, 13);
			this.SupportTicketsNumber.TabIndex = 28;
			this.SupportTicketsNumber.Text = "1";
			this.SupportTicketsNumber.Visible = false;
			this.NewsfeedNumber.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.NewsfeedNumber.AutoSize = true;
			this.NewsfeedNumber.BackColor = global::System.Drawing.Color.Red;
			this.bunifuTransition2.SetDecoration(this.NewsfeedNumber, 0);
			this.bunifuTransition1.SetDecoration(this.NewsfeedNumber, 0);
			this.bunifuTransition3.SetDecoration(this.NewsfeedNumber, 0);
			this.NewsfeedNumber.ForeColor = global::System.Drawing.SystemColors.Control;
			this.NewsfeedNumber.Location = new global::System.Drawing.Point(534, 2);
			this.NewsfeedNumber.Name = "NewsfeedNumber";
			this.NewsfeedNumber.Size = new global::System.Drawing.Size(13, 13);
			this.NewsfeedNumber.TabIndex = 31;
			this.NewsfeedNumber.Text = "1";
			this.NewsfeedNumber.Visible = false;
			this.NotificationsNumber.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.NotificationsNumber.AutoSize = true;
			this.NotificationsNumber.BackColor = global::System.Drawing.Color.Red;
			this.bunifuTransition2.SetDecoration(this.NotificationsNumber, 0);
			this.bunifuTransition1.SetDecoration(this.NotificationsNumber, 0);
			this.bunifuTransition3.SetDecoration(this.NotificationsNumber, 0);
			this.NotificationsNumber.ForeColor = global::System.Drawing.SystemColors.Control;
			this.NotificationsNumber.Location = new global::System.Drawing.Point(569, 2);
			this.NotificationsNumber.Name = "NotificationsNumber";
			this.NotificationsNumber.Size = new global::System.Drawing.Size(13, 13);
			this.NotificationsNumber.TabIndex = 26;
			this.NotificationsNumber.Text = "1";
			this.NotificationsNumber.Visible = false;
			this.NewsfeedImage.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.NewsfeedImage.BackColor = global::System.Drawing.Color.Transparent;
			this.NewsfeedImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.NewsfeedImage, 0);
			this.bunifuTransition1.SetDecoration(this.NewsfeedImage, 0);
			this.bunifuTransition2.SetDecoration(this.NewsfeedImage, 0);
			this.NewsfeedImage.Image = (global::System.Drawing.Image)resources.GetObject("NewsfeedImage.Image");
			this.NewsfeedImage.ImageActive = null;
			this.NewsfeedImage.Location = new global::System.Drawing.Point(511, 5);
			this.NewsfeedImage.Margin = new global::System.Windows.Forms.Padding(2);
			this.NewsfeedImage.Name = "NewsfeedImage";
			this.NewsfeedImage.Size = new global::System.Drawing.Size(30, 30);
			this.NewsfeedImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.NewsfeedImage.TabIndex = 30;
			this.NewsfeedImage.TabStop = false;
			this.NewsfeedImage.Zoom = 10;
			this.NewsfeedImage.Click += new global::System.EventHandler(this.NewsfeedImage_Click);
			this.headerPicture.BackColor = global::System.Drawing.Color.Transparent;
			this.headerPicture.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.headerPicture, 0);
			this.bunifuTransition1.SetDecoration(this.headerPicture, 0);
			this.bunifuTransition2.SetDecoration(this.headerPicture, 0);
			this.headerPicture.Image = (global::System.Drawing.Image)resources.GetObject("headerPicture.Image");
			this.headerPicture.ImageActive = null;
			this.headerPicture.Location = new global::System.Drawing.Point(10, 0);
			this.headerPicture.Margin = new global::System.Windows.Forms.Padding(2);
			this.headerPicture.Name = "headerPicture";
			this.headerPicture.Size = new global::System.Drawing.Size(210, 40);
			this.headerPicture.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.headerPicture.TabIndex = 29;
			this.headerPicture.TabStop = false;
			this.headerPicture.Zoom = 10;
			this.headerPicture.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.headerPicture_MouseDown);
			this.headerPicture.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.headerPicture_MouseMove);
			this.SupportTicketsImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SupportTicketsImage.BackColor = global::System.Drawing.Color.Transparent;
			this.SupportTicketsImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.SupportTicketsImage, 0);
			this.bunifuTransition1.SetDecoration(this.SupportTicketsImage, 0);
			this.bunifuTransition2.SetDecoration(this.SupportTicketsImage, 0);
			this.SupportTicketsImage.Image = (global::System.Drawing.Image)resources.GetObject("SupportTicketsImage.Image");
			this.SupportTicketsImage.ImageActive = null;
			this.SupportTicketsImage.Location = new global::System.Drawing.Point(581, 5);
			this.SupportTicketsImage.Margin = new global::System.Windows.Forms.Padding(2);
			this.SupportTicketsImage.Name = "SupportTicketsImage";
			this.SupportTicketsImage.Size = new global::System.Drawing.Size(30, 30);
			this.SupportTicketsImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SupportTicketsImage.TabIndex = 27;
			this.SupportTicketsImage.TabStop = false;
			this.SupportTicketsImage.Zoom = 10;
			this.SupportTicketsImage.Click += new global::System.EventHandler(this.SupportTicketsImage_Click);
			this.NotificationsImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.NotificationsImage.BackColor = global::System.Drawing.Color.Transparent;
			this.NotificationsImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.NotificationsImage, 0);
			this.bunifuTransition1.SetDecoration(this.NotificationsImage, 0);
			this.bunifuTransition2.SetDecoration(this.NotificationsImage, 0);
			this.NotificationsImage.Image = (global::System.Drawing.Image)resources.GetObject("NotificationsImage.Image");
			this.NotificationsImage.ImageActive = null;
			this.NotificationsImage.Location = new global::System.Drawing.Point(546, 5);
			this.NotificationsImage.Margin = new global::System.Windows.Forms.Padding(2);
			this.NotificationsImage.Name = "NotificationsImage";
			this.NotificationsImage.Size = new global::System.Drawing.Size(30, 30);
			this.NotificationsImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.NotificationsImage.TabIndex = 25;
			this.NotificationsImage.TabStop = false;
			this.NotificationsImage.Zoom = 10;
			this.NotificationsImage.Click += new global::System.EventHandler(this.NotificationsImage_Click);
			this.bunifuImageButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuImageButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.bunifuImageButton1, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, 0);
			this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, 0);
			this.bunifuImageButton1.Image = (global::System.Drawing.Image)resources.GetObject("bunifuImageButton1.Image");
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new global::System.Drawing.Point(616, 5);
			this.bunifuImageButton1.Margin = new global::System.Windows.Forms.Padding(2);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new global::System.Drawing.Size(30, 30);
			this.bunifuImageButton1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 24;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new global::System.EventHandler(this.bunifuImageButton1_Click);
			this.ShowLogs.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.ShowLogs.BackColor = global::System.Drawing.Color.Transparent;
			this.ShowLogs.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.ShowLogs, 0);
			this.bunifuTransition1.SetDecoration(this.ShowLogs, 0);
			this.bunifuTransition2.SetDecoration(this.ShowLogs, 0);
			this.ShowLogs.Image = (global::System.Drawing.Image)resources.GetObject("ShowLogs.Image");
			this.ShowLogs.ImageActive = null;
			this.ShowLogs.Location = new global::System.Drawing.Point(472, 5);
			this.ShowLogs.Margin = new global::System.Windows.Forms.Padding(2);
			this.ShowLogs.Name = "ShowLogs";
			this.ShowLogs.Size = new global::System.Drawing.Size(31, 30);
			this.ShowLogs.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ShowLogs.TabIndex = 22;
			this.ShowLogs.TabStop = false;
			this.ShowLogs.Zoom = 10;
			this.ShowLogs.Click += new global::System.EventHandler(this.ShowLogs_Click);
			this.MainPanel.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.MainPanel.Controls.Add(this.loading);
			this.MainPanel.Controls.Add(this.dropdownPanel);
			this.MainPanel.Controls.Add(this.panel1);
			this.MainPanel.Controls.Add(this.launchButton);
			this.MainPanel.Controls.Add(this.requestFailed);
			this.bunifuTransition3.SetDecoration(this.MainPanel, 0);
			this.bunifuTransition1.SetDecoration(this.MainPanel, 0);
			this.bunifuTransition2.SetDecoration(this.MainPanel, 0);
			this.MainPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new global::System.Drawing.Point(300, 40);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new global::System.Drawing.Size(650, 510);
			this.MainPanel.TabIndex = 7;
			this.loading.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.loading.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition2.SetDecoration(this.loading, 0);
			this.bunifuTransition1.SetDecoration(this.loading, 0);
			this.bunifuTransition3.SetDecoration(this.loading, 0);
			this.loading.Location = new global::System.Drawing.Point(610, 0);
			this.loading.Name = "loading";
			this.loading.Size = new global::System.Drawing.Size(40, 40);
			this.loading.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.loading.TabIndex = 21;
			this.loading.TabStop = false;
			this.loading.Visible = false;
			this.dropdownPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.dropdownPanel.BackColor = global::System.Drawing.Color.FromArgb(35, 40, 50);
			this.dropdownPanel.Controls.Add(this.NewsfeedList);
			this.dropdownPanel.Controls.Add(this.NotificationList);
			this.dropdownPanel.Controls.Add(this.SupportTicketList);
			this.dropdownPanel.Controls.Add(this.label2);
			this.dropdownPanel.Controls.Add(this.flowLayoutPanel3);
			this.bunifuTransition3.SetDecoration(this.dropdownPanel, 0);
			this.bunifuTransition1.SetDecoration(this.dropdownPanel, 0);
			this.bunifuTransition2.SetDecoration(this.dropdownPanel, 0);
			this.dropdownPanel.Location = new global::System.Drawing.Point(350, 0);
			this.dropdownPanel.Name = "dropdownPanel";
			this.dropdownPanel.Size = new global::System.Drawing.Size(300, 375);
			this.dropdownPanel.TabIndex = 10;
			this.dropdownPanel.Visible = false;
			this.label2.AutoSize = true;
			this.bunifuTransition2.SetDecoration(this.label2, 0);
			this.bunifuTransition1.SetDecoration(this.label2, 0);
			this.bunifuTransition3.SetDecoration(this.label2, 0);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 2);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(98, 17);
			this.label2.TabIndex = 143;
			this.label2.Text = "Notifications";
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bunifuTransition2.SetDecoration(this.flowLayoutPanel3, 0);
			this.bunifuTransition1.SetDecoration(this.flowLayoutPanel3, 0);
			this.bunifuTransition3.SetDecoration(this.flowLayoutPanel3, 0);
			this.flowLayoutPanel3.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel3.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new global::System.Drawing.Size(0, 0);
			this.flowLayoutPanel3.TabIndex = 3;
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(38, 48, 61);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.flowLayoutPanel2);
			this.bunifuTransition3.SetDecoration(this.panel1, 0);
			this.bunifuTransition1.SetDecoration(this.panel1, 0);
			this.bunifuTransition2.SetDecoration(this.panel1, 0);
			this.panel1.ForeColor = global::System.Drawing.Color.White;
			this.panel1.Location = new global::System.Drawing.Point(350, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(300, 375);
			this.panel1.TabIndex = 22;
			this.panel1.Visible = false;
			this.label3.AutoSize = true;
			this.bunifuTransition2.SetDecoration(this.label3, 0);
			this.bunifuTransition1.SetDecoration(this.label3, 0);
			this.bunifuTransition3.SetDecoration(this.label3, 0);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 4);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(78, 17);
			this.label3.TabIndex = 145;
			this.label3.Text = "Newsfeed";
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.bunifuTransition2.SetDecoration(this.flowLayoutPanel2, 0);
			this.bunifuTransition1.SetDecoration(this.flowLayoutPanel2, 0);
			this.bunifuTransition3.SetDecoration(this.flowLayoutPanel2, 0);
			this.flowLayoutPanel2.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new global::System.Drawing.Size(0, 0);
			this.flowLayoutPanel2.TabIndex = 3;
			this.launchButton.ActiveBorderThickness = 1;
			this.launchButton.ActiveCornerRadius = 30;
			this.launchButton.ActiveFillColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.launchButton.ActiveForecolor = global::System.Drawing.Color.White;
			this.launchButton.ActiveLineColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.launchButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.launchButton.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.launchButton.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("launchButton.BackgroundImage");
			this.launchButton.ButtonText = "Launch";
			this.launchButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition3.SetDecoration(this.launchButton, 0);
			this.bunifuTransition2.SetDecoration(this.launchButton, 0);
			this.bunifuTransition1.SetDecoration(this.launchButton, 0);
			this.launchButton.Font = new global::System.Drawing.Font("Corbel", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.launchButton.ForeColor = global::System.Drawing.Color.White;
			this.launchButton.IdleBorderThickness = 1;
			this.launchButton.IdleCornerRadius = 30;
			this.launchButton.IdleFillColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.launchButton.IdleForecolor = global::System.Drawing.Color.White;
			this.launchButton.IdleLineColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.launchButton.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.launchButton.Location = new global::System.Drawing.Point(525, 445);
			this.launchButton.Margin = new global::System.Windows.Forms.Padding(0);
			this.launchButton.Name = "launchButton";
			this.launchButton.Size = new global::System.Drawing.Size(112, 52);
			this.launchButton.TabIndex = 6;
			this.launchButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.launchButton.Click += new global::System.EventHandler(this.launchButton_Click);
			this.requestFailed.BackColor = global::System.Drawing.Color.Red;
			this.bunifuTransition2.SetDecoration(this.requestFailed, 0);
			this.bunifuTransition1.SetDecoration(this.requestFailed, 0);
			this.bunifuTransition3.SetDecoration(this.requestFailed, 0);
			this.requestFailed.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.requestFailed.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.requestFailed.ForeColor = global::System.Drawing.Color.White;
			this.requestFailed.Location = new global::System.Drawing.Point(0, 470);
			this.requestFailed.Name = "requestFailed";
			this.requestFailed.Size = new global::System.Drawing.Size(650, 40);
			this.requestFailed.TabIndex = 20;
			this.requestFailed.Text = "Request Failed";
			this.requestFailed.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.requestFailed.Visible = false;
			this.requestFailed.VisibleChanged += new global::System.EventHandler(this.requestFailed_VisibleChanged);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.topBar;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuTransition3.AnimationType = 5;
			this.bunifuTransition3.Cursor = null;
			animation6.AnimateOnlyDifferences = true;
			animation6.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation6.BlindCoeff");
			animation6.LeafCoeff = 0f;
			animation6.MaxTime = 1f;
			animation6.MinTime = 0f;
			animation6.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation6.MosaicCoeff");
			animation6.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation6.MosaicShift");
			animation6.MosaicSize = 0;
			animation6.Padding = new global::System.Windows.Forms.Padding(30);
			animation6.RotateCoeff = 0.5f;
			animation6.RotateLimit = 0.2f;
			animation6.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation6.ScaleCoeff");
			animation6.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation6.SlideCoeff");
			animation6.TimeCoeff = 0f;
			animation6.TransparencyCoeff = 0f;
			this.bunifuTransition3.DefaultAnimation = animation6;
			this.bunifuTransition3.Interval = 1;
			this.bunifuTransition3.MaxAnimationTime = 5000;
			this.bunifuTransition3.TimeStep = 0.01f;
			this.dropdownEclipse.ElipseRadius = 5;
			this.dropdownEclipse.TargetControl = this.dropdownPanel;
			this.bunifuTransition1.AnimationType = 11;
			this.bunifuTransition1.Cursor = null;
			animation7.AnimateOnlyDifferences = true;
			animation7.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation5.BlindCoeff");
			animation7.LeafCoeff = 0f;
			animation7.MaxTime = 1f;
			animation7.MinTime = 0f;
			animation7.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation5.MosaicCoeff");
			animation7.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation5.MosaicShift");
			animation7.MosaicSize = 1;
			animation7.Padding = new global::System.Windows.Forms.Padding(100, 50, 100, 150);
			animation7.RotateCoeff = 0f;
			animation7.RotateLimit = 0f;
			animation7.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation5.ScaleCoeff");
			animation7.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation5.SlideCoeff");
			animation7.TimeCoeff = 2f;
			animation7.TransparencyCoeff = 0f;
			this.bunifuTransition1.DefaultAnimation = animation7;
			this.bunifuTransition2.AnimationType = 11;
			this.bunifuTransition2.Cursor = null;
			animation8.AnimateOnlyDifferences = true;
			animation8.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation4.BlindCoeff");
			animation8.LeafCoeff = 0f;
			animation8.MaxTime = 1f;
			animation8.MinTime = 0f;
			animation8.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation4.MosaicCoeff");
			animation8.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation4.MosaicShift");
			animation8.MosaicSize = 1;
			animation8.Padding = new global::System.Windows.Forms.Padding(100, 50, 100, 150);
			animation8.RotateCoeff = 0f;
			animation8.RotateLimit = 0f;
			animation8.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation4.ScaleCoeff");
			animation8.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation4.SlideCoeff");
			animation8.TimeCoeff = 2f;
			animation8.TransparencyCoeff = 0f;
			this.bunifuTransition2.DefaultAnimation = animation8;
			this.bunifuTransition2.Interval = 1;
			this.bunifuTransition2.MaxAnimationTime = 5000;
			this.bunifuTransition2.TimeStep = 0.01f;
			this.NewsfeedList.BackColor = global::System.Drawing.Color.FromArgb(35, 40, 50);
			this.NewsfeedList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuTransition1.SetDecoration(this.NewsfeedList, 0);
			this.bunifuTransition3.SetDecoration(this.NewsfeedList, 0);
			this.bunifuTransition2.SetDecoration(this.NewsfeedList, 0);
			this.NewsfeedList.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.NewsfeedList.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold);
			this.NewsfeedList.ForeColor = global::System.Drawing.Color.White;
			this.NewsfeedList.FormattingEnabled = true;
			this.NewsfeedList.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.NewsfeedList.ItemHeight = 50;
			this.NewsfeedList.Location = new global::System.Drawing.Point(0, 25);
			this.NewsfeedList.Name = "NewsfeedList";
			this.NewsfeedList.ShowScrollbar = false;
			this.NewsfeedList.Size = new global::System.Drawing.Size(300, 350);
			this.NewsfeedList.TabIndex = 145;
			this.NewsfeedList.Visible = false;
			this.NewsfeedList.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.NewsfeedList_DrawItem);
			this.NewsfeedList.MeasureItem += new global::System.Windows.Forms.MeasureItemEventHandler(this.NewsfeedList_MeasureItem);
			this.NotificationList.BackColor = global::System.Drawing.Color.FromArgb(35, 40, 50);
			this.NotificationList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuTransition1.SetDecoration(this.NotificationList, 0);
			this.bunifuTransition3.SetDecoration(this.NotificationList, 0);
			this.bunifuTransition2.SetDecoration(this.NotificationList, 0);
			this.NotificationList.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.NotificationList.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.NotificationList.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold);
			this.NotificationList.ForeColor = global::System.Drawing.Color.White;
			this.NotificationList.FormattingEnabled = true;
			this.NotificationList.ItemHeight = 50;
			this.NotificationList.Location = new global::System.Drawing.Point(0, 25);
			this.NotificationList.Name = "NotificationList";
			this.NotificationList.ShowScrollbar = false;
			this.NotificationList.Size = new global::System.Drawing.Size(300, 350);
			this.NotificationList.TabIndex = 142;
			this.NotificationList.Visible = false;
			this.NotificationList.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.NotificationList_DrawItem);
			this.NotificationList.MeasureItem += new global::System.Windows.Forms.MeasureItemEventHandler(this.NotificationList_MeasureItem);
			this.SupportTicketList.BackColor = global::System.Drawing.Color.FromArgb(35, 40, 50);
			this.SupportTicketList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuTransition1.SetDecoration(this.SupportTicketList, 0);
			this.bunifuTransition3.SetDecoration(this.SupportTicketList, 0);
			this.bunifuTransition2.SetDecoration(this.SupportTicketList, 0);
			this.SupportTicketList.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.SupportTicketList.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold);
			this.SupportTicketList.ForeColor = global::System.Drawing.Color.Silver;
			this.SupportTicketList.FormattingEnabled = true;
			this.SupportTicketList.ItemHeight = 50;
			this.SupportTicketList.Location = new global::System.Drawing.Point(0, 25);
			this.SupportTicketList.Name = "SupportTicketList";
			this.SupportTicketList.ShowScrollbar = false;
			this.SupportTicketList.Size = new global::System.Drawing.Size(300, 350);
			this.SupportTicketList.TabIndex = 144;
			this.SupportTicketList.Visible = false;
			this.SupportTicketList.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.SupportTicketList_DrawItem);
			this.SupportTicketList.MeasureItem += new global::System.Windows.Forms.MeasureItemEventHandler(this.SupportTicketList_MeasureItem);
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this.SupportTicketList;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			base.ClientSize = new global::System.Drawing.Size(950, 550);
			base.Controls.Add(this.MainPanel);
			base.Controls.Add(this.topBar);
			base.Controls.Add(this.sideBar);
			this.bunifuTransition1.SetDecoration(this, 0);
			this.bunifuTransition3.SetDecoration(this, 0);
			this.bunifuTransition2.SetDecoration(this, 0);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.sideBar.ResumeLayout(false);
			this.productsPanel.ResumeLayout(false);
			this.productsPanel.PerformLayout();
			this.memberAvatar.EndInit();
			this.slidingPanel.EndInit();
			this.topBar.ResumeLayout(false);
			this.topBar.PerformLayout();
			this.NewsfeedImage.EndInit();
			this.headerPicture.EndInit();
			this.SupportTicketsImage.EndInit();
			this.NotificationsImage.EndInit();
			this.bunifuImageButton1.EndInit();
			this.ShowLogs.EndInit();
			this.MainPanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.loading).EndInit();
			this.dropdownPanel.ResumeLayout(false);
			this.dropdownPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000047 RID: 71
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000048 RID: 72
		private global::Bunifu.Framework.UI.BunifuElipse MainEclipse;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Panel topBar;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Panel sideBar;

		// Token: 0x0400004B RID: 75
		private global::Bunifu.Framework.UI.BunifuImageButton slidingPanel;

		// Token: 0x0400004C RID: 76
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x0400004E RID: 78
		private global::Bunifu.Framework.UI.BunifuThinButton2 launchButton;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Panel MainPanel;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.PictureBox loading;

		// Token: 0x04000051 RID: 81
		private global::Bunifu.Framework.UI.BunifuImageButton ShowLogs;

		// Token: 0x04000052 RID: 82
		private global::Bunifu.Framework.UI.BunifuCustomLabel memberUsername;

		// Token: 0x04000053 RID: 83
		private global::Bunifu.Framework.UI.BunifuImageButton memberAvatar;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Panel productsPanel;

		// Token: 0x04000055 RID: 85
		private global::Bunifu.Framework.UI.BunifuCustomLabel requestFailed;

		// Token: 0x04000056 RID: 86
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label NotificationsNumber;

		// Token: 0x04000058 RID: 88
		private global::Bunifu.Framework.UI.BunifuImageButton NotificationsImage;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Panel dropdownPanel;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label SupportTicketsNumber;

		// Token: 0x0400005C RID: 92
		private global::Bunifu.Framework.UI.BunifuImageButton SupportTicketsImage;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400005E RID: 94
		private global::CustomTheme.CustomListBox NotificationList;

		// Token: 0x0400005F RID: 95
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition3;

		// Token: 0x04000060 RID: 96
		private global::CustomTheme.CustomListBox SupportTicketList;

		// Token: 0x04000061 RID: 97
		private global::Bunifu.Framework.UI.BunifuElipse dropdownEclipse;

		// Token: 0x04000062 RID: 98
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x04000063 RID: 99
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition1;

		// Token: 0x04000064 RID: 100
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition2;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000068 RID: 104
		private global::Bunifu.Framework.UI.BunifuImageButton headerPicture;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label NewsfeedNumber;

		// Token: 0x0400006A RID: 106
		private global::Bunifu.Framework.UI.BunifuImageButton NewsfeedImage;

		// Token: 0x0400006B RID: 107
		private global::CustomTheme.CustomListBox NewsfeedList;

		// Token: 0x0400006C RID: 108
		private global::Bunifu.Framework.UI.BunifuCustomLabel Notification;
	}
}
