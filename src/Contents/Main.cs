﻿using Artube.src.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artube.src.Contents
{
	public partial class Main : UserControl
	{
		public Main()
		{
			InitializeComponent();
		}

		private void ButtonArTube_Click(object sender, EventArgs e)
		{
			Softbery.Core.Layout.Content.ChangeContent("ArtubeMain");
		}
	}
}
