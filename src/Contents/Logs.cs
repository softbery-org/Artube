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
 * filename    : Logs.cs
 * date        : Sat Feb 04 2023
 * company     : Softbery
 * author      : Paweł Tobis
 * email       : softbery@gmail.com
 */

using Softbery.Logger;
using Softbery.Text.Extensions;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Artube.src.Contents
{
    public partial class Logs : UserControl
	{
		Logger logger = new Logger();

		public Logs()
		{
			InitializeComponent();
			Logger.Write += AddLogMessage;
			Logger.Write(new Log { Type = LogTypes.Information, Message = $"Create control {this.Name}" });
		}

		/// <summary>
		/// Add log message to RichTextBox
		/// </summary>
		/// <param name="log"></param>
		private void AddLogMessage(Log log)
		{
			Color color = new Color();
			logger.AddLog(log.Type, log.Message);
			log = logger.Logs.Last();

			switch (log.Type)
			{
				case Softbery.Logger.LogTypes.Information:
					color = Color.Blue;
					break;
				case Softbery.Logger.LogTypes.Warning:
					color = Color.Orange;
					break;
				case Softbery.Logger.LogTypes.Error:
					color = Color.Red;
					break;
				case Softbery.Logger.LogTypes.Success:
					color = Color.Green;
					break;
				default:
					color = Color.Brown;
					break;
			}

			var font = new Font("Calibri", 10f);

			// Run colorize
			_RichTextBoxColorize(log, color, font);
		}

		/// <summary>
		/// Colorize RichTextBox
		/// </summary>
		/// <param name="log">Log for colorize</param>
		/// <param name="color">Color</param>
		private void _RichTextBoxColorize(Log log, Color color, Font font = null)
		{
			// ////////////////////////////////////////////////////////////////
			// Added from Softbery.Text.RichTextBoxColorizeExtensions
			// ////////////////////////////////////////////////////////////////
			var date = log.Date;
			var time = log.Time;
			var type = log.Type.ToString();
			var message = log.Message;
			var box = logRichTextBox;

			box.AppendText("[" + date + " " + time + "]", color, font);
			box.AppendText("[" + type + "]", color, font);
			box.AppendText(": ");
			box.AppendText(message, Color.Black, font);
			box.AppendText(Environment.NewLine);
			// //////////////////////////////////////////////////
			// Softbery.Text.RichTextBoxColorizeExtensions
			// //////////////////////////////////////////////////

			// Scrolling
			box.ScrollToCaret();
		}
	}
}
