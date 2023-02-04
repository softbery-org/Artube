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
	public delegate void LayoutEventHandler(string name);
	public delegate void SearchEventHandler(string phrase);

	public partial class FormLayout : Form
	{
		private UserControl content = new UserControl();
		private UserControl currentContent;
		private Dictionary<string, UserControl> controlsList = new Dictionary<string, UserControl>();

		public event LayoutEventHandler ContentLayoutChange;
		public FormLayout()
		{
			InitializeComponent();
			this.Text = "MainLayouts";

			Softbery.Core.Layout.Content.ChangeContent += ChangeContent;
			ContentLayoutChange += ChangeContent;
			
			SetPanels();

			ChangeContent("Logs");

			Logger.Write(new Log { Type = LogType.Information, Message = $"Create form {this.Name}" });

			ChangeContent("Main");
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
					Type type = Type.GetType($"Artube.src.Contents.{content_name}");
					uc = (UserControl)Activator.CreateInstance(type);
					controlsList.Add(content_name, uc);
					this.currentContent = uc;
					uc.CreateControl();
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

		private void ClearContent(string content_name)
		{
			controlsList.Remove(content_name);
		}

		public UserControl GetCurentContent()
		{
			return this.currentContent;
		}
	}
}
