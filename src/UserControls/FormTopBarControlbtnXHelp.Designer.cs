namespace Artube.src.UserControls
{
    partial class FormTopBarControlbtnXHelp
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
            this.components = new System.ComponentModel.Container();
            this.btnXHelp = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnXHelp
            // 
            this.btnXHelp.AutoSize = true;
            this.btnXHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnXHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXHelp.FlatAppearance.BorderSize = 0;
            this.btnXHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.btnXHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(143)))));
            this.btnXHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXHelp.Image = global::Artube.Properties.Resources.Symbols_Help_and_inclusive_16xLG;
			this.btnXHelp.Location = new System.Drawing.Point(0, 0);
            this.btnXHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnXHelp.Name = "btnXHelp";
            this.btnXHelp.Size = new System.Drawing.Size(31, 31);
            this.btnXHelp.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnXHelp, "Wyświetlanie pomocy\r\ndla aktualnego okna");
            this.btnXHelp.UseVisualStyleBackColor = false;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Pomoc dla aplikacji";
            // 
            // FormTopBarControlbtnXHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnXHelp);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormTopBarControlbtnXHelp";
            this.Size = new System.Drawing.Size(31, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnXHelp;
        private System.Windows.Forms.ToolTip toolTip;

    }
}
