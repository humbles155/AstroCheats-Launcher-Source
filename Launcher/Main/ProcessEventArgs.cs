using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	// Token: 0x02000007 RID: 7
	public class ProcessEventArgs : EventArgs
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002405 File Offset: 0x00000605
		// (set) Token: 0x06000014 RID: 20 RVA: 0x0000240D File Offset: 0x0000060D
		public bool IsCompleted { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002416 File Offset: 0x00000616
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000241E File Offset: 0x0000061E
		public Image Image { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002427 File Offset: 0x00000627
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000242F File Offset: 0x0000062F
		public Image Cache { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002438 File Offset: 0x00000638
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002440 File Offset: 0x00000640
		public PictureBox PictureBox { get; set; }
	}
}
