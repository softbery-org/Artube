using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Artube.src.Buttons
{
    #region [SOF: ENUMERATION ARGUMENTS]
    /// <summary>
    /// Button color arguments
    /// </summary>
    public enum BtnOptionsArgs
    {
        // Color
        Color,
        HoverColor,
        ClickColor,
        // Border
        BorderColor,
        BorderHoverColor,
        BorderClickColor,
        // Text
        TextColor,
        TextHoverColor,
        TextClickColor,
        // Text
        Text,
        HoverText,
        ClickText,
        // Font
        FontSize,
        HoverFontSize,
        ClickFontSize,
        FontFamily,
        HoverFontFamily,
        ClickFontFamily,
        FontStyle,
        HoverFontStyle,
        ClickFontStyle,
    }
    #endregion

    public class Btn : EventArgs
    {
        #region [SOF: ACCESSORS]
        /// <summary>
        /// Value type
        /// </summary>
        public Type T { get; set; }
        /// <summary>
        /// Alpha value. Get value range from 0 to 255
        /// </summary>
        private int A { get; set; }
        /// <summary>
        /// Red color. Get value range from 0 to 255
        /// </summary>
        private int R { get; set; }
        /// <summary>
        /// Green color. Get value range from 0 to 255
        /// </summary>
        private int G { get; set; }
        /// <summary>
        /// Blue color. Get value range from 0 to 255
        /// </summary>
        private int B { get; set; }
        /// <summary>
        /// Color name. Get value from string
        /// </summary>
        public string ColorName { get; set; }
        /// <summary>
        /// Button background color
        /// </summary>
        public Color BtnColor { get; private set; }
        /// <summary>
        /// Button background color when mouse is over the btn
        /// </summary>
        public Color BtnHoverColor { get; private set; }
        /// <summary>
        /// Button background color when the btn is clicked
        /// </summary>
        public Color BtnClickColor { get; private set; }
        /// <summary>
        /// Button border color
        /// </summary>
        public Color BtnBorderColor { get; private set; }
        /// <summary>
        /// Button border color when mouse is over the btn
        /// </summary>
        public Color BtnBorderHoverColor { get; private set; }
        /// <summary>
        /// Button border color when the btn is clicked
        /// </summary>
        public Color BtnBorderClickColor { get; private set; }
        /// <summary>
        /// Button text color
        /// </summary>
        public Color BtnTextColor { get; private set; }
        /// <summary>
        /// Button text color when mouse is over the btn
        /// </summary>
        public Color BtnTextHoverColor { get; private set; }
        /// <summary>
        /// Button text color when the btn is clicked
        /// </summary>
        public Color BtnTextClickColor { get; private set; }
        /// <summary>
        /// Button text
        /// </summary>
        public string BtnText { get; set; }
        /// <summary>
        /// Button text when mouse is over the btn
        /// </summary>
        public string BtnHoverText { get; set; }
        /// <summary>
        /// Button text when the btn is clicked
        /// </summary>
        public string BtnClickText { get; set; }
        /// <summary>
        /// Write class name
        /// </summary>
        public string GetClassName { get; private set; }
        #endregion

        #region [SOF: DEFINED VERIABLES]
        /// <summary>
        /// List of enabled options
        /// </summary>
        private List<Enum> enumOption = new List<Enum>();
        #endregion

        #region [SOF: CLASS CONSTRUCTOR]
        /// <summary>
        /// Button arguments class constructor
        /// </summary>
        public Btn()
        {
            InitializeDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public Btn(Dictionary<BtnOptionsArgs, string> options)
        {
            if (options!=null)
            {
                InitializeChangeArgs(options);
            }
        }
        #endregion

        #region [SOF: METHODS]
        /// <summary>
        /// Method get class name
        /// </summary>
        private void SetClassName()
        {
            this.GetClassName = this.GetType().Name;
        }

        /// <summary>
        /// Initialize default values for arguments
        /// </summary>
        private void InitializeDefault()
        {
            // Set class name
            SetClassName();

            BtnOptionsArgs options = new BtnOptionsArgs();
            switch (options)
            {
                case BtnOptionsArgs.Color:
                    this.BtnColor = SetColor(77, 96, 130);
                    break;
                case BtnOptionsArgs.HoverColor:
                    this.BtnHoverColor = SetColor(77, 96, 130);
                    break;
                case BtnOptionsArgs.ClickColor:
                    this.BtnClickColor = SetColor(77, 96, 130);
                    break;
                case BtnOptionsArgs.BorderColor:
                    this.BtnBorderColor = SetColor(0, 0, 0);
                    break;
                case BtnOptionsArgs.BorderHoverColor:
                    this.BtnBorderHoverColor = SetColor(0, 0, 0);
                    break;
                case BtnOptionsArgs.BorderClickColor:
                    this.BtnBorderClickColor = SetColor(0, 0, 0);
                    break;
                case BtnOptionsArgs.TextColor:
                    this.BtnTextColor = SetColor(255, 255, 255);
                    break;
                case BtnOptionsArgs.TextHoverColor:
                    this.BtnTextHoverColor = SetColor(0, 0, 0);
                    break;
                case BtnOptionsArgs.TextClickColor:
                    this.BtnTextClickColor = SetColor(0, 0, 0);
                    break;
                case BtnOptionsArgs.Text:
                    this.BtnText = "Button";
                    break;
                case BtnOptionsArgs.HoverText:
                    this.BtnHoverText = "Button";
                    break;
                case BtnOptionsArgs.ClickText:
                    this.BtnClickText = "Button";
                    break;
                case BtnOptionsArgs.FontSize:

                    break;
                case BtnOptionsArgs.HoverFontSize:

                    break;
                case BtnOptionsArgs.ClickFontSize:

                    break;
                case BtnOptionsArgs.FontFamily:

                    break;
                case BtnOptionsArgs.HoverFontFamily:

                    break;
                case BtnOptionsArgs.ClickFontFamily:

                    break;
                case BtnOptionsArgs.FontStyle:

                    break;
                case BtnOptionsArgs.HoverFontStyle:

                    break;
                case BtnOptionsArgs.ClickFontStyle:

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        private void InitializeChangeArgs(Dictionary<BtnOptionsArgs, string> options)
        {
            // Class name
            SetClassName();
            // Color veriable
            Color color = new Color();

            foreach (var option in options)
            {
                if ((option.Key == BtnOptionsArgs.Color) || 
                     (option.Key == BtnOptionsArgs.HoverColor) ||
                     (option.Key == BtnOptionsArgs.ClickColor) ||
                     (option.Key == BtnOptionsArgs.TextColor) ||
                     (option.Key == BtnOptionsArgs.TextHoverColor) ||
                     (option.Key == BtnOptionsArgs.TextClickColor) ||
                     (option.Key == BtnOptionsArgs.BorderColor) || 
                     (option.Key == BtnOptionsArgs.BorderHoverColor) ||
                     (option.Key == BtnOptionsArgs.BorderClickColor))
                {
                    ArgbFromString(option.Value);
                    color = SetColor(R, G, B, A);
                    switch (option.Key)
                    {
                        case BtnOptionsArgs.Color:
                            this.BtnColor = color;
                            break;
                        case BtnOptionsArgs.HoverColor:
                            this.BtnHoverColor = color;
                            break;
                        case BtnOptionsArgs.ClickColor:
                            this.BtnClickColor = color;
                            break;
                        case BtnOptionsArgs.BorderColor:
                            this.BtnBorderColor = color;
                            break;
                        case BtnOptionsArgs.BorderHoverColor:
                            this.BtnBorderHoverColor = color;
                            break;
                        case BtnOptionsArgs.BorderClickColor:
                            this.BtnBorderClickColor = color;
                            break;
                        case BtnOptionsArgs.TextColor:
                            this.BtnTextColor = color;
                            break;
                        case BtnOptionsArgs.TextHoverColor:
                            this.BtnTextHoverColor = color;
                            break;
                        case BtnOptionsArgs.TextClickColor:
                            this.BtnTextClickColor = color;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Method create values R, G, B and A from incoming <typeparamref name="String"/>
        /// </summary>
        /// <param name="value"></param>
        private void ArgbFromString(string value)
        {
            Char[] delimiter = new Char[] { ',', ';' };
            string[] result = value.Split(delimiter, 4);
            int val = -1;
            int i = 0;
            if ((result.Count() >= 3) && (result.Count() <= 4))
            {
                foreach (var item in result)
                {
                    val = -1;
                    val = Convert.ToInt16(item);
                    switch (i)
                    {
                        case 0:
                            this.R = val;
                            break;
                        case 1:
                            this.G = val;
                            break;
                        case 2:
                            this.B = val;
                            break;
                        case 3:
                            this.A = val;
                            break;
                    }
                    i++;
                }
            }
            else
            {
                throw (new Exception(String.Format("{0} [xxx]: No arguments for RGBA parameters;", this.GetClassName)));
            }
        }

        /// <summary>
        /// Method set color from ARGB
        /// </summary>
        /// <remarks>Method gets on enter RGBA values, for each value get range from 0 to 255,  <typeparamref name="Int8"/> type</remarks>
        /// <param name="r">Red <typeparamref name="Int"/> 8-byte</param>
        /// <param name="g">Green <typeparamref name="Int"/> 8-byte</param>
        /// <param name="b">Blue <typeparamref name="Int"/> 8-byte</param>
        /// <param name="a">Aplha <typeparamref name="Int"/> 8-byte. Alpha value is a optional</param>
        /// <returns><typeparamref name="Color"/></returns>
        private Color SetColor(int r, int g, int b, int a = -1)
        {
            Color color = new Color();
            if (a!=-1)
            {
                if (((a >= 0) && (a <= 255)) && ((r >= 0) && (r <= 255)) && ((g >= 0) && (g <= 255)) && ((b >= 0) && (b <= 255)))
                {
                    try
                    {
                        color = System.Drawing.Color.FromArgb(((int)((byte)(a))), ((int)((byte)(r))), ((int)((byte)(g))), ((int)((byte)(b))));
                        return color;
                    }
                    catch (Exception ex)
                    {
                        throw (new Exception(String.Format("{0} [{1}]: {2}", this.GetClassName, ex.HResult, ex.Message)));
                    }
                }
                else
                {
                    throw (new Exception(String.Format("{0} [xxx]: Some arguments have bad value: [R: {1}]; [G: {2}]; [B: {3}]; [A: {4}];", this.GetClassName, r, g, b, a)));
                }
            }
            else if (((r >= 0) && (r <= 255)) && ((g >= 0) && (g <= 255)) && ((b >= 0) && (b <= 255)))
            {
                try
                {
                    color = System.Drawing.Color.FromArgb(((int)((byte)(r))), ((int)((byte)(g))), ((int)((byte)(b))));
                    return color;
                }
                catch (Exception ex)
                {
                    throw (new Exception(String.Format("{0} [{1}]: {2}", this.GetClassName, ex.HResult, ex.Message)));
                }
            }
            else
            {
                throw (new Exception(String.Format("{0} [xxx]: Some arguments have bad value: [R: {1}]; [G: {2}]; [B: {3}];", this.GetClassName, r, g, b)));
            }
        }
        #endregion
    }
}
