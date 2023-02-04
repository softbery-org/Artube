namespace Artube.src.UserControls
{
	partial class FormBottomBar
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
			this.BottomBarStatusStrip = new System.Windows.Forms.StatusStrip();
			this.progressToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.progressToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.timerToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.BottomBarStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomBarStatusStrip
			// 
			this.BottomBarStatusStrip.AutoSize = false;
			this.BottomBarStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressToolStripStatusLabel,
            this.progressToolStripProgressBar,
            this.timerToolStripStatusLabel});
			this.BottomBarStatusStrip.Location = new System.Drawing.Point(0, 0);
			this.BottomBarStatusStrip.Name = "BottomBarStatusStrip";
			this.BottomBarStatusStrip.Size = new System.Drawing.Size(610, 22);
			this.BottomBarStatusStrip.TabIndex = 0;
			this.BottomBarStatusStrip.Text = "statusStrip1";
			// 
			// progressToolStripStatusLabel
			// 
			this.progressToolStripStatusLabel.Name = "progressToolStripStatusLabel";
			this.progressToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.progressToolStripStatusLabel.Size = new System.Drawing.Size(58, 17);
			this.progressToolStripStatusLabel.Text = "Progress: ";
			// 
			// progressToolStripProgressBar
			// 
			this.progressToolStripProgressBar.Margin = new System.Windows.Forms.Padding(0);
			this.progressToolStripProgressBar.Name = "progressToolStripProgressBar";
			this.progressToolStripProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.progressToolStripProgressBar.Size = new System.Drawing.Size(100, 22);
			this.progressToolStripProgressBar.Step = 1;
			this.progressToolStripProgressBar.Value = 71;
			// 
			// timerToolStripStatusLabel
			// 
			this.timerToolStripStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.timerToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.timerToolStripStatusLabel.Name = "timerToolStripStatusLabel";
			this.timerToolStripStatusLabel.Size = new System.Drawing.Size(406, 17);
			this.timerToolStripStatusLabel.Spring = true;
			this.timerToolStripStatusLabel.Text = "Time: 11:11:11";
			this.timerToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormBottomBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.BottomBarStatusStrip);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "FormBottomBar";
			this.Size = new System.Drawing.Size(610, 22);
			this.BottomBarStatusStrip.ResumeLayout(false);
			this.BottomBarStatusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.StatusStrip BottomBarStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel timerToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel progressToolStripStatusLabel;
		private System.Windows.Forms.ToolStripProgressBar progressToolStripProgressBar;
	}
}
