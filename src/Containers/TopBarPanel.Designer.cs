namespace Artube.src.Containers
{
	partial class TopBarPanel
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
			this.formTopBar1 = new Artube.src.UserControls.FormTopBar();
			this.SuspendLayout();
			// 
			// formTopBar1
			// 
			this.formTopBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formTopBar1.Location = new System.Drawing.Point(0, 0);
			this.formTopBar1.Margin = new System.Windows.Forms.Padding(0);
			this.formTopBar1.Name = "formTopBar1";
			this.formTopBar1.Size = new System.Drawing.Size(635, 31);
			this.formTopBar1.TabIndex = 0;
			// 
			// TopBarPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
			this.Controls.Add(this.formTopBar1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "TopBarPanel";
			this.Size = new System.Drawing.Size(635, 31);
			this.ResumeLayout(false);

		}

		#endregion

		private UserControls.FormTopBar formTopBar1;
	}
}
