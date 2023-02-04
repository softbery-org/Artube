namespace Artube.src.UserControls
{
    partial class FormTopBarControlbtnXMaximalize
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
            this.btnXMaximalize = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnXMaximalize
            // 
            this.btnXMaximalize.AutoSize = true;
            this.btnXMaximalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnXMaximalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXMaximalize.FlatAppearance.BorderSize = 0;
            this.btnXMaximalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.btnXMaximalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(143)))));
            this.btnXMaximalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXMaximalize.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXMaximalize.Image =global::Artube.Properties.Resources.application_16xLG;
            this.btnXMaximalize.Location = new System.Drawing.Point(0, 0);
            this.btnXMaximalize.Margin = new System.Windows.Forms.Padding(0);
            this.btnXMaximalize.Name = "btnXMaximalize";
            this.btnXMaximalize.Size = new System.Drawing.Size(31, 31);
            this.btnXMaximalize.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnXMaximalize, "Powiększanie okno \r\nna cały ekran");
            this.btnXMaximalize.UseVisualStyleBackColor = false;
            this.btnXMaximalize.Click += new System.EventHandler(this.btnXMaximalize_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Maksymalizuj okno";
            // 
            // FormTopBarControlbtnXMaximalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnXMaximalize);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormTopBarControlbtnXMaximalize";
            this.Size = new System.Drawing.Size(31, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnXMaximalize;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
