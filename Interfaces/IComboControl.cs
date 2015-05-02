using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IComboControl
    {
        object Model {get; set;}
        int? Id { get; }
        void Show(IView view);
    }
}
