using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface ISpace
    {
        string Title { get; set; }
        string TitleSpace { get; set; }
        IWorkspace Workspace { get; set; }
        ISpace OwnerSpace { get; set; }
        Gizmox.WebGUI.Forms.Control Control { get; }
        IViewModel ViewModel { get; set; }


    }
}
