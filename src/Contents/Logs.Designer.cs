namespace Artube.src.Contents
{ 
	partial class Logs
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
			this.logRichTextBox = new System.Windows.Forms.RichTextBox();
			this.logGroupBox = new System.Windows.Forms.GroupBox();
			this.logGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// logRichTextBox
			// 
			this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.logRichTextBox.Name = "logRichTextBox";
			this.logRichTextBox.Size = new System.Drawing.Size(793, 421);
			this.logRichTextBox.TabIndex = 0;
			this.logRichTextBox.Text = "";
			// 
			// logGroupBox
			// 
			this.logGroupBox.Controls.Add(this.logRichTextBox);
			this.logGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logGroupBox.Location = new System.Drawing.Point(0, 0);
			this.logGroupBox.Name = "logGroupBox";
			this.logGroupBox.Size = new System.Drawing.Size(799, 440);
			this.logGroupBox.TabIndex = 1;
			this.logGroupBox.TabStop = false;
			this.logGroupBox.Text = "Logs";
			// 
			// Logs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.logGroupBox);
			this.Name = "Logs";
			this.Size = new System.Drawing.Size(799, 440);
			this.logGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox logRichTextBox;
		private System.Windows.Forms.GroupBox logGroupBox;
	}
}
