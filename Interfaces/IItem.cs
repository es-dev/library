using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IItem : ISpace
    {
        object Model { get; set; }
        void BindModel(object model);
        void BindView(object model);
        bool Selected { get; set; }
    }
}
