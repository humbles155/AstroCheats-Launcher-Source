using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AuthLib;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using Main.Functions;
using Microsoft.Win32;
using NetworkTypes;
using WindowsFormsControlLibrary1;

namespace Main
{
	// Token: 0x0200000B RID: 11
	public partial class Login : Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002884 File Offset: 0x00000A84
		public Login()
		{
			AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs arg)
			{
				this.HandleUnhandledException(arg.ExceptionObject as Exception);
			};
			this.InitializeComponent();
			this.pictureBox1.Image = Image.FromStream(new MemoryStream(EmbeddedResource.EmbeddedResources.First((KeyValuePair<string, byte[]> resource) => resource.Key == "Logo (40x40).gif").Value));
			object CompanyObj;
			bool flag = (CompanyObj = this.RestAPI.Company()) is company;
			if (flag)
			{
				company company = (company)CompanyObj;
				Logs.LogEntries.Add("Form Loaded");
				Brand.config = new Config(company);
				Downloads Downloads = new Downloads();
				Downloads.ProcessCompleted += this.Download_ProcessCompleted;
				Downloads.DownloadHeader(Brand.config.theme.headerUrl, this.headerPicture);
				Downloads.DownloadLogo(Brand.config.theme.logoUrl, this.logoPicture);
			}
			else
			{
				bool flag2 = CompanyObj is error;
				if (flag2)
				{
					MessageBox.Show("Theme Failure - " + ((error)CompanyObj).message);
				}
				else
				{
					MessageBox.Show("Theme Failure - Unkown Error");
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029DF File Offset: 0x00000BDF
		public void HandleUnhandledException(Exception ex)
		{
			this.RestAPI.Log(ex.ToString(), string.Join(Environment.NewLine, Logs.LogEntries));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002A04 File Offset: 0x00000C04
		private void Download_ProcessCompleted(object sender, ProcessEventArgs e)
		{
			Logs.LogEntries.Add("Process " + (e.IsCompleted ? "Completed Successfully" : "failed"));
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				e.PictureBox.Image = e.Image;
			}));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A60 File Offset: 0x00000C60
		private void Login_Load(object sender, EventArgs e)
		{
			Login.Busy = true;
			new Thread(delegate()
			{
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.pictureBox1.Visible = true;
				}));
				bool flag = Brand.Version != Brand.config.company.version.number;
				if (flag)
				{
					MessageBox.Show("Updating! - 'Updater.exe'");
					for (;;)
					{
						foreach (Process process3 in from process in Process.GetProcesses()
						where process.ProcessName.ToLower() == "updater" || process.ProcessName.ToLower() == "run"
						select process)
						{
							try
							{
								process3.CloseMainWindow();
								process3.Close();
								process3.Kill();
							}
							catch
							{
							}
						}
						Logs.LogEntries.Add("Starting Update Protocol");
						object UpdateObj = this.RestAPI.Update("Updater");
						bool flag2 = UpdateObj is byte[];
						if (flag2)
						{
							using (ZipArchive archive = new ZipArchive(new MemoryStream((byte[])UpdateObj), ZipArchiveMode.Read))
							{
								foreach (ZipArchiveEntry file in archive.Entries)
								{
									bool flag3 = File.Exists(Environment.CurrentDirectory + "\\" + file.Name);
									if (flag3)
									{
										try
										{
											File.Delete(Environment.CurrentDirectory + "\\" + file.Name);
										}
										catch (Exception ex)
										{
											MessageBox.Show("Failed to Delete the File: " + file.FullName + "\nERROR:\n" + ex.ToString());
											continue;
										}
									}
									file.ExtractToFile(Environment.CurrentDirectory + "\\" + file.Name);
									Logs.LogEntries.Add("Extracting File: " + file.Name);
								}
							}
						}
						else
						{
							bool flag4 = UpdateObj is error;
							if (flag4)
							{
								MessageBox.Show("Update Failure - " + ((error)UpdateObj).message);
							}
							else
							{
								MessageBox.Show("Update Failure - Unkown Error");
							}
						}
						bool flag5 = File.Exists(Environment.CurrentDirectory + "\\Updater.exe");
						if (flag5)
						{
							break;
						}
						Logs.LogEntries.Add("AutoUpdater Executable Missing! -> Recovery: Trying to download AutoUpdater");
					}
					Logs.LogEntries.Add("Updater Executable Found!");
					Process process2 = new Process();
					ProcessStartInfo startInfo = new ProcessStartInfo
					{
						WorkingDirectory = Environment.CurrentDirectory + "\\",
						Arguments = Brand.AppID,
						FileName = Environment.CurrentDirectory + "\\Updater.exe",
						UseShellExecute = true,
						Verb = "runas"
					};
					process2.StartInfo = startInfo;
					process2.Start();
					Environment.Exit(0);
				}
				object OnlineCountObj;
				bool flag6 = (OnlineCountObj = this.RestAPI.OnlineCount()) is int;
				if (flag6)
				{
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						Control usersOnline = this.UsersOnline;
						object onlineCountObj = OnlineCountObj;
						usersOnline.Text = ((onlineCountObj != null) ? onlineCountObj.ToString() : null) + " Users Online";
					}));
				}
				bool flag7 = Environment.GetCommandLineArgs().Length != 0;
				if (flag7)
				{
					Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
					foreach (string arg in Environment.GetCommandLineArgs())
					{
						Logs.LogEntries.Add(arg);
						bool flag8 = Login.Contains(arg, "code") && Login.Contains(arg, "state");
						if (flag8)
						{
							string code = Login.Get(arg, "code");
							string state = Login.Get(arg, "state");
							Logs.LogEntries.Add("Code: " + code);
							Logs.LogEntries.Add("State: " + state);
							object obj2;
							bool flag9 = (obj2 = this.RestAPI.OAuth_Setup(code)) is string;
							if (flag9)
							{
								string AccessToken = (string)obj2;
								Logs.LogEntries.Add(code);
								Logs.LogEntries.Add(state);
								Logs.LogEntries.Add(FingerPrint.HWID());
								Logs.LogEntries.Add(AccessToken);
								StreamWriter sw = new StreamWriter("autologin.data");
								sw.WriteLine("True");
								sw.WriteLine(Encryption.crypt(AccessToken));
								sw.WriteLine("");
								sw.WriteLine("");
								sw.Close();
								Logs.LogEntries.Add("Wrote AutoLogin Data");
							}
							else
							{
								bool flag10 = obj2 is error;
								if (flag10)
								{
									error error = (error)obj2;
									Logs.LogEntries.Add(error.message);
								}
							}
						}
					}
				}
				bool flag11 = File.Exists("autologin.data");
				if (flag11)
				{
					bool flag12 = File.ReadAllLines("autologin.data").Length < 4 || File.ReadAllLines("autologin.data").Length > 4;
					if (flag12)
					{
						try
						{
							Logs.LogEntries.Add("autologin.data is corrupted");
							File.Delete("autologin.data");
							Logs.LogEntries.Add("autologin.data deleted");
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Text = "You need to Re-Login";
							}));
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Visible = true;
							}));
						}
						catch
						{
							MessageBox.Show("AutoLogin File cannot be removed");
						}
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.pictureBox1.Visible = false;
						}));
						Login.Busy = false;
						return;
					}
					Logs.LogEntries.Add("Loading AutoLogin Data");
					StreamReader sr = new StreamReader("autologin.data");
					string useAutoLogin = sr.ReadLine();
					string oauth2Token = sr.ReadLine();
					string username = sr.ReadLine();
					string password = sr.ReadLine();
					sr.Close();
					sr.Dispose();
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.rememberMeCheckBox.Checked = !Convert.ToBoolean(useAutoLogin);
						this.autoLoginCheckBox.Checked = Convert.ToBoolean(useAutoLogin);
					}));
					Logs.LogEntries.Add("Decrypting AutoLogin Data");
					bool flag13 = username == "" || password == "";
					if (flag13)
					{
						Logs.LogEntries.Add("Username and Password are not included in the AutoLogin File!");
					}
					else
					{
						bool flag14 = (username = Encryption.decrypt(username)) == null || (password = Encryption.decrypt(password)) == null;
						if (flag14)
						{
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Text = "You need to Re-Login!";
							}));
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Visible = true;
							}));
							username = "";
							password = "";
						}
						else
						{
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.Password.PasswordChar = '*';
								this.Username.Text = username;
								this.Password.Text = password;
							}));
						}
					}
					bool flag15 = Convert.ToBoolean(useAutoLogin) && oauth2Token != "";
					if (flag15)
					{
						Logs.LogEntries.Add("OAuth2 Login Method!");
						object obj;
						bool flag16 = (obj = this.RestAPI.OAuth_Auth(Encryption.decrypt(oauth2Token))) is token;
						if (flag16)
						{
							token token = (token)obj;
							Logs.LogEntries.Add("Login Found-" + token.authtoken);
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								new Main(token).Show();
								this.Hide();
							}));
						}
						else
						{
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Text = ((error)obj).message;
							}));
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								this.failedLogin.Visible = true;
							}));
						}
					}
					else
					{
						bool flag17 = Convert.ToBoolean(useAutoLogin) && username != "" && password != "";
						if (flag17)
						{
							object Output;
							bool flag18 = (Output = this.RestAPI.Login(username, password, FingerPrint.HWID(), FingerPrint.HWID_Info())) != null;
							if (flag18)
							{
								bool flag19 = Output is token;
								if (flag19)
								{
									Logs.LogEntries.Add("Login Found-" + ((token)Output).authtoken);
									base.BeginInvoke(new MethodInvoker(delegate()
									{
										new Main((token)Output).Show();
										this.Hide();
									}));
								}
								else
								{
									bool flag20 = Output is error;
									if (flag20)
									{
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.failedLogin.Text = ((error)Output).message;
										}));
										base.BeginInvoke(new MethodInvoker(delegate()
										{
											this.failedLogin.Visible = true;
										}));
									}
								}
							}
							else
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.failedLogin.Text = "Unknown Error";
								}));
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.failedLogin.Visible = true;
								}));
							}
						}
						else
						{
							bool flag21 = !Convert.ToBoolean(useAutoLogin) && username != "" && password != "";
							if (flag21)
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.rememberMeCheckBox.Checked = true;
									this.Username.Text = username;
									this.Password.Text = password;
								}));
							}
						}
					}
					Logs.LogEntries.Add("Decrypted AutoLogin Data");
				}
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.pictureBox1.Visible = false;
				}));
				Login.Busy = false;
			}).Start();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002A80 File Offset: 0x00000C80
		private void loginButton_Click(object sender, EventArgs e)
		{
			bool busy = Login.Busy;
			if (!busy)
			{
				Login.Busy = true;
				new Thread(delegate()
				{
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.failedLogin.Text = "";
						this.failedLogin.Visible = false;
					}));
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.pictureBox1.Visible = true;
					}));
					object Output;
					bool flag = (Output = this.RestAPI.Login(this.Username.Text, this.Password.Text, FingerPrint.HWID(), FingerPrint.HWID_Info())) != null;
					if (flag)
					{
						bool flag2 = Output is token;
						if (flag2)
						{
							bool flag3 = File.Exists("autologin.data");
							if (flag3)
							{
								try
								{
									Logs.LogEntries.Add("Deleting AutoLogin.data");
									File.Delete("autologin.data");
									Logs.LogEntries.Add("Deleted AutoLogin.data");
								}
								catch
								{
									MessageBox.Show("Auto Login File cannot be removed");
								}
							}
							bool @checked = this.autoLoginCheckBox.Checked;
							if (@checked)
							{
								StreamWriter sw = new StreamWriter("autologin.data");
								sw.WriteLine("True");
								sw.WriteLine("");
								sw.WriteLine(Encryption.crypt(this.Username.Text));
								sw.WriteLine(Encryption.crypt(this.Password.Text));
								sw.Close();
							}
							else
							{
								bool checked2 = this.rememberMeCheckBox.Checked;
								if (checked2)
								{
									StreamWriter sw2 = new StreamWriter("autologin.data");
									sw2.WriteLine("False");
									sw2.WriteLine("");
									sw2.WriteLine(Encryption.crypt(this.Username.Text));
									sw2.WriteLine(Encryption.crypt(this.Password.Text));
									sw2.Close();
								}
								else
								{
									bool flag4 = File.Exists("autologin.data");
									if (flag4)
									{
										try
										{
											Logs.LogEntries.Add("Deleting AutoLogin.data");
											File.Delete("autologin.data");
											Logs.LogEntries.Add("Deleted AutoLogin.data");
										}
										catch
										{
											MessageBox.Show("Auto Login File cannot be removed");
										}
									}
								}
							}
							base.BeginInvoke(new MethodInvoker(delegate()
							{
								new Main((token)Output).Show();
								this.Hide();
							}));
						}
						else
						{
							bool flag5 = Output is error;
							if (flag5)
							{
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.failedLogin.Text = ((error)Output).message;
								}));
								base.BeginInvoke(new MethodInvoker(delegate()
								{
									this.failedLogin.Visible = true;
								}));
							}
						}
					}
					else
					{
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.failedLogin.Text = (string)Output;
						}));
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.failedLogin.Visible = true;
						}));
					}
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.pictureBox1.Visible = false;
					}));
					Login.Busy = false;
				}).Start();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002AB8 File Offset: 0x00000CB8
		private void loginForum_Click(object sender, EventArgs e)
		{
			bool busy = Login.Busy;
			if (!busy)
			{
				Login.Busy = true;
				new Thread(delegate()
				{
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.failedLogin.Text = "";
						this.failedLogin.Visible = false;
					}));
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.bunifuTransition2.ShowSync(this.pictureBox1, false, null);
					}));
					RegistryKey Key = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Classes", true).CreateSubKey("alert");
					Key.SetValue("URL Protocol", "mcauth");
					Key.CreateSubKey("shell\\open\\command").SetValue("", "\"" + Process.GetCurrentProcess().MainModule.FileName + "\" \"%1\"");
					Thread.Sleep(1000);
					Logs.LogEntries.Add("Attempting to AutoLogin with OAuth");
					string PrivateKey = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace("+", "").Replace("=", "").Replace("/", "");
					Process process = Process.Start(Brand.config.OAuthLink);
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.Notification.Text = "Check your Web Browser";
						this.Notification.Visible = true;
					}));
					Login.Busy = false;
				}).Start();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002AEE File Offset: 0x00000CEE
		private void loginForum_MouseEnter(object sender, EventArgs e)
		{
			this.loginForum.ForeColor = Color.FromArgb(0, 102, 204);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002B0A File Offset: 0x00000D0A
		private void loginForum_MouseLeave(object sender, EventArgs e)
		{
			this.loginForum.ForeColor = Color.White;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002B20 File Offset: 0x00000D20
		private void Username_Enter(object sender, EventArgs e)
		{
			bool flag = this.Username.Text == "" || this.Username.Text == "Username";
			if (flag)
			{
				this.Username.Text = "";
			}
			this.bunifuSeparator1.Visible = false;
			this.bunifuSeparator1.LineColor = Color.FromArgb(0, 102, 204);
			this.bunifuTransition1.ShowSync(this.bunifuSeparator1, false, null);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private void Username_Leave(object sender, EventArgs e)
		{
			bool flag = this.Username.Text == "";
			if (flag)
			{
				this.Username.Text = "Username";
			}
			this.bunifuSeparator1.LineColor = Color.Gray;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002BFC File Offset: 0x00000DFC
		private void Password_Enter(object sender, EventArgs e)
		{
			bool flag = this.Password.Text == "" || this.Password.Text == "Password";
			if (flag)
			{
				this.Password.PasswordChar = '*';
				this.Password.Text = "";
			}
			this.bunifuSeparator2.Visible = false;
			this.bunifuSeparator2.LineColor = Color.FromArgb(0, 102, 204);
			this.bunifuTransition1.ShowSync(this.bunifuSeparator2, false, null);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002C98 File Offset: 0x00000E98
		private void Password_Leave(object sender, EventArgs e)
		{
			bool flag = this.Password.Text == "";
			if (flag)
			{
				this.Password.PasswordChar = '\0';
				this.Password.Text = "Password";
			}
			this.bunifuSeparator2.LineColor = Color.Gray;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CF0 File Offset: 0x00000EF0
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.MouseDownLocation = e.Location;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002D20 File Offset: 0x00000F20
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left = e.X + base.Left - this.MouseDownLocation.X;
				base.Top = e.Y + base.Top - this.MouseDownLocation.Y;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D81 File Offset: 0x00000F81
		private void RememberMeLabel_Click(object sender, EventArgs e)
		{
			this.rememberMeCheckBox.Checked = !this.rememberMeCheckBox.Checked;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002D9E File Offset: 0x00000F9E
		private void AutoLoginLabel_Click(object sender, EventArgs e)
		{
			this.autoLoginCheckBox.Checked = !this.autoLoginCheckBox.Checked;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002DBB File Offset: 0x00000FBB
		private void ShowLogs_Click(object sender, EventArgs e)
		{
			new Logs().Show();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public static bool Contains(string Data, string Variable)
		{
			bool flag = !Data.Contains(Variable + "=");
			return !flag;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002E04 File Offset: 0x00001004
		public static string Get(string Data, string Variable)
		{
			bool flag = !Data.Contains(Variable + "=");
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				Data = Data.Remove(0, Data.IndexOf('?') + 1);
				string[] posted = Data.Split(new char[]
				{
					'&'
				});
				foreach (string post in posted)
				{
					bool flag2 = post.Contains(Variable + "=");
					if (flag2)
					{
						return post.Replace(Variable + "=", "");
					}
				}
				result = Data;
			}
			return result;
		}

		// Token: 0x04000019 RID: 25
		public static bool Busy;

		// Token: 0x0400001A RID: 26
		public REST RestAPI = new REST();

		// Token: 0x0400001B RID: 27
		private Point MouseDownLocation;
	}
}
