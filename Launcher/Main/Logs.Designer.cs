namespace Main
{
	// Token: 0x0200000C RID: 12
	public partial class Logs : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00006078 File Offset: 0x00004278
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000060B0 File Offset: 0x000042B0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Main.Logs));
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.LogsTextBox = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.topBar = new global::System.Windows.Forms.Panel();
			this.ShowLogs = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.Title = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.topBar.SuspendLayout();
			this.ShowLogs.BeginInit();
			base.SuspendLayout();
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			this.LogsTextBox.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			this.LogsTextBox.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LogsTextBox.ForeColor = global::System.Drawing.Color.White;
			this.LogsTextBox.Location = new global::System.Drawing.Point(12, 46);
			this.LogsTextBox.Multiline = true;
			this.LogsTextBox.Name = "LogsTextBox";
			this.LogsTextBox.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.LogsTextBox.Size = new global::System.Drawing.Size(776, 392);
			this.LogsTextBox.TabIndex = 2;
			this.LogsTextBox.Text = "Logs";
			this.topBar.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.topBar.Controls.Add(this.ShowLogs);
			this.topBar.Controls.Add(this.Title);
			this.topBar.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.topBar.Location = new global::System.Drawing.Point(0, 0);
			this.topBar.Margin = new global::System.Windows.Forms.Padding(2);
			this.topBar.Name = "topBar";
			this.topBar.Size = new global::System.Drawing.Size(800, 40);
			this.topBar.TabIndex = 3;
			this.ShowLogs.BackColor = global::System.Drawing.Color.Transparent;
			this.ShowLogs.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ShowLogs.Image = (global::System.Drawing.Image)resources.GetObject("ShowLogs.Image");
			this.ShowLogs.ImageActive = null;
			this.ShowLogs.Location = new global::System.Drawing.Point(757, 2);
			this.ShowLogs.Margin = new global::System.Windows.Forms.Padding(2);
			this.ShowLogs.Name = "ShowLogs";
			this.ShowLogs.Size = new global::System.Drawing.Size(31, 30);
			this.ShowLogs.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ShowLogs.TabIndex = 23;
			this.ShowLogs.TabStop = false;
			this.ShowLogs.Zoom = 10;
			this.ShowLogs.Click += new global::System.EventHandler(this.ShowLogs_Click);
			this.Title.BackColor = global::System.Drawing.Color.FromArgb(0, 102, 204);
			this.Title.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Title.ForeColor = global::System.Drawing.Color.White;
			this.Title.Location = new global::System.Drawing.Point(2, 0);
			this.Title.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Title.Name = "Title";
			this.Title.Size = new global::System.Drawing.Size(247, 40);
			this.Title.TabIndex = 0;
			this.Title.Text = "MaverickCheats - Logs";
			this.Title.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(36, 46, 59);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.topBar);
			base.Controls.Add(this.LogsTextBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Logs";
			this.Text = "Logs";
			base.Load += new global::System.EventHandler(this.Logs_Load);
			this.topBar.ResumeLayout(false);
			this.ShowLogs.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003B RID: 59
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003C RID: 60
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400003D RID: 61
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox LogsTextBox;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Panel topBar;

		// Token: 0x0400003F RID: 63
		private global::Bunifu.Framework.UI.BunifuCustomLabel Title;

		// Token: 0x04000040 RID: 64
		private global::Bunifu.Framework.UI.BunifuImageButton ShowLogs;
	}
}
