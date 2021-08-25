using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Main
{
	// Token: 0x02000008 RID: 8
	public class Downloads
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001C RID: 28 RVA: 0x00002454 File Offset: 0x00000654
		// (remove) Token: 0x0600001D RID: 29 RVA: 0x0000248C File Offset: 0x0000068C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler<ProcessEventArgs> ProcessCompleted;

		// Token: 0x0600001E RID: 30 RVA: 0x000024C4 File Offset: 0x000006C4
		public void DownloadHeader(string URL, PictureBox PictureBox)
		{
			ProcessEventArgs data = new ProcessEventArgs();
			try
			{
				WebClient client = new WebClient();
				client.Proxy = null;
				client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
				{
					Logs.LogEntries.Add(string.Concat(new string[]
					{
						"{",
						URL,
						"} Bytes: ",
						e.BytesReceived.ToString(),
						" of ",
						e.TotalBytesToReceive.ToString()
					}));
				};
				client.DownloadDataCompleted += delegate(object s, DownloadDataCompletedEventArgs args)
				{
					MemoryStream memoryStream = new MemoryStream(args.Result);
					data.IsCompleted = true;
					data.PictureBox = PictureBox;
					data.Image = Image.FromStream(memoryStream);
					Brand.config.Header = data.Image;
					this.OnProcessCompleted(data);
				};
				client.DownloadDataAsync(new Uri(URL));
			}
			catch (Exception ex)
			{
				this.OnProcessCompleted(data);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002564 File Offset: 0x00000764
		public void DownloadLogo(string URL, PictureBox PictureBox)
		{
			ProcessEventArgs data = new ProcessEventArgs();
			try
			{
				WebClient client = new WebClient();
				client.Proxy = null;
				client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
				{
					Logs.LogEntries.Add(string.Concat(new string[]
					{
						"{",
						URL,
						"} Bytes: ",
						e.BytesReceived.ToString(),
						" of ",
						e.TotalBytesToReceive.ToString()
					}));
				};
				client.DownloadDataCompleted += delegate(object s, DownloadDataCompletedEventArgs args)
				{
					MemoryStream memoryStream = new MemoryStream(args.Result);
					data.IsCompleted = true;
					data.PictureBox = PictureBox;
					data.Image = Image.FromStream(memoryStream);
					Brand.config.Logo = data.Image;
					this.OnProcessCompleted(data);
				};
				client.DownloadDataAsync(new Uri(URL));
			}
			catch (Exception ex)
			{
				this.OnProcessCompleted(data);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002604 File Offset: 0x00000804
		public void DownloadAvatar(string URL, PictureBox PictureBox)
		{
			ProcessEventArgs data = new ProcessEventArgs();
			try
			{
				WebClient client = new WebClient();
				client.Proxy = null;
				client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
				{
					Logs.LogEntries.Add(string.Concat(new string[]
					{
						"{",
						URL,
						"} Bytes: ",
						e.BytesReceived.ToString(),
						" of ",
						e.TotalBytesToReceive.ToString()
					}));
				};
				client.DownloadDataCompleted += delegate(object s, DownloadDataCompletedEventArgs args)
				{
					MemoryStream memoryStream = new MemoryStream(args.Result);
					data.IsCompleted = true;
					data.PictureBox = PictureBox;
					data.Image = Image.FromStream(memoryStream);
					Brand.config.Header = data.Image;
					this.OnProcessCompleted(data);
				};
				client.DownloadDataAsync(new Uri(URL));
			}
			catch (Exception ex)
			{
				this.OnProcessCompleted(data);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026A4 File Offset: 0x000008A4
		public void DownloadProductImages(string URL, PictureBox PictureBox)
		{
			ProcessEventArgs data = new ProcessEventArgs();
			try
			{
				WebClient client = new WebClient();
				client.Proxy = null;
				client.DownloadProgressChanged += delegate(object sender, DownloadProgressChangedEventArgs e)
				{
					Logs.LogEntries.Add(string.Concat(new string[]
					{
						"{",
						URL,
						"} Bytes: ",
						e.BytesReceived.ToString(),
						" of ",
						e.TotalBytesToReceive.ToString()
					}));
				};
				client.DownloadDataCompleted += delegate(object s, DownloadDataCompletedEventArgs args)
				{
					MemoryStream memoryStream = new MemoryStream(args.Result);
					data.IsCompleted = true;
					data.PictureBox = PictureBox;
					data.Image = Image.FromStream(memoryStream);
					this.OnProcessCompleted(data);
				};
				client.DownloadDataAsync(new Uri(URL));
			}
			catch (Exception ex)
			{
				this.OnProcessCompleted(data);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002744 File Offset: 0x00000944
		protected virtual void OnProcessCompleted(ProcessEventArgs e)
		{
			EventHandler<ProcessEventArgs> processCompleted = this.ProcessCompleted;
			if (processCompleted != null)
			{
				processCompleted(this, e);
			}
		}
	}
}
