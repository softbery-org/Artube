namespace Artube.src.UserControls
{
    partial class FormTopBarControlLogo
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
        /// Wymagana metoda Wsparcia projektanta - nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Artube.Properties.Resources.sof_logo_16;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(31, 31);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // FormTopBarControlLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pictureBox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormTopBarControlLogo";
            this.Size = new System.Drawing.Size(31, 31);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox;

    }
}
