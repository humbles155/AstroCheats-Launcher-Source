using System;
using RestSharp;

namespace AuthLib
{
	// Token: 0x02000013 RID: 19
	public class RestParameter
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000C09B File Offset: 0x0000A29B
		public RestParameter()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000C0B3 File Offset: 0x0000A2B3
		public RestParameter(string Key, string Value, ParameterType Type, DataFormat Format = 2)
		{
			this.Key = Key;
			this.Value = Value;
			this.Type = Type;
		}

		// Token: 0x04000079 RID: 121
		public string Key;

		// Token: 0x0400007A RID: 122
		public string Value;

		// Token: 0x0400007B RID: 123
		public ParameterType Type = 3;

		// Token: 0x0400007C RID: 124
		public DataFormat Format = 2;
	}
}
