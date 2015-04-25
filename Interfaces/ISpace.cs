using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public delegate void OpenHandler();
    public delegate void CloseHandler();

    public interface ISpace
    {
        IViewModel ViewModel { get; set; }
        string Title { get; set; }
        string TitleSpace { get; set; }
        IWorkspace Workspace { get; set; }
        ISpace OwnerSpace { get; set; }
        Gizmox.WebGUI.Forms.Control Control { get; }
        event CloseHandler Closed;
        event OpenHandler Opened;
        void Open(bool backclosing=false);
        void Close();

    }
}
