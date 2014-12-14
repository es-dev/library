using Gizmox.WebGUI.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IMaskControl : IControl
    {
        Color BackColor { get; set; }
        string Mask { get; set; }
        bool ReadOnly { get; set; }
        string Text { get; set; }
        object Value { get; set; }
        event EventHandler Leave;

    }
}
