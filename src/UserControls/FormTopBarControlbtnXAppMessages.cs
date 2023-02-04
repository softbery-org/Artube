using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artube.src.UserControls
{
    public partial class FormTopBarControlbtnXAppMessages : UserControl
    {
        public FormTopBarControlbtnXAppMessages()
        {
            InitializeComponent();
        }

        private void btnXAppMessages_Click(object sender, EventArgs e)
        {
            Form fForm = new Form();
            fForm = (Form)this.FindForm();
            fForm.Show();
        }

        private void btnXAppMessages_MouseHover(object sender, EventArgs e)
        {
            this.btnXAppMessages.FlatAppearance.BorderSize = 1;
            this.btnXAppMessages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
        }

        private void btnXAppMessages_MouseLeave(object sender, EventArgs e)
        {
            this.btnXAppMessages.FlatAppearance.BorderSize = 0;
        }
    }
}
