using System;
using System.Windows.Forms;

namespace CustomTheme
{
	// Token: 0x02000004 RID: 4
	public class CustomListBox : ListBox
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000022EC File Offset: 0x000004EC
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				bool flag = !this.mShowScroll;
				if (flag)
				{
					cp.Style &= -2097153;
				}
				return cp;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002340 File Offset: 0x00000540
		public bool ShowScrollbar
		{
			get
			{
				return this.mShowScroll;
			}
			set
			{
				bool flag = value != this.mShowScroll;
				if (flag)
				{
					this.mShowScroll = value;
					bool isHandleCreated = base.IsHandleCreated;
					if (isHandleCreated)
					{
						base.RecreateHandle();
					}
				}
			}
		}

		// Token: 0x04000007 RID: 7
		private bool mShowScroll;
	}
}
