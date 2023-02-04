namespace Artube.src.UserControls
{
    partial class FormTopBarControlbtnXMinimalize
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
            this.btnXMinimalize = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnXMinimalize
            // 
            this.btnXMinimalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnXMinimalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXMinimalize.FlatAppearance.BorderSize = 0;
            this.btnXMinimalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.btnXMinimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(143)))));
            this.btnXMinimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXMinimalize.Image = global::Artube.Properties.Resources.Symbols_Blocked_16xLG;
            this.btnXMinimalize.Location = new System.Drawing.Point(0, 0);
            this.btnXMinimalize.Margin = new System.Windows.Forms.Padding(0);
            this.btnXMinimalize.Name = "btnXMinimalize";
            this.btnXMinimalize.Size = new System.Drawing.Size(31, 31);
            this.btnXMinimalize.TabIndex = 4;
            this.btnXMinimalize.UseVisualStyleBackColor = false;
            this.btnXMinimalize.Click += new System.EventHandler(this.btnXMinimalize_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Przenieś do paska";
            // 
            // FormTopBarControlbtnXMinimalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.btnXMinimalize);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormTopBarControlbtnXMinimalize";
            this.Size = new System.Drawing.Size(31, 31);
            this.toolTip.SetToolTip(this, "Przenieś do paska");
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Button btnXMinimalize;
    }
}
