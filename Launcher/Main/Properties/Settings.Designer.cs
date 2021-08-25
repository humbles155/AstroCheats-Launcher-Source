using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Main.Properties
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000B1BC File Offset: 0x000093BC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400006F RID: 111
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
