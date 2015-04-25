using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IViewModel
    {
        object GetDto();
        IView GetView();
        IItem GetItem(object model);
        IModel GetModel(object model);
        IList<IItem> Items { get; set; }
        int Count(string search=null);
        void Load(int skip, int take, string search=null);
        bool Save(object model, bool creating);
        bool Delete(object model);
        object Read(object id);
        void Fill(object start, object end, string search);
    }
}
