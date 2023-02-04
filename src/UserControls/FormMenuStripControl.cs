using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Artube.src.UserControls
{
    public partial class FormMenuStripControl : UserControl
    {

        #region [SOF: DEFINED VERIABLES]
        /// <summary>
        /// Website process
        /// </summary>
        private Process websiteProcess = new Process();

        /// <summary>
        /// Set website settings veriables
        /// </summary>
        private Dictionary<string, string> websiteAddress = new Dictionary<string, string>();

        /// <summary>
        /// UserControl content
        /// </summary>
        /// <typeparam name="string">Content box name</typeparam>
        /// <returns>Content box list</returns>
        private List<string> ContentList = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public delegate void DelegateComboBoxChangeEnable(bool value);

        static bool combobox = false;
        #endregion

        #region [User Control]
        /// <summary>
        /// Class constructor for initialize components
        /// </summary>
        public FormMenuStripControl()
        {
            InitializeComponent();
            // SetSettingsDictionary();
            
            searchStripComboBox.Enabled = true;
		}
		#endregion

		#region Methods
        private void SetUserControlsList()
        {
            ContentList.Clear();
            ContentList.Add("Start");
			ContentList.Add("About");
			ContentList.Add("Deklaracje");
			ContentList.Add("Komunikacja");
		}

		/// <summary>
		/// Set settings dictionary
		/// </summary>
		private void SetSettingsDictionary()
        {
            
            websiteAddress.Add("domain","http://softbery.ddns.net");
            websiteAddress.Add("help", websiteAddress["domain"]+"/help");
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="frm">Form</param>
        private void CloseForm(Form frm)
        {
            frm.FindForm().Close();
        }

        /// <summary>
        /// Open URL address in default web browser
        /// </summary>
        /// <param name="address">Address to run</param>
        private void runWebsite(string address)
        {
            try
            {
                websiteProcess.StartInfo.UseShellExecute = true;
                websiteProcess.StartInfo.FileName = address;
                websiteProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangeSearchBoxEnable(bool value)
        {
            searchStripComboBox.Enabled = value;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm(this.FindForm());
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formDeklaracjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Softbery.Core.Layout.Content.ChangeContent("Deklaracje");
        }

        private void formKomunikacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("Deklaracje");
		}

        private void formRachunkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("Deklaracje");
		}

        private void statementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("Deklaracje");
		}

        private void performancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("Settings");
		}

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("Logs");
		}

        private void showWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runWebsite(websiteAddress["help"]);
        }

        private void siginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            runWebsite(websiteAddress["domain"]);
        }

        private void informationsAboutSofToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Softbery.Core.Layout.Content.ChangeContent("About");
		}

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void ArTubeToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Softbery.Core.Layout.Content.ChangeContent("ArtubeMain");
		}

		private void LogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Softbery.Core.Layout.Content.ChangeContent("Logs");
		}

        private bool RunSearch(string phrase)
        {
            if (string.IsNullOrEmpty(phrase)) { return false; }
            var v = Artube.src.Contents.ArtubeMain.Search(phrase);
            
            bool r = false;
            if (v.Count > 0)
            {
                searchStripComboBox.Items.Clear();
                foreach (var item in v)
                {
                    searchStripComboBox.Items.Add(item);
                }
                r = true;
            }
            return r;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void SearchStripComboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
            if (e.KeyChar==13)
                RunSearch(searchStripComboBox.Text);
		}
		#endregion
	}
}
