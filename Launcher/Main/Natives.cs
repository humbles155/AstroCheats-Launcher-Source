using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Main
{
	// Token: 0x0200000A RID: 10
	public class Natives
	{
		// Token: 0x06000025 RID: 37
		[DllImport("uxtheme", ExactSpelling = true)]
		public static extern int DrawThemeParentBackground(IntPtr hWnd, IntPtr hdc, ref Rectangle pRect);

		// Token: 0x06000026 RID: 38
		[DllImport("user32.dll")]
		private static extern IntPtr GetShellWindow();

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumWindows(Natives.EnumWindowsProc lpEnumFunc, int lpram);

		// Token: 0x06000028 RID: 40
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		// Token: 0x06000029 RID: 41
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		// Token: 0x0600002A RID: 42
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000D8 RID: 216
		private delegate bool EnumWindowsProc(IntPtr hWnd, int lpram);
	}
}
