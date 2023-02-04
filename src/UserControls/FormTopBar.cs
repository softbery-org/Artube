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
	public partial class FormTopBar : UserControl
	{
		public FormTopBar()
		{
			InitializeComponent();
		}

		private void HideTopBarButtons()
		{
			formTopBarControlbtnXAppMessages1.Visible = false;
			formTopBarControlbtnXHelp1.Visible = false;
		}
	}
}
