namespace Artube.src.Contents
{
	partial class Main
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
			this.buttonArTube = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonArTube
			// 
			this.buttonArTube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonArTube.FlatAppearance.BorderSize = 2;
			this.buttonArTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.buttonArTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonArTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonArTube.Image = global::Artube.Properties.Resources.media_CD_32xLG;
			this.buttonArTube.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonArTube.Location = new System.Drawing.Point(306, 55);
			this.buttonArTube.Name = "buttonArTube";
			this.buttonArTube.Size = new System.Drawing.Size(164, 56);
			this.buttonArTube.TabIndex = 0;
			this.buttonArTube.Text = "ArTube";
			this.buttonArTube.UseVisualStyleBackColor = true;
			this.buttonArTube.Click += new System.EventHandler(this.ButtonArTube_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.buttonArTube);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.DoubleBuffered = true;
			this.Name = "Main";
			this.Size = new System.Drawing.Size(789, 425);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonArTube;
	}
}
