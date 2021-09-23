using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GoodsPriceApp
{
    public class ZhmTextBox : TextBox
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        private string placeholder = string.Empty;
        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                SendMessage(Handle, EM_SETCUEBANNER, 0, Placeholder);
            }
        }
    }
}
