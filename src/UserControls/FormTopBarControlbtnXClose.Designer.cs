namespace Artube.src.UserControls
{
    partial class FormTopBarControlbtnXClose
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
            this.btnXClose = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnXClose
            // 
            this.btnXClose.AutoSize = true;
            this.btnXClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnXClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXClose.FlatAppearance.BorderSize = 0;
            this.btnXClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.btnXClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(143)))));
            this.btnXClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXClose.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXClose.Image = global::Artube.Properties.Resources.Symbols_Critical_16xLG;
            this.btnXClose.Location = new System.Drawing.Point(0, 0);
            this.btnXClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnXClose.Name = "btnXClose";
            this.btnXClose.Size = new System.Drawing.Size(31, 31);
            this.btnXClose.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnXClose, "Zamknij okno");
            this.btnXClose.UseVisualStyleBackColor = false;
            this.btnXClose.Click += new System.EventHandler(this.btnXClose_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Zamknij okno";
            // 
            // FormTopBarControlbtnXClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnXClose);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormTopBarControlbtnXClose";
            this.Size = new System.Drawing.Size(31, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Button btnXClose;
    }
}
