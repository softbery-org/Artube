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
 * filename   : ArtubeMain.cs
 * date         : Sat Feb 04 2023
 * company  : Softbery
 * author      : Paweł Tobis
 * email        : softbery@gmail.com
 */

using Softbery.Logger;
using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace Artube.src.Contents
{
	public partial class ArtubeMain : UserControl
	{
		public delegate List<Video> DelegateSearchList(string phrase);
		private double trackprogress;
		private double mainprogress;

		public double MainProgress
		{
			get => mainprogress;
			private set => mainprogress = value;
		}
		public double TrackProgress
		{
			get => trackprogress;
			private set => trackprogress = value;
		}

		private YoutubeClient client;
		private static List<Video> playlist = new List<Video>();
		private Progress<double> progressHandle;
		private Progress<double> mainProgressHandle;
		private int currentTrackProgress = 0;
		private int totalTracksToProgress = 0;
		CancellationToken cancellation;

		List<string> urls;
		string downloadpath = AppDomain.CurrentDomain.BaseDirectory + @"downloaded\";
		//int selected = 0;
		List<int> selected = new List<int>();
		YoutubeExplode.YoutubeClient youtube = new YoutubeExplode.YoutubeClient();

		public ArtubeMain()
		{
			InitializeComponent();
			CreateDirectories();
			progressHandle = new Progress<double>(p => TrackProgress = p);
			mainProgressHandle = new Progress<double>(p => MainProgress = p);
			progressHandle.ProgressChanged += ProgressHandle_ProgressChanged;
			mainProgressHandle.ProgressChanged += MainProgressHandle_ProgressChanged;
			downloadSelectedTracks.Enabled = false;
			Logger.Write(new Log { Type = LogType.Information, Message = "Open/Create Artube window ..." });
		}

		public void CreateDirectories()
		{
			if (!Directory.Exists(downloadpath))
			{
				try
				{
					Directory.CreateDirectory(downloadpath);
				}
				catch (Exception)
				{
					Logger.Write(new Log { Type = LogType.Error, Message = "Can't create needed folder. Please contact with system administrator." });
				}
			}
		}

		private void TrackDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			selected = new List<int>();

			foreach (DataGridViewRow item in trackDataGridView.SelectedRows)
			{
				selected.Add(item.Index);
			}
			var a = "";
			foreach (var item in selected)
			{
				a += item + " ";
			}
			downloadSelectedTracks.Enabled = true;
		}

		private void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
                GetYoutubeTrackList();
			}
		}

		private void OpenExplorerButton_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(this.downloadpath))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo() 
				{
					Arguments = "/select, " + this.downloadpath,
					FileName = "explorer.exe"
				};
				Process.Start(startInfo);
			}
			else
			{
				Softbery.Logger.Logger.Write(new Log() { Type = Softbery.Logger.LogType.Error, Message = $"Folder: {this.downloadpath}. Not exist"});
			}
		}

		public static List<Video> Search(string phrase)
		{
			//List<int> result = new List<int>();
			//int i = 0;
			List<Video> r = new List<Video>();
			foreach (var item in playlist)
			{
				if (item.Title.Contains(phrase))
				{
					r.Add(item);
				}
			}
			return r;
		}

		private async void GetYoutubeTrackList()
		{
			getListBtn.Enabled = false;
			client = new YoutubeClient();
			trackDataGridView.DataSource = null;
			playlist = new List<Video>();
			
			try
			{
				var pl = await client.Playlists.GetAsync(urlTextBox.Text);
				var v = await client.Playlists.GetVideosAsync(pl.Id);
				foreach (var item in v)
				{
					trackDataGridView.Rows.Add(item.Title);
					var i = new Video(item.Id, item.Title, item.Author, DateTime.Now, null, item.Duration, item.Thumbnails, null,null);
					playlist.Add(i);
				}
			}
			catch (Exception ex)
			{
				Softbery.Logger.Logger.Write(new Log { Type = LogType.Error, Message = $"Url is not youtube track. Reason: {ex.Message}" });
			}

			try
			{
				trackDataGridView.DataSource = null;
				
				var b = await client.Videos.GetAsync(urlTextBox.Text);
				trackDataGridView.Rows.Add(b.Title);
				playlist.Add(b);
			}
			catch (Exception ex)
			{
				Softbery.Logger.Logger.Write(new Log { Type=LogType.Error, Message=$"Url is not youtube track. Reason: {ex.Message}"});
			}

			getListBtn.Enabled = true;
		}

		private void GetListBtn_Click(object sender, EventArgs e)
		{
			GetYoutubeTrackList();
		}

		private async Task StartDownloadStreamAsync(Video video, IProgress<double> progress=null)
		{
			downloadSelectedTracks.Enabled = false;
			try
			{
				TrackProgress = 0;
				client = new YoutubeClient();
				var sm = await client.Videos.Streams.GetManifestAsync(video.Id);
				var smi = sm.GetAudioOnlyStreams().GetWithHighestBitrate();
				await client.Videos.Streams.DownloadAsync(smi, downloadpath+video.Title+".mp3", progressHandle);
			}
			finally
			{
				TrackProgress = 0;
			}
			downloadSelectedTracks.Enabled = true;
		}

		private void MainProgressHandle_ProgressChanged(object? sender, double e)
		{
			Invoke((MethodInvoker)delegate {
				mainProgressBarWithText.Value = (int)((int)(currentTrackProgress *e) / totalTracksToProgress) * 100;
			});
		}

		private void ProgressHandle_ProgressChanged(object? sender, double e)
		{
			Invoke((MethodInvoker)delegate {
				trackProgressBarWithText.Value = (int)(e / 1) * 100;
			});
		}

		private async void DownloadSelectedTracks_Click(object sender, EventArgs e)
		{
			client = new YoutubeClient();
			totalTracksToProgress = selected.Count;
			currentTrackProgress = 1;
			foreach (var item in selected)
			{
				Softbery.Logger.Logger.Write(new Log { Type = LogType.Error, Message = $"Download Start: "+item });
				await StartDownloadStreamAsync(playlist[item]);
				
				currentTrackProgress++;
			}
			Softbery.Logger.Logger.Write(new Log { Type = LogType.Error, Message = $"Download completed." });
		}

		private void CancellationButton_Click(object sender, EventArgs e)
		{
			//cancellation = 
		}
	}
}
