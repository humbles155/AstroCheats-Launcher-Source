using System;
using System.Diagnostics;
using System.Reflection;

namespace Main
{
	// Token: 0x02000005 RID: 5
	public class Brand
	{
		// Token: 0x04000008 RID: 8
		public static string AppID = ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false)).Company.Trim(new char[1]);

		// Token: 0x04000009 RID: 9
		public static string Version = "0.08";

		// Token: 0x0400000A RID: 10
		public static string ExeName = Process.GetCurrentProcess().MainModule.ModuleName;

		// Token: 0x0400000B RID: 11
		public static string ProcName = Brand.ExeName.Replace(".exe", "");

		// Token: 0x0400000C RID: 12
		public static Config config = null;
	}
}
