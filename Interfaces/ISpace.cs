using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public delegate void CloseSpaceHandler();
    public delegate void OpenSpaceHandler();

    public interface ISpace
    {
        string Title { get; set; }
        string TitleSpace { get; set; }
        IWorkspace Workspace { get; set; }
        ISpace OwnerSpace { get; set; }
        Gizmox.WebGUI.Forms.Control Control { get; }
        IViewModel ViewModel { get; set; }
        event CloseSpaceHandler ClosedSpace;
        event OpenSpaceHandler OpenedSpace;
        void OpenSpace();
        void CloseSpace();

    }
}
