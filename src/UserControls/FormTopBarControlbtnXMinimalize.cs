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
    public partial class FormTopBarControlbtnXMinimalize : UserControl
    {
        public FormTopBarControlbtnXMinimalize()
        {
            InitializeComponent();
        }

        private void btnXMinimalize_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState != FormWindowState.Minimized)
            {
                this.FindForm().WindowState = FormWindowState.Minimized;
            }
        }
    }
}
