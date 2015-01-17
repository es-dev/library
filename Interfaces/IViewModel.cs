using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IViewModel
    {
        ISpace Space { get; set; }
        IList<IItem> Items { get; set; }
        //int Count { get; }
        int GetCount(string search=null);
        void Load(int skip, int take, string search=null);
        bool Save(object model, bool creating);
        bool Delete(object model);
        object Read(object id);
    }
}
