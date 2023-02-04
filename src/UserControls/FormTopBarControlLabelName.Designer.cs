namespace Artube.src.UserControls
{
    partial class FormTopBarControlLabelName
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
			this.topBarLabelFormName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// topBarLabelFormName
			// 
			this.topBarLabelFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
			this.topBarLabelFormName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.topBarLabelFormName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topBarLabelFormName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
			this.topBarLabelFormName.ForeColor = System.Drawing.Color.White;
			this.topBarLabelFormName.Location = new System.Drawing.Point(0, 0);
			this.topBarLabelFormName.Margin = new System.Windows.Forms.Padding(0);
			this.topBarLabelFormName.Name = "topBarLabelFormName";
			this.topBarLabelFormName.Size = new System.Drawing.Size(716, 31);
			this.topBarLabelFormName.TabIndex = 2;
			this.topBarLabelFormName.Text = "SOF: ";
			this.topBarLabelFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.topBarLabelFormName.DoubleClick += new System.EventHandler(this.topBarLabelFormName_DoubleClick);
			this.topBarLabelFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarLabelFormName_MouseDown);
			this.topBarLabelFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBarLabelFormName_MouseMove);
			this.topBarLabelFormName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBarLabelFormName_MouseUp);
			// 
			// FormTopBarControlLabelName
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.topBarLabelFormName);
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "FormTopBarControlLabelName";
			this.Size = new System.Drawing.Size(716, 31);
			this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label topBarLabelFormName;

    }
}
