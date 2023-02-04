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
    public partial class FormTopBarControlLabelName : UserControl
    {
        #region [SOF: DEFINED VERIABLES]
        /// <summary>
        /// The state of the left mouse btn. 
        /// - true  : pressed and holded,
        /// - false : no pressed and holded in one time.
        /// </summary>
        private bool isButtonDown = false;
        /// <summary>
        /// Mouse location veriable on the screen
        /// </summary>
        private Point getMouseLocation;
        /*/// <summary>
        /// The state of number form child
        /// </summary>
        private int childFormNumber = 0;*/
        #endregion

        #region [FORM]
        /// <summary>
        /// Initialize window
        /// </summary>
        public FormTopBarControlLabelName()
        {
            InitializeComponent();
        }
        #endregion

        private void setTopBarLabelText()
        {
			var f = (Forms.FormLayout)this.FindForm();
            this.topBarLabelFormName.Text = f.Text;
		}

        #region [SOF: MOUSE EVENTS]
        /// <summary>
        /// Double click grow window form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topBarLabelFormName_DoubleClick(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState == FormWindowState.Maximized)
            {
                this.FindForm().WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Let window drag when mouse btn down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topBarLabelFormName_MouseDown(object sender, MouseEventArgs e)
        {
            isButtonDown = true;
            getMouseLocation = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// When mouse btn up let down form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topBarLabelFormName_MouseUp(object sender, MouseEventArgs e)
        {
            isButtonDown = false;
        }

        /// <summary>
        /// Move window form on mouse move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topBarLabelFormName_MouseMove(object sender, MouseEventArgs e)
        {
            if ((isButtonDown) && (e.Button == MouseButtons.Left))
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(getMouseLocation.X, getMouseLocation.Y);
                this.FindForm().Location = mousePosition;
            }
        }
        #endregion
    }
}
