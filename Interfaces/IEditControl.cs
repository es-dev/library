using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IEditControl 
    {
        bool Editing { get; set; }
        bool ReadOnly { get; set; }
        bool Verified { get; }
        bool Required { get; set; }
        bool Changed { get; }
    }
}
