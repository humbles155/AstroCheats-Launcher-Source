using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using NetworkTypes;

namespace Main.Functions
{
	// Token: 0x02000012 RID: 18
	public class FingerPrint
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000B428 File Offset: 0x00009628
		public static string HWID()
		{
			bool flag = FingerPrint.hwid == "" || FingerPrint.hwid_info == null;
			if (flag)
			{
				Stopwatch timer = new Stopwatch();
				timer.Start();
				File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + "-------------------------" + DateTime.Now.ToString() + "-------------------------");
				FingerPrint.BIOS = FingerPrint.biosId();
				Console.WriteLine(FingerPrint.BIOS + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.BASE = FingerPrint.baseId();
				Console.WriteLine(FingerPrint.BASE + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.CPU = FingerPrint.cpuId();
				Console.WriteLine(FingerPrint.CPU + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.VIDEO = FingerPrint.videoId();
				Console.WriteLine(FingerPrint.VIDEO + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.SYSTEM = FingerPrint.OSid();
				Console.WriteLine(FingerPrint.SYSTEM + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.DISKS = FingerPrint.diskId();
				Console.WriteLine(FingerPrint.DISKS + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + "-------------------------" + DateTime.Now.ToString() + "-------------------------");
				Console.WriteLine("Found Hardware Details in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.hwid = FingerPrint.GetHash(string.Concat(new string[]
				{
					"BIOS >> ",
					FingerPrint.GetHash(FingerPrint.BIOS, false),
					"\nBASE >> ",
					FingerPrint.GetHash(FingerPrint.BASE, false),
					"\nCPU >> ",
					FingerPrint.GetHash(FingerPrint.CPU, false),
					"\nVIDEO >> ",
					FingerPrint.GetHash(FingerPrint.VIDEO, false),
					"\nOS >> ",
					FingerPrint.GetHash(FingerPrint.SYSTEM, false),
					"\nDISKS >> ",
					FingerPrint.GetHash(FingerPrint.DISKS, false)
				}), true);
				FingerPrint.hwid_info = new hwid_info(FingerPrint.MachineName, FingerPrint.BIOS, FingerPrint.BASE, FingerPrint.CPU, FingerPrint.VIDEO, FingerPrint.DISKS, FingerPrint.SYSTEM);
				Console.WriteLine("Hashed all Hardware Serials in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				Console.WriteLine("Hash Hardware Serials: " + FingerPrint.hwid);
			}
			else
			{
				Console.WriteLine("Fingerprint already cached");
			}
			return FingerPrint.hwid;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B788 File Offset: 0x00009988
		public static hwid_info HWID_Info()
		{
			bool flag = FingerPrint.hwid == "" || FingerPrint.hwid_info == null;
			if (flag)
			{
				Stopwatch timer = new Stopwatch();
				timer.Start();
				File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + "-------------------------" + DateTime.Now.ToString() + "-------------------------");
				FingerPrint.BIOS = FingerPrint.biosId();
				Console.WriteLine(FingerPrint.BIOS + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.BASE = FingerPrint.baseId();
				Console.WriteLine(FingerPrint.BASE + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.CPU = FingerPrint.cpuId();
				Console.WriteLine(FingerPrint.CPU + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.VIDEO = FingerPrint.videoId();
				Console.WriteLine(FingerPrint.VIDEO + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.SYSTEM = FingerPrint.OSid();
				Console.WriteLine(FingerPrint.SYSTEM + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.DISKS = FingerPrint.diskId();
				Console.WriteLine(FingerPrint.DISKS + " found in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + "-------------------------" + DateTime.Now.ToString() + "-------------------------");
				Console.WriteLine("Found Hardware Details in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				FingerPrint.hwid = FingerPrint.GetHash(string.Concat(new string[]
				{
					"BIOS >> ",
					FingerPrint.GetHash(FingerPrint.BIOS, false),
					"\nBASE >> ",
					FingerPrint.GetHash(FingerPrint.BASE, false),
					"\nCPU >> ",
					FingerPrint.GetHash(FingerPrint.CPU, false),
					"\nVIDEO >> ",
					FingerPrint.GetHash(FingerPrint.VIDEO, false),
					"\nOS >> ",
					FingerPrint.GetHash(FingerPrint.SYSTEM, false),
					"\nDISKS >> ",
					FingerPrint.GetHash(FingerPrint.DISKS, false)
				}), true);
				FingerPrint.hwid_info = new hwid_info(FingerPrint.MachineName, FingerPrint.BIOS, FingerPrint.BASE, FingerPrint.CPU, FingerPrint.VIDEO, FingerPrint.DISKS, FingerPrint.SYSTEM);
				Console.WriteLine("Hashed all Hardware Serials in " + timer.Elapsed.TotalMilliseconds.ToString() + "ms");
				Console.WriteLine("Hash Hardware Serials: " + FingerPrint.hwid);
			}
			else
			{
				Console.WriteLine("Fingerprint already cached");
			}
			return FingerPrint.hwid_info;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		public static string GetHash(string s, bool seperators = false)
		{
			MD5 sec = new MD5CryptoServiceProvider();
			ASCIIEncoding enc = new ASCIIEncoding();
			byte[] bt = enc.GetBytes(s);
			string result;
			if (seperators)
			{
				result = FingerPrint.GetHexString(sec.ComputeHash(bt));
			}
			else
			{
				result = FingerPrint.GetHexString(sec.ComputeHash(bt)).Replace("-", "");
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000BB40 File Offset: 0x00009D40
		private static string GetHexString(byte[] bt)
		{
			string s = string.Empty;
			for (int i = 0; i < bt.Length; i++)
			{
				byte b = bt[i];
				int j = (int)b;
				int n = j & 15;
				int n2 = j >> 4 & 15;
				bool flag = n2 > 9;
				if (flag)
				{
					s += ((char)(n2 - 10 + 65)).ToString();
				}
				else
				{
					s += n2.ToString();
				}
				bool flag2 = n > 9;
				if (flag2)
				{
					s += ((char)(n - 10 + 65)).ToString();
				}
				else
				{
					s += n.ToString();
				}
				bool flag3 = i + 1 != bt.Length && (i + 1) % 2 == 0;
				if (flag3)
				{
					s += "-";
				}
			}
			return s;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000BC1C File Offset: 0x00009E1C
		private static string identifier(string wmiClass, string wmiProperty)
		{
			ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select " + wmiProperty + " From " + wmiClass);
			ManagementObjectCollection mbsList = mbs.Get();
			string id = "";
			foreach (ManagementBaseObject managementBaseObject in mbsList)
			{
				ManagementObject mo = (ManagementObject)managementBaseObject;
				try
				{
					id = id + mo[wmiProperty].ToString() + ",";
				}
				catch
				{
				}
			}
			return id.TrimEnd(new char[]
			{
				','
			});
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		private static string identifier(string wmiClass, string[] wmiProperties, string where = "")
		{
			ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * FROM " + wmiClass + ((where != "") ? (" WHERE " + where) : ""));
			ManagementObjectCollection mbsList = mbs.Get();
			string id = "";
			foreach (ManagementBaseObject managementBaseObject in mbsList)
			{
				ManagementObject mo = (ManagementObject)managementBaseObject;
				foreach (string property in wmiProperties)
				{
					try
					{
						bool flag = mo[property] != null;
						if (flag)
						{
							id = id + mo[property].ToString() + ",";
						}
					}
					catch
					{
					}
				}
			}
			return id.TrimEnd(new char[]
			{
				','
			});
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		private static string biosId()
		{
			string id = FingerPrint.identifier("Win32_BIOS", new string[]
			{
				"Name",
				"Manufacturer",
				"Version",
				"SerialNumber"
			}, "");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000BE44 File Offset: 0x0000A044
		private static string baseId()
		{
			string id = FingerPrint.identifier("Win32_BaseBoard", new string[]
			{
				"Manufacturer",
				"Product"
			}, "");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		private static string cpuId()
		{
			string id = FingerPrint.identifier("Win32_Processor", new string[]
			{
				"Name",
				"Manufacturer",
				"ProcessorId"
			}, "");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000BF04 File Offset: 0x0000A104
		private static string videoId()
		{
			string id = FingerPrint.identifier("Win32_VideoController", new string[]
			{
				"AdapterCompatibility",
				"VideoProcessor"
			}, "");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000BF60 File Offset: 0x0000A160
		private static string OSid()
		{
			string id = FingerPrint.identifier("Win32_OperatingSystem", new string[]
			{
				"Name",
				"CSName",
				"RegisteredUser",
				"SerialNumber"
			}, "");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		private static string diskId()
		{
			string id = FingerPrint.identifier("Win32_DiskDrive", new string[]
			{
				"Name",
				"Model",
				"SerialNumber"
			}, "Index='0' AND MediaType='Fixed hard disk media'");
			File.AppendAllText(Environment.CurrentDirectory + "\\HWID.txt", Environment.NewLine + id);
			return id;
		}

		// Token: 0x04000070 RID: 112
		private static string MachineName = Environment.MachineName;

		// Token: 0x04000071 RID: 113
		private static string BIOS = "";

		// Token: 0x04000072 RID: 114
		private static string BASE = "";

		// Token: 0x04000073 RID: 115
		private static string CPU = "";

		// Token: 0x04000074 RID: 116
		private static string VIDEO = "";

		// Token: 0x04000075 RID: 117
		private static string DISKS = "";

		// Token: 0x04000076 RID: 118
		private static string SYSTEM = "";

		// Token: 0x04000077 RID: 119
		public static string hwid = "";

		// Token: 0x04000078 RID: 120
		public static hwid_info hwid_info = null;
	}
}
