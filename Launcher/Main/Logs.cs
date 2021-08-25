using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WindowsFormsControlLibrary1;

namespace Main
{
	// Token: 0x0200000C RID: 12
	public partial class Logs : Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00005FDC File Offset: 0x000041DC
		public Logs()
		{
			Logs.LogEntries.CollectionChanged += this.OnListChanged;
			this.InitializeComponent();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000600B File Offset: 0x0000420B
		private void Logs_Load(object sender, EventArgs e)
		{
			Logs.LogEntries.ToList<string>().ForEach(delegate(string Log)
			{
				this.LogsTextBox.AppendText(Log + Environment.NewLine);
			});
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000602C File Offset: 0x0000422C
		private void OnListChanged(object sender, NotifyCollectionChangedEventArgs args)
		{
			bool visible = base.Visible;
			if (visible)
			{
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					foreach (object item in args.NewItems)
					{
						this.LogsTextBox.AppendText(((item != null) ? item.ToString() : null) + Environment.NewLine);
					}
					this.LogsTextBox.Refresh();
					Console.WriteLine("Added New Text to Logs");
				}));
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000606D File Offset: 0x0000426D
		private void ShowLogs_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400003A RID: 58
		public static ObservableCollection<string> LogEntries = new ObservableCollection<string>();
	}
}
