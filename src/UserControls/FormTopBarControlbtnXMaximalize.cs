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
    public partial class FormTopBarControlbtnXMaximalize : UserControl
    {
        public FormTopBarControlbtnXMaximalize()
        {
            InitializeComponent();
        }

        private void btnXMaximalize_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState != FormWindowState.Maximized)
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
                btnXMaximalize.Image = global::Artube.Properties.Resources.minimalize_view_16xLG;
            }
            else
            {
                this.FindForm().WindowState = FormWindowState.Normal;
                btnXMaximalize.Image = global::Artube.Properties.Resources.application_16xLG;

			}
        }
    }
}
