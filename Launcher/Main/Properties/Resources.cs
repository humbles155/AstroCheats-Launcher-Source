using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Main.Properties
{
	// Token: 0x0200000F RID: 15
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000B149 File Offset: 0x00009349
		internal Resources()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000B154 File Offset: 0x00009354
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("Main.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000B19C File Offset: 0x0000939C
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000B1B3 File Offset: 0x000093B3
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0400006D RID: 109
		private static ResourceManager resourceMan;

		// Token: 0x0400006E RID: 110
		private static CultureInfo resourceCulture;
	}
}
