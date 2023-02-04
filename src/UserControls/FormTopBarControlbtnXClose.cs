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
    public partial class FormTopBarControlbtnXClose : UserControl
    {
        public FormTopBarControlbtnXClose()
        {
            InitializeComponent();
        }

        private void btnXClose_Click(object sender, EventArgs e)
        {
			var f = base.ParentForm;
            if (f.Name == "Logs")
                this.FindForm().Hide();
            else
                this.FindForm().Close();
        }
    }
}
