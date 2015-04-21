#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Template.Forms;
using Library.Template.MVVM;

using Gizmox.WebGUI.Forms;
#endregion

namespace Library.Interfaces
{
    public interface IView : ISpace
    {
        IList<IItem> Items { get; set; }
        int Count {get; set;}
        int Take { get; set; }
        IItem SelectedItem { get; set; }
        void LoadItems();
        void RefreshItems();
        void RemoveItem(IItem item);
        bool Adding { get; set; }
    }
}
