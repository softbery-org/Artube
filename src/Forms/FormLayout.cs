/*
 * GNU GENERAL PUBLIC LICENSE (GPL v3.0)
 *
 * Copyright (C) 2004-2023  Softbery Paweł Tobis http://github.com/softbery-org
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *
 * project     : ArTube
 * filename    : FormLayout.cs
 * date        : Sat Feb 04 2023
 * company     : Softbery
 * author      : Paweł Tobis
 * email       : softbery@gmail.com
 */
 
using Artube.src.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Softbery.Logger;

namespace Artube.src.Forms
{
	public partial class FormLayout : Form
	{
		private UserControl currentContent = new UserControl();
		private Dictionary<string, UserControl> controlsList = new Dictionary<string, UserControl>();
		private string formTitle = "";
		public FormLayout()
		{
			InitializeComponent();
			this.Text = "MainLayouts";

			Softbery.Core.Layout.Content.ChangeContent += ChangeContent;

			SetPanels();

			ChangeContent("Logs");

			Logger.Write(new Log { Type = LogType.Information, Message = $"Create form {this.Name}" });

			ChangeContent("Main");
			src.UserControls.FormTopBarControlLabelName.SetTitle("ArTube: Main");
		}

		private void SetPanels()
		{
			UserControl topbar = new src.UserControls.FormTopBar();
			topbar.CreateControl();
			topbar.Dock = DockStyle.Fill;
			TopBarPanel.Controls.Clear();
			TopBarPanel.Controls.Add(topbar);
			TopBarPanel.Dock = DockStyle.Top;

			UserControl menu = new src.UserControls.FormMenuStripControl();
			menu.CreateControl();
			menu.Dock = DockStyle.Fill;
			MenuBarPanel.Controls.Clear();
			MenuBarPanel.Controls.Add(menu);
		}

		public void ChangeContent(string name)
		{
			SetContent(name);
			this.Text = name;
		}

		private void SetContent(string content_name)
		{
			var uc = new UserControl();
			if (!controlsList.ContainsKey(content_name))
			{
				try
				{
					if (content_name != null)
					{
						Type type = Type.GetType($"Artube.src.Contents.{content_name}");
						uc = (UserControl)Activator.CreateInstance(type);
						controlsList.Add(content_name, uc);
						this.currentContent = uc;
						uc.CreateControl();
					}
				}
				catch (Exception ex)
				{
					uc = new UserControl();
				}
			}
			else
			{
				uc = controlsList[content_name];
			}

			uc.Dock = DockStyle.Fill;

            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(uc);
		}

		private void RemoveFromControls(string content_name)
		{
			controlsList.Remove(content_name);
		}

		public UserControl GetCurentContent()
		{
			return this.currentContent;
		}
	}
}
