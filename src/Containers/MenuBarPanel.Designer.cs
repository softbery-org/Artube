namespace Artube.src.Containers
{
	partial class MenuBarPanel
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
			this.formMenuStripControl1 = new Artube.src.UserControls.FormMenuStripControl();
			this.SuspendLayout();
			// 
			// formMenuStripControl1
			// 
			this.formMenuStripControl1.AutoScroll = true;
			this.formMenuStripControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formMenuStripControl1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.formMenuStripControl1.Location = new System.Drawing.Point(0, 0);
			this.formMenuStripControl1.Margin = new System.Windows.Forms.Padding(0);
			this.formMenuStripControl1.Name = "formMenuStripControl1";
			this.formMenuStripControl1.Size = new System.Drawing.Size(585, 26);
			this.formMenuStripControl1.TabIndex = 0;
			// 
			// MenuBarPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.formMenuStripControl1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "MenuBarPanel";
			this.Size = new System.Drawing.Size(585, 26);
			this.ResumeLayout(false);

		}

		#endregion

		private UserControls.FormMenuStripControl formMenuStripControl1;
	}
}
