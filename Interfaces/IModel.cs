using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IModel : ISpace
    {
        object Model { get; set; }
        void BindModel(object model);
        void BindView(object model);
        IItem OwnerItem { get; set; }
        bool Verified { get; }
        bool Changed { get; }
        bool Creating { get; set; }
        bool Editing { get; set; }
        bool Deleting { get; set; }
        bool Updating { get; set; }
    }
}
