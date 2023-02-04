using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artube.src.Containers
{
	public partial class ContentPanel : UserControl
	{
		public ContentPanel()
		{
			InitializeComponent();
		}

		public Forms.FormLayout FormLayout
		{
			get => default;
			set
			{
			}
		}
	}
}
