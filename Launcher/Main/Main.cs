using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AuthLib;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using CustomTheme;
using NetworkTypes;
using Resources;

namespace Main
{
	// Token: 0x0200000D RID: 13
	public partial class Main : Form
	{
		// Token: 0x06000061 RID: 97
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, IntPtr lParam);

		// Token: 0x06000062 RID: 98 RVA: 0x00006548 File Offset: 0x00004748
		public Main(token token)
		{
			this.token = token;
			this.InitializeComponent();
			this.loading.Image = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "Logo (40x40).gif").Value));
			this.headerPicture.Location = new Point(15, 0);
			this.headerPicture.Image = Brand.config.Header;
			Downloads downloads = new Downloads();
			downloads.ProcessCompleted += this.Downloads_ProcessCompleted;
			downloads.DownloadAvatar(token.member.photoUrl, this.memberAvatar);
			this.memberUsername.Text = token.member.name;
			this.bunifuTransition2.Show(this.memberAvatar, false, null);
			this.productsPanel.MouseWheel += this.ProductsPanel_MouseWheel;
			this.SupportTicketList.MouseWheel += this.SupportTicketList_MouseWheel;
			this.NotificationList.MouseWheel += this.NotificationList_MouseWheel;
			Thread AuthThread = new Thread(new ThreadStart(this.AuthenticateThread));
			AuthThread.Start();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000066B4 File Offset: 0x000048B4
		private void AuthenticateThread()
		{
			for (;;)
			{
				object AuthObj = this.RestAPI.Authenticate(this.token.authtoken);
				bool flag = AuthObj is error;
				if (flag)
				{
					break;
				}
				Thread.Sleep(15000);
			}
			Console.WriteLine("Authentication Failure");
			Environment.Exit(0);
			base.Close();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006718 File Offset: 0x00004918
		private void Downloads_ProcessCompleted(object sender, ProcessEventArgs e)
		{
			Logs.LogEntries.Add("Process " + (e.IsCompleted ? "Completed Successfully" : "failed"));
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				e.PictureBox.Image = e.Image;
			}));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006774 File Offset: 0x00004974
		private void Main_Load(object sender, EventArgs e)
		{
			this.Busy = true;
			new Thread(delegate()
			{
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.requestFailed.Text = "";
					this.requestFailed.Visible = false;
				}));
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.bunifuTransition3.ShowSync(this.loading, false, null);
				}));
				object GroupObj = this.RestAPI.Groups(this.token);
				bool flag = GroupObj is List<group>;
				if (flag)
				{
					this.groups = (List<group>)GroupObj;
				}
				else
				{
					bool flag2 = GroupObj is error;
					if (flag2)
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.requestFailed.Text = "Groups Error: " + ((error)GroupObj).message;
							this.requestFailed.Visible = true;
						}));
					}
					else
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.requestFailed.Text = "Groups Error: " + (string)GroupObj;
							this.requestFailed.Visible = true;
						}));
					}
				}
				object ProductObj = this.RestAPI.Products(this.token);
				bool flag3 = ProductObj is List<product>;
				if (flag3)
				{
					this.products = (List<product>)ProductObj;
				}
				else
				{
					bool flag4 = ProductObj is error;
					if (flag4)
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.requestFailed.Text = "Products Error: " + ((error)ProductObj).message;
							this.requestFailed.Visible = true;
						}));
					}
					else
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.requestFailed.Text = "Products Error: " + (string)ProductObj;
							this.requestFailed.Visible = true;
						}));
					}
				}
				using (List<group>.Enumerator enumerator = this.groups.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						group group = enumerator.Current;
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							BunifuFlatButton CheatListTab = new BunifuFlatButton();
							CheatListTab.Tag = new GroupControl(true, group, false);
							CheatListTab.Activecolor = Color.FromArgb(0, 102, 204);
							CheatListTab.BackColor = Color.FromArgb(30, 37, 47);
							CheatListTab.BackgroundImageLayout = ImageLayout.Stretch;
							CheatListTab.BorderRadius = 0;
							CheatListTab.Cursor = Cursors.Hand;
							CheatListTab.DisabledColor = Color.Gray;
							CheatListTab.Iconcolor = Color.Transparent;
							CheatListTab.Iconimage = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "Logo (40x40).gif").Value));
							Downloads downloads = new Downloads();
							downloads.ProcessCompleted += this.Downloads_ProcessCompleted;
							downloads.DownloadProductImages("https://api.maverickcheats.net/?AppID=" + Brand.AppID + "&Request=Photo&Type=Group&UID=" + group.uid.ToString(), CheatListTab.limage);
							CheatListTab.Iconimage_right = null;
							CheatListTab.Iconimage_right_Selected = null;
							CheatListTab.Iconimage_Selected = null;
							CheatListTab.IconMarginLeft = 0;
							CheatListTab.IconMarginRight = 0;
							CheatListTab.IconRightVisible = true;
							CheatListTab.IconRightZoom = 65.0;
							CheatListTab.IconVisible = true;
							CheatListTab.IconZoom = 65.0;
							CheatListTab.IsTab = true;
							CheatListTab.Name = "button";
							CheatListTab.Normalcolor = Color.FromArgb(30, 37, 47);
							CheatListTab.OnHovercolor = Color.FromArgb(0, 102, 204);
							CheatListTab.OnHoverTextColor = Color.White;
							CheatListTab.Size = new Size(300, 49);
							CheatListTab.TabIndex = group.uid;
							CheatListTab.Text = "  " + group.name;
							CheatListTab.TextAlign = ContentAlignment.MiddleLeft;
							CheatListTab.Textcolor = Color.White;
							CheatListTab.TextFont = new Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
							CheatListTab.Click += this.CheatListTab_Click;
							CheatListTab.MouseDown += this.CheatListTab_MouseDown;
							CheatListTab.MouseEnter += this.CheatListTabs_Enter;
							CheatListTab.MouseLeave += this.CheatListTabs_Leave;
							this.flowLayoutPanel1.Controls.Add(CheatListTab);
							this.flowLayoutPanel1.Controls.SetChildIndex(CheatListTab, CheatListTab.TabIndex);
						}));
					}
				}
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.bunifuTransition3.HideSync(this.loading, false, null);
				}));
				this.Busy = false;
			}).Start();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006798 File Offset: 0x00004998
		private void ProductsPanel_MouseWheel(object sender, MouseEventArgs e)
		{
			Console.WriteLine("Height {0}, Width {1}, Top: {2}, Bottom: {3}", new object[]
			{
				this.flowLayoutPanel1.Size.Height,
				this.flowLayoutPanel1.Size.Width,
				this.flowLayoutPanel1.Top,
				this.flowLayoutPanel1.Bottom
			});
			bool flag = e.Delta > 0;
			if (flag)
			{
				bool flag2 = this.flowLayoutPanel1.Top < 0;
				if (flag2)
				{
					this.flowLayoutPanel1.Top += 25;
				}
				else
				{
					Console.WriteLine("No Scroll Up for you! -> Height {0}, Width {1}, Top: {2}, Bottom: {3}", new object[]
					{
						this.flowLayoutPanel1.Size.Height,
						this.flowLayoutPanel1.Size.Width,
						this.flowLayoutPanel1.Top,
						this.flowLayoutPanel1.Bottom
					});
				}
				this.flowLayoutPanel1.PerformLayout();
			}
			else
			{
				bool flag3 = this.flowLayoutPanel1.Bottom - 25 > 50;
				if (flag3)
				{
					this.flowLayoutPanel1.Top -= 25;
				}
				else
				{
					bool flag4 = Math.Abs(this.flowLayoutPanel1.Bottom - 50) > 0;
					if (flag4)
					{
						this.flowLayoutPanel1.Top -= Math.Abs(this.flowLayoutPanel1.Bottom - 50);
					}
					else
					{
						Console.WriteLine("No Scroll Down for you! -> Height {0}, Width {1}, Top: {2}, Bottom: {3}", new object[]
						{
							this.flowLayoutPanel1.Size.Height,
							this.flowLayoutPanel1.Size.Width,
							this.flowLayoutPanel1.Top,
							this.flowLayoutPanel1.Bottom
						});
					}
				}
				this.flowLayoutPanel1.PerformLayout();
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000069BC File Offset: 0x00004BBC
		private void launchButton_Click(object sender, EventArgs e)
		{
			bool busy = this.Busy;
			if (!busy)
			{
				new Thread(delegate()
				{
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.requestFailed.Text = "";
						this.requestFailed.Visible = false;
					}));
					this.Busy = true;
					bool flag = !this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Any((BunifuFlatButton control) => control.selected);
					if (!flag)
					{
						bool flag2 = !(this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Find((BunifuFlatButton control) => control.selected).Tag is product);
						if (flag2)
						{
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.requestFailed.Text = "The Selected Tab is not a Cheat, Open the Group and select a Product!";
								this.requestFailed.Visible = true;
							}));
						}
						else
						{
							product product = (product)this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Find((BunifuFlatButton control) => control.selected).Tag;
							bool flag3 = product.status == 0;
							if (flag3)
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.requestFailed.Text = "We're sorry, this cheat is being updated by the Development Team.";
									this.requestFailed.Visible = true;
								}));
							}
							else
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.bunifuTransition3.ShowSync(this.loading, false, null);
								}));
								string Folder = Path.GetTempPath() + Path.GetRandomFileName() + "\\";
								Stopwatch stopwatch = new Stopwatch();
								stopwatch.Start();
								object DownloadObj = this.RestAPI.Download("Product", product, this.token);
								bool flag4 = DownloadObj is byte[];
								if (flag4)
								{
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										this.Notification.Text = "Download Finished - " + stopwatch.Elapsed.TotalMilliseconds.ToString() + "ms";
										this.Notification.Visible = true;
									}));
									bool flag5 = !Directory.Exists(Folder);
									if (flag5)
									{
										Directory.CreateDirectory(Folder);
									}
									else
									{
										try
										{
											foreach (string FilePath in Directory.GetFiles(Folder))
											{
												try
												{
													Process.GetProcessesByName(Path.GetFileNameWithoutExtension(FilePath)).ToList<Process>().ForEach(delegate(Process process)
													{
														process.Kill();
													});
												}
												catch (Exception ex)
												{
												}
												try
												{
													File.Delete(FilePath);
												}
												catch (Exception ex2)
												{
												}
											}
										}
										catch (Exception ex3)
										{
										}
									}
									Thread.Sleep(100);
									File.SetAttributes(Folder, FileAttributes.Hidden | FileAttributes.System);
									string Run_FileName = Path.GetRandomFileName();
									using (ZipArchive Archive = new ZipArchive(new MemoryStream((byte[])DownloadObj), ZipArchiveMode.Read))
									{
										foreach (ZipArchiveEntry Entry in Archive.Entries)
										{
											bool flag6 = !Directory.Exists(Path.GetDirectoryName(Folder + Entry.FullName));
											if (flag6)
											{
												Directory.CreateDirectory(Path.GetDirectoryName(Folder + Entry.FullName));
											}
											bool flag7 = Entry.Name.Length == 0;
											if (flag7)
											{
												Directory.CreateDirectory(Path.GetDirectoryName(Folder + Entry.FullName));
											}
											else
											{
												bool flag8 = !File.Exists(Folder + Entry.FullName);
												if (flag8)
												{
													bool flag9 = Entry.Name.ToLower().Contains("run");
													if (flag9)
													{
														string New_FileName = Entry.Name.Replace("run", Run_FileName);
														using (FileStream FileStream = new FileStream(Folder + New_FileName, FileMode.Create, FileAccess.Write))
														{
															using (Stream Stream = Entry.Open())
															{
																Stream.CopyTo(FileStream);
															}
														}
														File.SetAttributes(Folder + New_FileName, FileAttributes.Hidden | FileAttributes.System);
													}
													else
													{
														Entry.ExtractToFile(Folder + Entry.FullName);
														File.SetAttributes(Folder + Entry.FullName, FileAttributes.Hidden | FileAttributes.System);
													}
												}
											}
										}
									}
									bool flag10 = !File.Exists(Folder + Run_FileName + ".exe");
									if (flag10)
									{
										MessageBox.Show("Injection Error: {MissingInjector}");
									}
									else
									{
										try
										{
											Process run_process = new Process();
											ProcessStartInfo run_startInfo = new ProcessStartInfo
											{
												WorkingDirectory = Folder,
												FileName = Folder + Run_FileName + ".exe",
												Arguments = this.token.authtoken + " " + product.uid.ToString(),
												RedirectStandardOutput = false,
												UseShellExecute = false,
												Verb = "runas"
											};
											run_process.StartInfo = run_startInfo;
											run_process.Start();
										}
										catch (Win32Exception ex4)
										{
											MessageBox.Show("Error", "Injector could not be started due to an error.\nThis is typically caused by Windows Defender or a third party Anti-Virus.\n\nWe have copied the Error to your Clipboard, paste the error into a ticket and send it to Staff!\n" + ex4.ToString());
											Clipboard.SetText(ex4.ToString());
										}
										Thread.Sleep(2500);
										new Thread(delegate()
										{
											bool flag12 = product.intern == 1;
											if (flag12)
											{
												MessageBox.Show("Injector: " + ((Process.GetProcessesByName(Run_FileName).Length != 0) ? ("Pre-Loaded\n" + ((Process.GetProcessesByName(product.targetprocess).Length == 0) ? "You have 60 seconds to start your game!\n" : "") + "Press'Ok' to close the Launcher, this Auto Closes after 5s!") : "Failed to Launch\n( Make sure your AntiVirus is Disabled and that you start your game AFTER you Inject )"));
											}
											else
											{
												MessageBox.Show("External Execution: " + ((Process.GetProcessesByName(Run_FileName).Length != 0) ? "Successful\nPlease Launch your Game" : "Failed\n- Make sure your game is Fullscreen Windowed or Windowed\n- Make sure any Security or AntiVirus's you have are 'FULLY' disabled\n- If you're on Windows 7, set your Windows 7 Desktop Theme as an 'Aero' Theme\n\nNote: In 'UNSUAL' cases, you 'MAY' need to 'UNINSTALL' your AntiVirus as it is possible some AntiVirus's will not 'DISABLE' completely even if the AntiVirus is set as 'DISABLED'."));
											}
											Environment.Exit(0);
										}).Start();
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.bunifuTransition3.HideSync(this.loading, false, null);
										}));
										Thread.Sleep(5000);
										Environment.Exit(0);
									}
								}
								else
								{
									bool flag11 = DownloadObj is error;
									if (flag11)
									{
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.requestFailed.Text = "Download Error: " + ((error)DownloadObj).message;
											this.requestFailed.Visible = true;
										}));
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.bunifuTransition3.HideSync(this.loading, false, null);
										}));
										this.Busy = false;
										return;
									}
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										this.requestFailed.Text = "Download Error: Unknown Error";
										this.requestFailed.Visible = true;
									}));
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										this.bunifuTransition3.HideSync(this.loading, false, null);
									}));
									this.Busy = false;
									return;
								}
							}
						}
					}
					this.Busy = false;
				}).Start();
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000069ED File Offset: 0x00004BED
		private void ShowLogs_Click(object sender, EventArgs e)
		{
			new Logs().Show();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000069FC File Offset: 0x00004BFC
		private void slidingPanel_Click(object sender, EventArgs e)
		{
			bool flag = this.sideBar.Width == 50;
			if (flag)
			{
				this.sideBar.Visible = true;
				this.sideBar.Width = 300;
				this.productsPanel.Height = 400;
				this.panel1.Width -= 250;
				this.bunifuTransition1.ShowSync(this.sideBar, false, null);
				this.bunifuTransition2.ShowSync(this.memberAvatar, false, null);
			}
			else
			{
				this.bunifuTransition2.Hide(this.memberAvatar, false, null);
				this.sideBar.Visible = false;
				this.sideBar.Width = 50;
				this.productsPanel.Height = 500;
				this.panel1.Width += 250;
				this.bunifuTransition1.ShowSync(this.sideBar, false, null);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006B00 File Offset: 0x00004D00
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag = keyData == Keys.Down;
			if (flag)
			{
				bool flag2 = this.flowLayoutPanel1.Bottom > 50;
				if (flag2)
				{
					this.flowLayoutPanel1.Top -= 25;
				}
				this.flowLayoutPanel1.PerformLayout();
			}
			else
			{
				bool flag3 = keyData == Keys.Up;
				if (flag3)
				{
					bool flag4 = this.flowLayoutPanel1.Top < 0;
					if (flag4)
					{
						this.flowLayoutPanel1.Top += 25;
					}
					this.flowLayoutPanel1.PerformLayout();
				}
			}
			return true;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006B94 File Offset: 0x00004D94
		private void CheatListTab_Click(object sender, EventArgs e)
		{
			this.flowLayoutPanel1.Focus();
			BunifuFlatButton button = (BunifuFlatButton)sender;
			foreach (object obj in this.flowLayoutPanel1.Controls)
			{
				BunifuFlatButton control = (BunifuFlatButton)obj;
				bool flag = control.selected && button != control;
				if (flag)
				{
					control.selected = false;
				}
			}
			bool flag2 = button.Tag is GroupControl;
			if (flag2)
			{
				GroupControl GroupControl = (GroupControl)button.Tag;
				bool isProductGroup = GroupControl.IsProductGroup;
				if (isProductGroup)
				{
					bool flag3 = !GroupControl.GroupExpanded;
					if (flag3)
					{
						button.Iconimage_right = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "DropUp.png").Value));
						int groupIndex = this.flowLayoutPanel1.Controls.IndexOf(button) + 1;
						IEnumerable<product> source = this.products;
						Func<product, bool> predicate;
						Func<product, bool> <>9__2;
						if ((predicate = <>9__2) == null)
						{
							predicate = (<>9__2 = ((product product) => product.group == GroupControl.Group.uid));
						}
						foreach (product product2 in source.Where(predicate))
						{
							BunifuFlatButton CheatListTab = new BunifuFlatButton();
							CheatListTab.Tag = product2;
							CheatListTab.Activecolor = Color.FromArgb(0, 102, 204);
							CheatListTab.BackColor = Color.FromArgb(30, 37, 47);
							CheatListTab.BackgroundImageLayout = ImageLayout.Stretch;
							CheatListTab.BorderRadius = 0;
							CheatListTab.Cursor = Cursors.Hand;
							CheatListTab.DisabledColor = Color.Gray;
							CheatListTab.Iconcolor = Color.Transparent;
							CheatListTab.Iconimage = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "Logo (40x40).gif").Value));
							Downloads downloads = new Downloads();
							downloads.ProcessCompleted += this.Downloads_ProcessCompleted;
							downloads.DownloadProductImages("https://api.maverickcheats.net/?AppID=" + Brand.AppID + "&Request=Photo&Type=Product&UID=" + product2.uid.ToString(), CheatListTab.limage);
							CheatListTab.Iconimage_right = null;
							CheatListTab.Iconimage_right_Selected = null;
							CheatListTab.Iconimage_Selected = null;
							CheatListTab.IconMarginLeft = 0;
							CheatListTab.IconMarginRight = 0;
							CheatListTab.IconRightVisible = true;
							CheatListTab.IconRightZoom = 65.0;
							CheatListTab.IconVisible = true;
							CheatListTab.IconZoom = 65.0;
							CheatListTab.IsTab = true;
							CheatListTab.Name = "button";
							CheatListTab.Normalcolor = Color.FromArgb(30, 37, 47);
							CheatListTab.OnHovercolor = Color.FromArgb(0, 102, 204);
							CheatListTab.OnHoverTextColor = Color.White;
							CheatListTab.Size = new Size(300, 49);
							CheatListTab.TabIndex = groupIndex++;
							CheatListTab.Text = "  " + product2.name;
							CheatListTab.TextAlign = ContentAlignment.MiddleLeft;
							CheatListTab.Textcolor = Color.White;
							CheatListTab.TextFont = new Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
							CheatListTab.Click += this.CheatListTab_Click;
							CheatListTab.MouseDown += this.CheatListTab_MouseDown;
							CheatListTab.MouseEnter += this.CheatListTabs_Enter;
							CheatListTab.MouseLeave += this.CheatListTabs_Leave;
							this.flowLayoutPanel1.Controls.Add(CheatListTab);
							this.flowLayoutPanel1.Controls.SetChildIndex(CheatListTab, CheatListTab.TabIndex);
							GroupControl.GroupChildren.Add(CheatListTab);
						}
						GroupControl.GroupExpanded = true;
						button.Tag = GroupControl;
					}
					else
					{
						button.Iconimage_right = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "DropDown.png").Value));
						foreach (Control Control in GroupControl.GroupChildren)
						{
							this.flowLayoutPanel1.Controls.Remove(Control);
						}
						GroupControl.GroupExpanded = false;
						button.Tag = GroupControl;
					}
				}
			}
			else
			{
				bool flag4 = button.Tag is product;
				if (flag4)
				{
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007114 File Offset: 0x00005314
		private void CheatListTab_MouseDown(object sender, EventArgs e)
		{
			BunifuFlatButton button = (BunifuFlatButton)sender;
			BunifuFlatButton control;
			foreach (object obj in this.flowLayoutPanel1.Controls)
			{
				control = (BunifuFlatButton)obj;
				bool flag = control.selected && button != control;
				if (flag)
				{
					control.selected = false;
				}
			}
			bool flag2 = ((MouseEventArgs)e).Clicks < 2;
			if (!flag2)
			{
				bool busy = this.Busy;
				if (!busy)
				{
					new Thread(delegate()
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.requestFailed.Text = "";
							this.requestFailed.Visible = false;
						}));
						this.Busy = true;
						bool flag3 = !this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Any((BunifuFlatButton control) => control.selected);
						if (!flag3)
						{
							bool flag4 = !(this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Find((BunifuFlatButton control) => control.selected).Tag is product);
							if (flag4)
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.requestFailed.Text = "The Selected Tab is not a Cheat, Open the Group and select a Product!";
									this.requestFailed.Visible = true;
								}));
							}
							else
							{
								product product = (product)this.flowLayoutPanel1.Controls.Cast<BunifuFlatButton>().ToList<BunifuFlatButton>().Find((BunifuFlatButton control) => control.selected).Tag;
								bool flag5 = product.status == 0;
								if (flag5)
								{
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										this.requestFailed.Text = "We're sorry, this cheat is being updated by the Development Team.";
										this.requestFailed.Visible = true;
									}));
								}
								else
								{
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										this.bunifuTransition3.ShowSync(this.loading, false, null);
									}));
									string Folder = Path.GetTempPath() + Path.GetRandomFileName() + "\\";
									Stopwatch stopwatch = new Stopwatch();
									stopwatch.Start();
									object DownloadObj = this.RestAPI.Download("Product", product, this.token);
									bool flag6 = DownloadObj is byte[];
									if (flag6)
									{
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.Notification.Text = "Download Finished - " + stopwatch.Elapsed.TotalMilliseconds.ToString() + "ms";
											this.Notification.Visible = true;
										}));
										bool flag7 = !Directory.Exists(Folder);
										if (flag7)
										{
											Directory.CreateDirectory(Folder);
										}
										else
										{
											try
											{
												foreach (string FilePath in Directory.GetFiles(Folder))
												{
													try
													{
														Process.GetProcessesByName(Path.GetFileNameWithoutExtension(FilePath)).ToList<Process>().ForEach(delegate(Process process)
														{
															process.Kill();
														});
													}
													catch (Exception ex)
													{
													}
													try
													{
														File.Delete(FilePath);
													}
													catch (Exception ex2)
													{
													}
												}
											}
											catch (Exception ex3)
											{
											}
										}
										Thread.Sleep(100);
										File.SetAttributes(Folder, FileAttributes.Hidden | FileAttributes.System);
										string Run_FileName = Path.GetRandomFileName();
										using (ZipArchive Archive = new ZipArchive(new MemoryStream((byte[])DownloadObj), ZipArchiveMode.Read))
										{
											foreach (ZipArchiveEntry Entry in Archive.Entries)
											{
												bool flag8 = !Directory.Exists(Path.GetDirectoryName(Folder + Entry.FullName));
												if (flag8)
												{
													Directory.CreateDirectory(Path.GetDirectoryName(Folder + Entry.FullName));
												}
												bool flag9 = Entry.Name.Length == 0;
												if (flag9)
												{
													Directory.CreateDirectory(Path.GetDirectoryName(Folder + Entry.FullName));
												}
												else
												{
													bool flag10 = !File.Exists(Folder + Entry.FullName);
													if (flag10)
													{
														bool flag11 = Entry.Name.ToLower().Contains("run");
														if (flag11)
														{
															string New_FileName = Entry.Name.Replace("run", Run_FileName);
															using (FileStream FileStream = new FileStream(Folder + New_FileName, FileMode.Create, FileAccess.Write))
															{
																using (Stream Stream = Entry.Open())
																{
																	Stream.CopyTo(FileStream);
																}
															}
															File.SetAttributes(Folder + New_FileName, FileAttributes.Hidden | FileAttributes.System);
														}
														else
														{
															Entry.ExtractToFile(Folder + Entry.FullName);
															File.SetAttributes(Folder + Entry.FullName, FileAttributes.Hidden | FileAttributes.System);
														}
													}
												}
											}
										}
										bool flag12 = !File.Exists(Folder + Run_FileName + ".exe");
										if (flag12)
										{
											MessageBox.Show("Injection Error: {MissingInjector}");
										}
										else
										{
											try
											{
												Process run_process = new Process();
												ProcessStartInfo run_startInfo = new ProcessStartInfo
												{
													WorkingDirectory = Folder,
													FileName = Folder + Run_FileName + ".exe",
													Arguments = this.token.authtoken + " " + product.uid.ToString(),
													RedirectStandardOutput = false,
													UseShellExecute = false,
													Verb = "runas"
												};
												run_process.StartInfo = run_startInfo;
												run_process.Start();
											}
											catch (Win32Exception ex4)
											{
												MessageBox.Show("Injector could not be started due to an error.\nThis is typically caused by Windows Defender or a third party Anti-Virus.\n\nWe have copied the Error to your Clipboard, paste the error into a ticket and send it to Staff!\n" + ex4.ToString(), "");
												Clipboard.SetText(ex4.ToString());
											}
											Thread.Sleep(2500);
											new Thread(delegate()
											{
												bool flag14 = product.intern == 1;
												if (flag14)
												{
													MessageBox.Show("Injector: " + ((Process.GetProcessesByName(Run_FileName).Length != 0) ? ("Pre-Loaded\n" + ((Process.GetProcessesByName(product.targetprocess).Length == 0) ? "You have 60 seconds to start your game!\n" : "") + "Press'Ok' to close the Launcher, this Auto Closes after 5s!") : "Failed to Launch\n( Make sure your AntiVirus is Disabled and that you start your game AFTER you Inject )"));
												}
												else
												{
													MessageBox.Show("External Execution: " + ((Process.GetProcessesByName(Run_FileName).Length != 0) ? "Successful\nPlease Launch your Game" : "Failed\n- Make sure your game is Fullscreen Windowed or Windowed\n- Make sure any Security or AntiVirus's you have are 'FULLY' disabled\n- If you're on Windows 7, set your Windows 7 Desktop Theme as an 'Aero' Theme\n\nNote: In 'UNSUAL' cases, you 'MAY' need to 'UNINSTALL' your AntiVirus as it is possible some AntiVirus's will not 'DISABLE' completely even if the AntiVirus is set as 'DISABLED'."));
												}
												Environment.Exit(0);
											}).Start();
											base.BeginInvoke(new MethodInvoker(delegate()
											{
												this.bunifuTransition3.HideSync(this.loading, false, null);
											}));
											Thread.Sleep(5000);
											Environment.Exit(0);
										}
									}
									else
									{
										bool flag13 = DownloadObj is error;
										if (flag13)
										{
											base.BeginInvoke(new MethodInvoker(delegate()
											{
												this.requestFailed.Text = "Download Error: " + ((error)DownloadObj).message;
												this.requestFailed.Visible = true;
											}));
											base.BeginInvoke(new MethodInvoker(delegate()
											{
												this.bunifuTransition3.HideSync(this.loading, false, null);
											}));
											this.Busy = false;
											return;
										}
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.requestFailed.Text = "Download Error: Unknown Error";
											this.requestFailed.Visible = true;
										}));
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.bunifuTransition3.HideSync(this.loading, false, null);
										}));
										this.Busy = false;
										return;
									}
								}
							}
						}
						this.Busy = false;
					}).Start();
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000071D4 File Offset: 0x000053D4
		private void CheatListTabs_Enter(object sender, EventArgs e)
		{
			((BunifuFlatButton)sender).IconZoom = ((BunifuFlatButton)sender).IconZoom + 10.0;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000071F8 File Offset: 0x000053F8
		private void CheatListTabs_Leave(object sender, EventArgs e)
		{
			((BunifuFlatButton)sender).IconZoom = ((BunifuFlatButton)sender).IconZoom - 10.0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000721C File Offset: 0x0000541C
		private void topBar_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.MouseDownLocation = e.Location;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000724C File Offset: 0x0000544C
		private void topBar_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left = e.X + base.Left - this.MouseDownLocation.X;
				base.Top = e.Y + base.Top - this.MouseDownLocation.Y;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000072B0 File Offset: 0x000054B0
		private void headerPicture_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.MouseDownLocation = e.Location;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000072E0 File Offset: 0x000054E0
		private void headerPicture_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left = e.X + base.Left - this.MouseDownLocation.X;
				base.Top = e.Y + base.Top - this.MouseDownLocation.Y;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007341 File Offset: 0x00005541
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000734B File Offset: 0x0000554B
		private void memberAvatar_Click(object sender, EventArgs e)
		{
			Process.Start(this.token.member.profileUrl);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007364 File Offset: 0x00005564
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000736E File Offset: 0x0000556E
		private void NotificationList_MouseWheel(object sender, MouseEventArgs e)
		{
			Main.SendMessage(this.NotificationList.Handle, 277U, (e.Delta <= 0) ? ((UIntPtr)1UL) : ((UIntPtr)0UL), (IntPtr)0);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000073A6 File Offset: 0x000055A6
		private void SupportTicketList_MouseWheel(object sender, MouseEventArgs e)
		{
			Main.SendMessage(this.SupportTicketList.Handle, 277U, (e.Delta <= 0) ? ((UIntPtr)1UL) : ((UIntPtr)0UL), (IntPtr)0);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000073DE File Offset: 0x000055DE
		private void NewsfeedImage_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000073E1 File Offset: 0x000055E1
		private void NotificationsImage_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000073E4 File Offset: 0x000055E4
		private void SupportTicketsImage_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000073E7 File Offset: 0x000055E7
		private void SupportTicketList_DrawItem(object sender, DrawItemEventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000073EA File Offset: 0x000055EA
		private void SupportTicketList_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 50;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000073F6 File Offset: 0x000055F6
		private void NotificationList_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawFocusRectangle();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007400 File Offset: 0x00005600
		private void NotificationList_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 50;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000740C File Offset: 0x0000560C
		private void NewsfeedList_DrawItem(object sender, DrawItemEventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000740F File Offset: 0x0000560F
		private void NewsfeedList_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 50;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000741C File Offset: 0x0000561C
		private void requestFailed_VisibleChanged(object sender, EventArgs e)
		{
			bool visible = this.requestFailed.Visible;
			if (visible)
			{
				this.launchButton.Location = new Point(this.launchButton.Location.X, 410);
			}
			else
			{
				this.launchButton.Location = new Point(this.launchButton.Location.X, 445);
			}
		}

		// Token: 0x04000041 RID: 65
		public bool Busy = false;

		// Token: 0x04000042 RID: 66
		public REST RestAPI = new REST();

		// Token: 0x04000043 RID: 67
		public token token;

		// Token: 0x04000044 RID: 68
		public List<group> groups;

		// Token: 0x04000045 RID: 69
		public List<product> products;

		// Token: 0x04000046 RID: 70
		private Point MouseDownLocation;
	}
}
