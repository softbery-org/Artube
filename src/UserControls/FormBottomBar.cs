using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artube.src.UserControls
{
	public partial class FormBottomBar : UserControl
	{
		System.Windows.Forms.Timer timer;

		public FormBottomBar()
		{
			InitializeComponent();
			timer = new System.Windows.Forms.Timer();
			timer.Tick += new EventHandler(TimerOnTick);
			timer.Interval = 1000;
			timer.Start();
		}

		private void TimerOnTick(object sender, EventArgs e)
		{
			
			string date = DateTime.Now.ToString("dd-MM-yyyy");
			string time = DateTime.Now.ToString("HH:mm:ss");

			timerToolStripStatusLabel.Text = $"Time: {time}";
			timerToolStripStatusLabel.ToolTipText = $"Date: {date}";
		}
	}
}
