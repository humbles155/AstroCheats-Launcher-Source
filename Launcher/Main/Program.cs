using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Main
{
	// Token: 0x0200000E RID: 14
	internal static class Program
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000AF94 File Offset: 0x00009194
		[STAThread]
		private static void Main(string[] args)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
			AppDomain.CurrentDomain.AssemblyResolve += Program.CurrentDomain_AssemblyResolve;
			try
			{
				Registry.CurrentUser.DeleteSubKeyTree("Software\\Classes\\alert\\", false);
			}
			catch
			{
				MessageBox.Show("Failed to Clean Up Traces (.reg)");
			}
			List<Process> MaverickClients = new List<Process>(from process in Process.GetProcessesByName(Brand.ProcName)
			where process.MainModule.FileVersionInfo.FileDescription == "" && process.Id != Process.GetCurrentProcess().Id
			select process);
			bool flag = MaverickClients.Count > 0;
			if (flag)
			{
				foreach (Process MaverickClient in MaverickClients)
				{
					MaverickClient.Kill();
				}
			}
			EmbeddedResource.LoadAssembly("Main.Resources.Bunifu_UI_v1.5.3.dll", "Bunifu_UI_v1.5.3.dll");
			EmbeddedResource.LoadAssembly("Main.Resources.CustomTheme.dll", "CustomTheme.dll");
			EmbeddedResource.LoadAssembly("Main.Resources.NetworkTypes.dll", "NetworkTypes.dll");
			EmbeddedResource.LoadAssembly("Main.Resources.RestSharp.dll", "RestSharp.dll");
			EmbeddedResource.LoadAssembly("Main.Resources.Newtonsoft.Json.dll", "Newtonsoft.Json.dll");
			EmbeddedResource.LoadResource("Main.Resources.Logo (40x40).gif", "Logo (40x40).gif");
			EmbeddedResource.LoadResource("Main.Resources.DropDown.png", "DropDown.png");
			EmbeddedResource.LoadResource("Main.Resources.DropUp.png", "DropUp.png");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000B12C File Offset: 0x0000932C
		public static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			return EmbeddedResource.Get(args.Name);
		}
	}
}
