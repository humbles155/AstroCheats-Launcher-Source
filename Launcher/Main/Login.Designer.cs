namespace Main
{
	// Token: 0x0200000B RID: 11
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002EA8 File Offset: 0x000010A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002EE0 File Offset: 0x000010E0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::BunifuAnimatorNS.Animation animation11 = new global::BunifuAnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Main.Login));
			global::BunifuAnimatorNS.Animation animation12 = new global::BunifuAnimatorNS.Animation();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.rememberMeCheckBox = new global::Bunifu.Framework.UI.BunifuCheckbox();
			this.RememberMeLabel = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.AutoLoginLabel = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.autoLoginCheckBox = new global::Bunifu.Framework.UI.BunifuCheckbox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.headerPicture = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton5 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.ShowLogs = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton3 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.failedLogin = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.loginForum = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.Username = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.bunifuSeparator1 = new global::Bunifu.Framework.UI.BunifuSeparator();
			this.bunifuSeparator2 = new global::Bunifu.Framework.UI.BunifuSeparator();
			this.Password = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.bunifuTransition1 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.Notification = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.loginButton = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuImageButton1 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.UsersOnline = new global::System.Windows.Forms.Label();
			this.logoPicture = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton2 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.ShowLogsButton = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuTransition2 = new global::BunifuAnimatorNS.BunifuTransition(this.components);
			this.panel1.SuspendLayout();
			this.loginForum.Controls.Add(this.bunifuImageButton5);
			this.loginForum.Controls.Add(this.ShowLogs);
			this.loginForum.Controls.Add(this.bunifuImageButton3);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.loginForum.Controls.Add(this.bunifuImageButton1);
			this.panel2.SuspendLayout();
			this.loginForum.Controls.Add(this.logoPicture);
			this.loginForum.Controls.Add(this.bunifuImageButton2);
			this.loginForum.Controls.Add(this.ShowLogsButton);
			base.SuspendLayout();
			this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, 0);
			this.bunifuTransition2.SetDecoration(this.bunifuCustomLabel1, 0);
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font("Segoe UI", 30f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Silver;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(398, 40);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(162, 58);
			this.bunifuCustomLabel1.TabIndex = 10;
			this.bunifuCustomLabel1.Text = "Login";
			this.rememberMeCheckBox.BackColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.rememberMeCheckBox.ChechedOffColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.rememberMeCheckBox.Checked = false;
			this.rememberMeCheckBox.CheckedOnColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.rememberMeCheckBox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition1.SetDecoration(this.rememberMeCheckBox, 0);
			this.bunifuTransition2.SetDecoration(this.rememberMeCheckBox, 0);
			this.rememberMeCheckBox.ForeColor = global::System.Drawing.Color.White;
			this.rememberMeCheckBox.Location = new global::System.Drawing.Point(409, 312);
			this.rememberMeCheckBox.Name = "rememberMeCheckBox";
			this.rememberMeCheckBox.Size = new global::System.Drawing.Size(20, 20);
			this.rememberMeCheckBox.TabIndex = 3;
			this.RememberMeLabel.AutoSize = true;
			this.bunifuTransition1.SetDecoration(this.RememberMeLabel, 0);
			this.bunifuTransition2.SetDecoration(this.RememberMeLabel, 0);
			this.RememberMeLabel.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RememberMeLabel.ForeColor = global::System.Drawing.Color.Silver;
			this.RememberMeLabel.Location = new global::System.Drawing.Point(432, 314);
			this.RememberMeLabel.Name = "RememberMeLabel";
			this.RememberMeLabel.Size = new global::System.Drawing.Size(90, 15);
			this.RememberMeLabel.TabIndex = 100;
			this.RememberMeLabel.Text = "Remember Me";
			this.RememberMeLabel.Click += new global::System.EventHandler(this.RememberMeLabel_Click);
			this.AutoLoginLabel.AutoSize = true;
			this.bunifuTransition1.SetDecoration(this.AutoLoginLabel, 0);
			this.bunifuTransition2.SetDecoration(this.AutoLoginLabel, 0);
			this.AutoLoginLabel.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AutoLoginLabel.ForeColor = global::System.Drawing.Color.Silver;
			this.AutoLoginLabel.Location = new global::System.Drawing.Point(432, 365);
			this.AutoLoginLabel.Name = "AutoLoginLabel";
			this.AutoLoginLabel.Size = new global::System.Drawing.Size(66, 15);
			this.AutoLoginLabel.TabIndex = 15;
			this.AutoLoginLabel.Text = "Auto Login";
			this.AutoLoginLabel.Click += new global::System.EventHandler(this.AutoLoginLabel_Click);
			this.autoLoginCheckBox.BackColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.autoLoginCheckBox.ChechedOffColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.autoLoginCheckBox.Checked = false;
			this.autoLoginCheckBox.CheckedOnColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.autoLoginCheckBox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition1.SetDecoration(this.autoLoginCheckBox, 0);
			this.bunifuTransition2.SetDecoration(this.autoLoginCheckBox, 0);
			this.autoLoginCheckBox.ForeColor = global::System.Drawing.Color.White;
			this.autoLoginCheckBox.Location = new global::System.Drawing.Point(409, 363);
			this.autoLoginCheckBox.Name = "autoLoginCheckBox";
			this.autoLoginCheckBox.Size = new global::System.Drawing.Size(20, 20);
			this.autoLoginCheckBox.TabIndex = 4;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.panel1.Controls.Add(this.headerPicture);
			this.panel1.Controls.Add(this.bunifuImageButton5);
			this.panel1.Controls.Add(this.ShowLogs);
			this.panel1.Controls.Add(this.bunifuImageButton3);
			this.bunifuTransition2.SetDecoration(this.panel1, 0);
			this.bunifuTransition1.SetDecoration(this.panel1, 0);
			this.panel1.ForeColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(750, 40);
			this.panel1.TabIndex = 16;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.headerPicture.BackColor = global::System.Drawing.Color.Transparent;
			this.headerPicture.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.headerPicture, 0);
			this.bunifuTransition1.SetDecoration(this.headerPicture, 0);
			this.headerPicture.Image = (global::System.Drawing.Image)resources.GetObject("headerPicture.Image");
			this.headerPicture.ImageActive = null;
			this.headerPicture.Location = new global::System.Drawing.Point(15, 0);
			this.headerPicture.Margin = new global::System.Windows.Forms.Padding(2);
			this.headerPicture.Name = "headerPicture";
			this.headerPicture.Size = new global::System.Drawing.Size(210, 40);
			this.headerPicture.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.headerPicture.TabIndex = 30;
			this.headerPicture.TabStop = false;
			this.headerPicture.Zoom = 10;
			this.bunifuImageButton5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuImageButton5.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuImageButton5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.bunifuImageButton5, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuImageButton5, 0);
			this.bunifuImageButton5.Image = (global::System.Drawing.Image)resources.GetObject("bunifuImageButton5.Image");
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new global::System.Drawing.Point(715, 5);
			this.bunifuImageButton5.Margin = new global::System.Windows.Forms.Padding(2);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new global::System.Drawing.Size(30, 30);
			this.bunifuImageButton5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 25;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 10;
			this.bunifuImageButton5.Click += new global::System.EventHandler(this.bunifuImageButton5_Click);
			this.ShowLogs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ShowLogs.BackColor = global::System.Drawing.Color.Transparent;
			this.ShowLogs.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.ShowLogs, 0);
			this.bunifuTransition1.SetDecoration(this.ShowLogs, 0);
			this.ShowLogs.Image = (global::System.Drawing.Image)resources.GetObject("ShowLogs.Image");
			this.ShowLogs.ImageActive = null;
			this.ShowLogs.Location = new global::System.Drawing.Point(683, 5);
			this.ShowLogs.Margin = new global::System.Windows.Forms.Padding(2);
			this.ShowLogs.Name = "ShowLogs";
			this.ShowLogs.Size = new global::System.Drawing.Size(31, 30);
			this.ShowLogs.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ShowLogs.TabIndex = 17;
			this.ShowLogs.TabStop = false;
			this.ShowLogs.Zoom = 10;
			this.ShowLogs.Click += new global::System.EventHandler(this.ShowLogs_Click);
			this.bunifuImageButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuImageButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuImageButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.bunifuImageButton3, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, 0);
			this.bunifuImageButton3.Image = (global::System.Drawing.Image)resources.GetObject("bunifuImageButton3.Image");
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new global::System.Drawing.Point(-195, 6);
			this.bunifuImageButton3.Margin = new global::System.Windows.Forms.Padding(2);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new global::System.Drawing.Size(31, 30);
			this.bunifuImageButton3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 6;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Zoom = 10;
			this.failedLogin.BackColor = global::System.Drawing.Color.Red;
			this.bunifuTransition1.SetDecoration(this.failedLogin, 0);
			this.bunifuTransition2.SetDecoration(this.failedLogin, 0);
			this.failedLogin.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.failedLogin.ForeColor = global::System.Drawing.Color.White;
			this.failedLogin.Location = new global::System.Drawing.Point(374, 414);
			this.failedLogin.Name = "failedLogin";
			this.failedLogin.Size = new global::System.Drawing.Size(375, 34);
			this.failedLogin.TabIndex = 17;
			this.failedLogin.Text = "Login Failed";
			this.failedLogin.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.failedLogin.Visible = false;
			this.loginForum.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition1.SetDecoration(this.loginForum, 0);
			this.bunifuTransition2.SetDecoration(this.loginForum, 0);
			this.loginForum.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline);
			this.loginForum.ForeColor = global::System.Drawing.Color.White;
			this.loginForum.Location = new global::System.Drawing.Point(575, 312);
			this.loginForum.Name = "loginForum";
			this.loginForum.Size = new global::System.Drawing.Size(139, 28);
			this.loginForum.TabIndex = 5;
			this.loginForum.Text = "Login with Forum";
			this.loginForum.Click += new global::System.EventHandler(this.loginForum_Click);
			this.loginForum.MouseEnter += new global::System.EventHandler(this.loginForum_MouseEnter);
			this.loginForum.MouseLeave += new global::System.EventHandler(this.loginForum_MouseLeave);
			this.Username.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.Username.BorderColor = global::System.Drawing.Color.SeaGreen;
			this.Username.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuTransition1.SetDecoration(this.Username, 0);
			this.bunifuTransition2.SetDecoration(this.Username, 0);
			this.Username.Font = new global::System.Drawing.Font("Calibri", 9.75f);
			this.Username.ForeColor = global::System.Drawing.Color.Silver;
			this.Username.Location = new global::System.Drawing.Point(412, 175);
			this.Username.Name = "Username";
			this.Username.Size = new global::System.Drawing.Size(286, 16);
			this.Username.TabIndex = 1;
			this.Username.Text = "Username";
			this.Username.Enter += new global::System.EventHandler(this.Username_Enter);
			this.Username.Leave += new global::System.EventHandler(this.Username_Leave);
			this.bunifuSeparator1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition2.SetDecoration(this.bunifuSeparator1, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, 0);
			this.bunifuSeparator1.ForeColor = global::System.Drawing.Color.Gray;
			this.bunifuSeparator1.LineColor = global::System.Drawing.Color.FromArgb(128, 128, 128);
			this.bunifuSeparator1.LineThickness = 4;
			this.bunifuSeparator1.Location = new global::System.Drawing.Point(407, 192);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Size = new global::System.Drawing.Size(297, 13);
			this.bunifuSeparator1.TabIndex = 22;
			this.bunifuSeparator1.Transparency = 255;
			this.bunifuSeparator1.Vertical = false;
			this.bunifuSeparator2.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition2.SetDecoration(this.bunifuSeparator2, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, 0);
			this.bunifuSeparator2.ForeColor = global::System.Drawing.Color.Gray;
			this.bunifuSeparator2.LineColor = global::System.Drawing.Color.FromArgb(128, 128, 128);
			this.bunifuSeparator2.LineThickness = 4;
			this.bunifuSeparator2.Location = new global::System.Drawing.Point(407, 265);
			this.bunifuSeparator2.Name = "bunifuSeparator2";
			this.bunifuSeparator2.Size = new global::System.Drawing.Size(297, 13);
			this.bunifuSeparator2.TabIndex = 22;
			this.bunifuSeparator2.Transparency = 255;
			this.bunifuSeparator2.Vertical = false;
			this.Password.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.Password.BorderColor = global::System.Drawing.Color.SeaGreen;
			this.Password.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.bunifuTransition1.SetDecoration(this.Password, 0);
			this.bunifuTransition2.SetDecoration(this.Password, 0);
			this.Password.Font = new global::System.Drawing.Font("Calibri", 9.75f);
			this.Password.ForeColor = global::System.Drawing.Color.Silver;
			this.Password.HideSelection = false;
			this.Password.Location = new global::System.Drawing.Point(412, 249);
			this.Password.Name = "Password";
			this.Password.Size = new global::System.Drawing.Size(286, 16);
			this.Password.TabIndex = 2;
			this.Password.Text = "Password";
			this.Password.Enter += new global::System.EventHandler(this.Password_Enter);
			this.Password.Leave += new global::System.EventHandler(this.Password_Leave);
			this.bunifuTransition1.AnimationType = (BunifuAnimatorNS.AnimationType)9;
			this.bunifuTransition1.Cursor = null;
			animation11.AnimateOnlyDifferences = true;
			animation11.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation11.BlindCoeff");
			animation11.LeafCoeff = 1f;
			animation11.MaxTime = 1f;
			animation11.MinTime = 0f;
			animation11.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation11.MosaicCoeff");
			animation11.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation11.MosaicShift");
			animation11.MosaicSize = 0;
			animation11.Padding = new global::System.Windows.Forms.Padding(0);
			animation11.RotateCoeff = 0f;
			animation11.RotateLimit = 0f;
			animation11.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation11.ScaleCoeff");
			animation11.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation11.SlideCoeff");
			animation11.TimeCoeff = 0f;
			animation11.TransparencyCoeff = 0f;
			this.bunifuTransition1.DefaultAnimation = animation11;
			this.bunifuTransition1.MaxAnimationTime = 1000;
			this.bunifuTransition2.SetDecoration(this.tabPage1, 0);
			this.bunifuTransition1.SetDecoration(this.tabPage1, 0);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(192, 74);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.bunifuTransition2.SetDecoration(this.tabPage2, 0);
			this.bunifuTransition1.SetDecoration(this.tabPage2, 0);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.Notification.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.bunifuTransition1.SetDecoration(this.Notification, 0);
			this.bunifuTransition2.SetDecoration(this.Notification, 0);
			this.Notification.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Notification.ForeColor = global::System.Drawing.Color.White;
			this.Notification.Location = new global::System.Drawing.Point(374, 414);
			this.Notification.Name = "Notification";
			this.Notification.Size = new global::System.Drawing.Size(375, 34);
			this.Notification.TabIndex = 101;
			this.Notification.Text = "Notification Message";
			this.Notification.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Notification.Visible = false;
			this.bunifuTransition1.SetDecoration(this.pictureBox1, 0);
			this.bunifuTransition2.SetDecoration(this.pictureBox1, 0);
			this.pictureBox1.Location = new global::System.Drawing.Point(709, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			this.loginButton.ActiveBorderThickness = 1;
			this.loginButton.ActiveCornerRadius = 30;
			this.loginButton.ActiveFillColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.loginButton.ActiveForecolor = global::System.Drawing.Color.White;
			this.loginButton.ActiveLineColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.loginButton.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.loginButton.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("loginButton.BackgroundImage");
			this.loginButton.ButtonText = "Login";
			this.loginButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.loginButton, 0);
			this.bunifuTransition1.SetDecoration(this.loginButton, 0);
			this.loginButton.Font = new global::System.Drawing.Font("Corbel", 18f);
			this.loginButton.ForeColor = global::System.Drawing.Color.White;
			this.loginButton.IdleBorderThickness = 1;
			this.loginButton.IdleCornerRadius = 30;
			this.loginButton.IdleFillColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.loginButton.IdleForecolor = global::System.Drawing.Color.White;
			this.loginButton.IdleLineColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.loginButton.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.loginButton.Location = new global::System.Drawing.Point(581, 349);
			this.loginButton.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new global::System.Drawing.Size(112, 52);
			this.loginButton.TabIndex = 6;
			this.loginButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.loginButton.Click += new global::System.EventHandler(this.loginButton_Click);
			this.bunifuImageButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuImageButton1.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.bunifuImageButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.bunifuImageButton1, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, 0);
			this.bunifuImageButton1.Image = (global::System.Drawing.Image)resources.GetObject("bunifuImageButton1.Image");
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new global::System.Drawing.Point(-38, 6);
			this.bunifuImageButton1.Margin = new global::System.Windows.Forms.Padding(2);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new global::System.Drawing.Size(31, 30);
			this.bunifuImageButton1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 7;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(21, 28, 38);
			this.panel2.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.UsersOnline);
			this.panel2.Controls.Add(this.logoPicture);
			this.panel2.Controls.Add(this.bunifuImageButton2);
			this.panel2.Controls.Add(this.ShowLogsButton);
			this.bunifuTransition2.SetDecoration(this.panel2, 0);
			this.bunifuTransition1.SetDecoration(this.panel2, 0);
			this.panel2.Location = new global::System.Drawing.Point(0, 40);
			this.panel2.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(375, 410);
			this.panel2.TabIndex = 2;
			this.UsersOnline.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuTransition1.SetDecoration(this.UsersOnline, 0);
			this.bunifuTransition2.SetDecoration(this.UsersOnline, 0);
			this.UsersOnline.ForeColor = global::System.Drawing.Color.Silver;
			this.UsersOnline.Location = new global::System.Drawing.Point(12, 246);
			this.UsersOnline.Name = "UsersOnline";
			this.UsersOnline.Size = new global::System.Drawing.Size(352, 16);
			this.UsersOnline.TabIndex = 11;
			this.UsersOnline.Text = "0 Online Users";
			this.UsersOnline.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.logoPicture.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.logoPicture.BackColor = global::System.Drawing.Color.Transparent;
			this.logoPicture.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.logoPicture, 0);
			this.bunifuTransition1.SetDecoration(this.logoPicture, 0);
			this.logoPicture.Image = (global::System.Drawing.Image)resources.GetObject("logoPicture.Image");
			this.logoPicture.ImageActive = null;
			this.logoPicture.Location = new global::System.Drawing.Point(112, 112);
			this.logoPicture.Name = "logoPicture";
			this.logoPicture.Size = new global::System.Drawing.Size(150, 150);
			this.logoPicture.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPicture.TabIndex = 10;
			this.logoPicture.TabStop = false;
			this.logoPicture.Zoom = 10;
			this.bunifuImageButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuImageButton2.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.bunifuImageButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.bunifuImageButton2, 0);
			this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, 0);
			this.bunifuImageButton2.Image = (global::System.Drawing.Image)resources.GetObject("bunifuImageButton2.Image");
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new global::System.Drawing.Point(-358, 5);
			this.bunifuImageButton2.Margin = new global::System.Windows.Forms.Padding(2);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new global::System.Drawing.Size(31, 30);
			this.bunifuImageButton2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 8;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			this.ShowLogsButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ShowLogsButton.BackColor = global::System.Drawing.Color.Transparent;
			this.ShowLogsButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTransition2.SetDecoration(this.ShowLogsButton, 0);
			this.bunifuTransition1.SetDecoration(this.ShowLogsButton, 0);
			this.ShowLogsButton.Image = (global::System.Drawing.Image)resources.GetObject("ShowLogsButton.Image");
			this.ShowLogsButton.ImageActive = null;
			this.ShowLogsButton.Location = new global::System.Drawing.Point(-570, 6);
			this.ShowLogsButton.Margin = new global::System.Windows.Forms.Padding(2);
			this.ShowLogsButton.Name = "ShowLogsButton";
			this.ShowLogsButton.Size = new global::System.Drawing.Size(10, 30);
			this.ShowLogsButton.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ShowLogsButton.TabIndex = 6;
			this.ShowLogsButton.TabStop = false;
			this.ShowLogsButton.Zoom = 10;
			this.bunifuTransition2.AnimationType = (BunifuAnimatorNS.AnimationType)5;
			this.bunifuTransition2.Cursor = null;
			animation12.AnimateOnlyDifferences = true;
			animation12.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation12.BlindCoeff");
			animation12.LeafCoeff = 0f;
			animation12.MaxTime = 1f;
			animation12.MinTime = 0f;
			animation12.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation12.MosaicCoeff");
			animation12.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation12.MosaicShift");
			animation12.MosaicSize = 0;
			animation12.Padding = new global::System.Windows.Forms.Padding(30);
			animation12.RotateCoeff = 0.5f;
			animation12.RotateLimit = 0.2f;
			animation12.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation12.ScaleCoeff");
			animation12.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation12.SlideCoeff");
			animation12.TimeCoeff = 0f;
			animation12.TransparencyCoeff = 0f;
			this.bunifuTransition2.DefaultAnimation = animation12;
			this.bunifuTransition2.MaxAnimationTime = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			base.ClientSize = new global::System.Drawing.Size(750, 450);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.Notification);
			base.Controls.Add(this.Password);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.bunifuSeparator2);
			base.Controls.Add(this.bunifuSeparator1);
			base.Controls.Add(this.Username);
			base.Controls.Add(this.loginForum);
			base.Controls.Add(this.failedLogin);
			base.Controls.Add(this.AutoLoginLabel);
			base.Controls.Add(this.autoLoginCheckBox);
			base.Controls.Add(this.RememberMeLabel);
			base.Controls.Add(this.loginButton);
			base.Controls.Add(this.rememberMeCheckBox);
			base.Controls.Add(this.bunifuCustomLabel1);
			base.Controls.Add(this.bunifuImageButton1);
			base.Controls.Add(this.panel1);
			this.bunifuTransition1.SetDecoration(this, 0);
			this.bunifuTransition2.SetDecoration(this, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			base.Load += new global::System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001E RID: 30
		private global::Bunifu.Framework.UI.BunifuImageButton ShowLogsButton;

		// Token: 0x0400001F RID: 31
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

		// Token: 0x04000020 RID: 32
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;

		// Token: 0x04000021 RID: 33
		private global::Bunifu.Framework.UI.BunifuImageButton logoPicture;

		// Token: 0x04000022 RID: 34
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000023 RID: 35
		private global::Bunifu.Framework.UI.BunifuCheckbox rememberMeCheckBox;

		// Token: 0x04000024 RID: 36
		private global::Bunifu.Framework.UI.BunifuThinButton2 loginButton;

		// Token: 0x04000025 RID: 37
		private global::Bunifu.Framework.UI.BunifuCustomLabel RememberMeLabel;

		// Token: 0x04000026 RID: 38
		private global::Bunifu.Framework.UI.BunifuCustomLabel AutoLoginLabel;

		// Token: 0x04000027 RID: 39
		private global::Bunifu.Framework.UI.BunifuCheckbox autoLoginCheckBox;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000029 RID: 41
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;

		// Token: 0x0400002A RID: 42
		private global::Bunifu.Framework.UI.BunifuImageButton ShowLogs;

		// Token: 0x0400002B RID: 43
		private global::Bunifu.Framework.UI.BunifuCustomLabel failedLogin;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400002D RID: 45
		private global::Bunifu.Framework.UI.BunifuCustomLabel loginForum;

		// Token: 0x0400002E RID: 46
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox Username;

		// Token: 0x0400002F RID: 47
		private global::Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;

		// Token: 0x04000030 RID: 48
		private global::Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;

		// Token: 0x04000031 RID: 49
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox Password;

		// Token: 0x04000032 RID: 50
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition1;

		// Token: 0x04000033 RID: 51
		private global::BunifuAnimatorNS.BunifuTransition bunifuTransition2;

		// Token: 0x04000034 RID: 52
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label UsersOnline;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000038 RID: 56
		private global::Bunifu.Framework.UI.BunifuCustomLabel Notification;

		// Token: 0x04000039 RID: 57
		private global::Bunifu.Framework.UI.BunifuImageButton headerPicture;
	}
}
