namespace Artube.src.Forms
{
	partial class FormLayout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TopBar = new System.Windows.Forms.Panel();
			this.MenuBarPanel = new Artube.src.Containers.MenuBarPanel();
			this.TopBarPanel = new Artube.src.UserControls.FormTopBar();
			this.BottomBarPanel = new System.Windows.Forms.Panel();
			this.ContentPanel = new Artube.src.Containers.ContentPanel();
			this.bottomBarPanel1 = new Artube.src.Containers.BottomBarPanel();
			this.TopBar.SuspendLayout();
			this.BottomBarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopBar
			// 
			this.TopBar.AutoSize = true;
			this.TopBar.Controls.Add(this.MenuBarPanel);
			this.TopBar.Controls.Add(this.TopBarPanel);
			this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopBar.Location = new System.Drawing.Point(0, 0);
			this.TopBar.Margin = new System.Windows.Forms.Padding(0);
			this.TopBar.MaximumSize = new System.Drawing.Size(0, 62);
			this.TopBar.MinimumSize = new System.Drawing.Size(0, 62);
			this.TopBar.Name = "TopBar";
			this.TopBar.Size = new System.Drawing.Size(800, 62);
			this.TopBar.TabIndex = 6;
			// 
			// MenuBarPanel
			// 
			this.MenuBarPanel.AutoSize = true;
			this.MenuBarPanel.Location = new System.Drawing.Point(0, 31);
			this.MenuBarPanel.Margin = new System.Windows.Forms.Padding(0);
			this.MenuBarPanel.Name = "MenuBarPanel";
			this.MenuBarPanel.Size = new System.Drawing.Size(800, 26);
			this.MenuBarPanel.TabIndex = 1;
			// 
			// TopBarPanel
			// 
			this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
			this.TopBarPanel.Margin = new System.Windows.Forms.Padding(0);
			this.TopBarPanel.Name = "TopBarPanel";
			this.TopBarPanel.Size = new System.Drawing.Size(800, 31);
			this.TopBarPanel.TabIndex = 0;
			// 
			// BottomBarPanel
			// 
			this.BottomBarPanel.Controls.Add(this.bottomBarPanel1);
			this.BottomBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBarPanel.Location = new System.Drawing.Point(0, 428);
			this.BottomBarPanel.Margin = new System.Windows.Forms.Padding(0);
			this.BottomBarPanel.MaximumSize = new System.Drawing.Size(0, 22);
			this.BottomBarPanel.MinimumSize = new System.Drawing.Size(0, 22);
			this.BottomBarPanel.Name = "BottomBarPanel";
			this.BottomBarPanel.Size = new System.Drawing.Size(800, 22);
			this.BottomBarPanel.TabIndex = 8;
			// 
			// ContentPanel
			// 
			this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentPanel.FormLayout = null;
			this.ContentPanel.Location = new System.Drawing.Point(0, 62);
			this.ContentPanel.Name = "ContentPanel";
			this.ContentPanel.Size = new System.Drawing.Size(800, 366);
			this.ContentPanel.TabIndex = 9;
			// 
			// bottomBarPanel1
			// 
			this.bottomBarPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomBarPanel1.FormLayout = null;
			this.bottomBarPanel1.Location = new System.Drawing.Point(0, 0);
			this.bottomBarPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.bottomBarPanel1.Name = "bottomBarPanel1";
			this.bottomBarPanel1.Size = new System.Drawing.Size(800, 22);
			this.bottomBarPanel1.TabIndex = 0;
			// 
			// FormLayout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ContentPanel);
			this.Controls.Add(this.TopBar);
			this.Controls.Add(this.BottomBarPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLayout";
			this.Text = "MainForm";
			this.TopBar.ResumeLayout(false);
			this.TopBar.PerformLayout();
			this.BottomBarPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel TopBar;
		private Containers.MenuBarPanel MenuBarPanel;
		private UserControls.FormTopBar TopBarPanel;
		private System.Windows.Forms.Panel BottomBarPanel;
		private Containers.ContentPanel ContentPanel;
		private Containers.BottomBarPanel bottomBarPanel1;
	}
}