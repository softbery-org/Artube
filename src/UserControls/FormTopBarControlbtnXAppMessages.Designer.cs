namespace Artube.src.UserControls
{
    partial class FormTopBarControlbtnXAppMessages
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
            this.btnXAppMessages = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnXAppMessages
            // 
            this.btnXAppMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.btnXAppMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXAppMessages.FlatAppearance.BorderSize = 0;
            this.btnXAppMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.btnXAppMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(233)))), ((int)(((byte)(143)))));
            this.btnXAppMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXAppMessages.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXAppMessages.Image = global::Artube.Properties.Resources.Comment_11698;
            this.btnXAppMessages.Location = new System.Drawing.Point(0, 0);
            this.btnXAppMessages.Margin = new System.Windows.Forms.Padding(0);
            this.btnXAppMessages.Name = "btnXAppMessages";
            this.btnXAppMessages.Size = new System.Drawing.Size(31, 31);
            this.btnXAppMessages.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnXAppMessages, "Wiadomości systemowe, np.: aktualizacje,\r\ninformacje dla użytkownika");
            this.btnXAppMessages.UseVisualStyleBackColor = false;
            this.btnXAppMessages.MouseLeave += new System.EventHandler(this.btnXAppMessages_MouseLeave);
            this.btnXAppMessages.MouseHover += new System.EventHandler(this.btnXAppMessages_MouseHover);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Wiadomości aplikacji, np.: aktualizacje";
            // 
            // FormTopBarControlbtnXAppMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.btnXAppMessages);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormTopBarControlbtnXAppMessages";
            this.Size = new System.Drawing.Size(31, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Button btnXAppMessages;
    }
}
