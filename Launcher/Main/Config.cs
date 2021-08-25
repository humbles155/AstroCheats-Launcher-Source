using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NetworkTypes;

namespace Main
{
	// Token: 0x02000009 RID: 9
	public class Config
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002764 File Offset: 0x00000964
		public Config(company company)
		{
			this.company = company;
			this.themes = company.themes;
			bool flag = this.themes.Any((theme theme) => theme.isDefault);
			if (flag)
			{
				this.theme = this.themes.Find((theme theme) => theme.isDefault);
			}
			else
			{
				this.theme = this.themes.FirstOrDefault<theme>();
			}
			this.OAuthLink = string.Concat(new string[]
			{
				company.website,
				"oauth/authorize/?response_type=code&client_id=",
				company.clientid,
				"&redirect_uri=",
				company.website,
				"maverick-api/launcher/oauthv2/OAuth2.php&scope=profile&state=state1234"
			});
		}

		// Token: 0x04000012 RID: 18
		public company company = null;

		// Token: 0x04000013 RID: 19
		public List<theme> themes = new List<theme>();

		// Token: 0x04000014 RID: 20
		public theme theme = null;

		// Token: 0x04000015 RID: 21
		public Image Header = null;

		// Token: 0x04000016 RID: 22
		public Image Logo = null;

		// Token: 0x04000017 RID: 23
		public Image Avatar = null;

		// Token: 0x04000018 RID: 24
		public string OAuthLink = "";
	}
}
