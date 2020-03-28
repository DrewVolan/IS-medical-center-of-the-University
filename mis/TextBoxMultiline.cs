using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mis
{
    public class TextBoxMultiline : TextBox
    {
        public bool Auto_Size
        {
            get { return this.AutoSize; }
            set { this.AutoSize = false; }
        }
        public bool Multi_Line
        {
            get { return this.Multiline; }
            set { this.Multiline = true; }
        }
        public TextBoxMultiline()
        {
            this.Auto_Size = false;
            this.Multi_Line = true;
        }
    }
}
