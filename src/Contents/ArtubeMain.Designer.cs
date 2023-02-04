namespace Artube.src.Contents
{
	partial class ArtubeMain
	{
		/// <summary> 
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod wygenerowany przez Projektanta składników

		/// <summary> 
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.urlTextBox = new System.Windows.Forms.TextBox();
			this.trackDataGridView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cancellationButton = new System.Windows.Forms.Button();
			this.downloadSelectedTracks = new System.Windows.Forms.Button();
			this.getListBtn = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.mainProgressBar = new System.Windows.Forms.ProgressBar();
			this.trackProgressBar = new System.Windows.Forms.ProgressBar();
			this.videoPanel = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.videoPlayButton = new System.Windows.Forms.Button();
			this.videoRevButton = new System.Windows.Forms.Button();
			this.videoPauseButton = new System.Windows.Forms.Button();
			this.videoPrvButton = new System.Windows.Forms.Button();
			this.videoStopButton = new System.Windows.Forms.Button();
			this.trackInfoTextBox = new System.Windows.Forms.TextBox();
			this.videoTrackBar = new System.Windows.Forms.TrackBar();
			this.contentOnVideoPanelLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackDataGridView)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.videoPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// urlTextBox
			// 
			this.urlTextBox.Location = new System.Drawing.Point(6, 9);
			this.urlTextBox.Name = "urlTextBox";
			this.urlTextBox.Size = new System.Drawing.Size(521, 20);
			this.urlTextBox.TabIndex = 2;
			this.urlTextBox.Text = "https://www.youtube.com/watch?v=rNhUNrdAOPU&list=RDMM&start_radio=1&rv=cjLslfmW7B" +
    "w";
			this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
			// 
			// dataGridView1
			// 
			this.trackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.trackDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.trackDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackDataGridView.EnableHeadersVisualStyles = false;
			this.trackDataGridView.Location = new System.Drawing.Point(3, 16);
			this.trackDataGridView.Name = "dataGridView1";
			this.trackDataGridView.RowHeadersVisible = false;
			this.trackDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.trackDataGridView.Size = new System.Drawing.Size(207, 310);
			this.trackDataGridView.TabIndex = 7;
			this.trackDataGridView.SelectionChanged += new System.EventHandler(this.TrackDataGridView_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Title";
			this.Column1.Name = "Column1";
			this.Column1.Width = 204;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cancellationButton);
			this.groupBox2.Controls.Add(this.downloadSelectedTracks);
			this.groupBox2.Controls.Add(this.getListBtn);
			this.groupBox2.Location = new System.Drawing.Point(219, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(308, 281);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Options";
			// 
			// cancellationButton
			// 
			this.cancellationButton.Location = new System.Drawing.Point(6, 252);
			this.cancellationButton.Name = "cancellationButton";
			this.cancellationButton.Size = new System.Drawing.Size(296, 23);
			this.cancellationButton.TabIndex = 14;
			this.cancellationButton.Text = "Cancel";
			this.cancellationButton.UseVisualStyleBackColor = true;
			this.cancellationButton.Click += new System.EventHandler(this.CancellationButton_Click);
			// 
			// downloadSelectedTracks
			// 
			this.downloadSelectedTracks.Location = new System.Drawing.Point(6, 48);
			this.downloadSelectedTracks.Name = "downloadSelectedTracks";
			this.downloadSelectedTracks.Size = new System.Drawing.Size(296, 23);
			this.downloadSelectedTracks.TabIndex = 1;
			this.downloadSelectedTracks.Text = "Download selected track";
			this.downloadSelectedTracks.UseVisualStyleBackColor = true;
			this.downloadSelectedTracks.Click += new System.EventHandler(this.DownloadSelectedTracks_Click);
			// 
			// getListBtn
			// 
			this.getListBtn.Location = new System.Drawing.Point(6, 19);
			this.getListBtn.Name = "getListBtn";
			this.getListBtn.Size = new System.Drawing.Size(296, 23);
			this.getListBtn.TabIndex = 0;
			this.getListBtn.Text = "Get list";
			this.getListBtn.UseVisualStyleBackColor = true;
			this.getListBtn.Click += new System.EventHandler(this.GetListBtn_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.trackDataGridView);
			this.groupBox3.Location = new System.Drawing.Point(3, 35);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(213, 329);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tracks";
			// 
			// mainProgressBar
			// 
			this.mainProgressBar.Location = new System.Drawing.Point(222, 35);
			this.mainProgressBar.Name = "mainProgressBar";
			this.mainProgressBar.Size = new System.Drawing.Size(305, 23);
			this.mainProgressBar.TabIndex = 13;
			// 
			// trackProgressBar
			// 
			this.trackProgressBar.Location = new System.Drawing.Point(222, 64);
			this.trackProgressBar.Name = "trackProgressBar";
			this.trackProgressBar.Size = new System.Drawing.Size(305, 10);
			this.trackProgressBar.TabIndex = 14;
			// 
			// videoPanel
			// 
			this.videoPanel.BackColor = System.Drawing.SystemColors.WindowText;
			this.videoPanel.Controls.Add(this.contentOnVideoPanelLabel);
			this.videoPanel.Location = new System.Drawing.Point(533, 9);
			this.videoPanel.Name = "videoPanel";
			this.videoPanel.Size = new System.Drawing.Size(368, 169);
			this.videoPanel.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.trackInfoTextBox);
			this.groupBox1.Location = new System.Drawing.Point(533, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(186, 129);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Track Info:";
			// 
			// videoPlayButton
			// 
			this.videoPlayButton.Location = new System.Drawing.Point(726, 232);
			this.videoPlayButton.Name = "videoPlayButton";
			this.videoPlayButton.Size = new System.Drawing.Size(175, 23);
			this.videoPlayButton.TabIndex = 17;
			this.videoPlayButton.Text = "Play";
			this.videoPlayButton.UseVisualStyleBackColor = true;
			// 
			// videoRevButton
			// 
			this.videoRevButton.Location = new System.Drawing.Point(726, 261);
			this.videoRevButton.Name = "videoRevButton";
			this.videoRevButton.Size = new System.Drawing.Size(55, 23);
			this.videoRevButton.TabIndex = 18;
			this.videoRevButton.Text = "Rev";
			this.videoRevButton.UseVisualStyleBackColor = true;
			// 
			// videoPauseButton
			// 
			this.videoPauseButton.Location = new System.Drawing.Point(787, 261);
			this.videoPauseButton.Name = "videoPauseButton";
			this.videoPauseButton.Size = new System.Drawing.Size(55, 23);
			this.videoPauseButton.TabIndex = 19;
			this.videoPauseButton.Text = "|  |";
			this.videoPauseButton.UseVisualStyleBackColor = true;
			// 
			// videoPrvButton
			// 
			this.videoPrvButton.Location = new System.Drawing.Point(846, 261);
			this.videoPrvButton.Name = "videoPrvButton";
			this.videoPrvButton.Size = new System.Drawing.Size(55, 23);
			this.videoPrvButton.TabIndex = 20;
			this.videoPrvButton.Text = "Prv";
			this.videoPrvButton.UseVisualStyleBackColor = true;
			// 
			// videoStopButton
			// 
			this.videoStopButton.Location = new System.Drawing.Point(726, 291);
			this.videoStopButton.Name = "videoStopButton";
			this.videoStopButton.Size = new System.Drawing.Size(175, 23);
			this.videoStopButton.TabIndex = 21;
			this.videoStopButton.Text = "Stop";
			this.videoStopButton.UseVisualStyleBackColor = true;
			// 
			// trackInfoTextBox
			// 
			this.trackInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trackInfoTextBox.Location = new System.Drawing.Point(3, 16);
			this.trackInfoTextBox.Multiline = true;
			this.trackInfoTextBox.Name = "trackInfoTextBox";
			this.trackInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.trackInfoTextBox.Size = new System.Drawing.Size(180, 110);
			this.trackInfoTextBox.TabIndex = 0;
			// 
			// videoTrackBar
			// 
			this.videoTrackBar.Location = new System.Drawing.Point(533, 181);
			this.videoTrackBar.Name = "videoTrackBar";
			this.videoTrackBar.Size = new System.Drawing.Size(368, 45);
			this.videoTrackBar.TabIndex = 23;
			// 
			// contentOnVideoPanelLabel
			// 
			this.contentOnVideoPanelLabel.AutoSize = true;
			this.contentOnVideoPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.contentOnVideoPanelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.contentOnVideoPanelLabel.Location = new System.Drawing.Point(13, 8);
			this.contentOnVideoPanelLabel.Name = "contentOnVideoPanelLabel";
			this.contentOnVideoPanelLabel.Size = new System.Drawing.Size(345, 13);
			this.contentOnVideoPanelLabel.TabIndex = 0;
			this.contentOnVideoPanelLabel.Text = "label1 label1 label1 label1 label1 label1 label1 label1 label1";
			// 
			// ArtubeMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.videoTrackBar);
			this.Controls.Add(this.videoStopButton);
			this.Controls.Add(this.videoPrvButton);
			this.Controls.Add(this.videoPauseButton);
			this.Controls.Add(this.videoRevButton);
			this.Controls.Add(this.videoPlayButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.videoPanel);
			this.Controls.Add(this.trackProgressBar);
			this.Controls.Add(this.mainProgressBar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.urlTextBox);
			this.Name = "ArtubeMain";
			this.Size = new System.Drawing.Size(910, 371);
			((System.ComponentModel.ISupportInitialize)(this.trackDataGridView)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.videoPanel.ResumeLayout(false);
			this.videoPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.videoTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox urlTextBox;
		private System.Windows.Forms.DataGridView trackDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button getListBtn;
		private System.Windows.Forms.Button downloadSelectedTracks;
		private System.Windows.Forms.ProgressBar mainProgressBar;
		private System.Windows.Forms.Button cancellationButton;
		private System.Windows.Forms.ProgressBar trackProgressBar;
		private System.Windows.Forms.Panel videoPanel;
		private System.Windows.Forms.Label contentOnVideoPanelLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox trackInfoTextBox;
		private System.Windows.Forms.Button videoPlayButton;
		private System.Windows.Forms.Button videoRevButton;
		private System.Windows.Forms.Button videoPauseButton;
		private System.Windows.Forms.Button videoPrvButton;
		private System.Windows.Forms.Button videoStopButton;
		private System.Windows.Forms.TrackBar videoTrackBar;
	}
}
