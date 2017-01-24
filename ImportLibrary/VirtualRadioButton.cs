using System;
using System.Collections.Generic;
using System.Text;

namespace 大學推甄校內志願選填系統.ImportLibrary
{
    public class VirtualRadioButton : VirtualCheckItem
    {
        public VirtualRadioButton() { }
        public VirtualRadioButton(string text)
        {
            this.Text = text;
        }
        public VirtualRadioButton(string text, bool check)
            : this(text)
        {
            this.Checked = check;
        }
    }
}
