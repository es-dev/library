using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IWorkspace
    {
        void AddSpace(ISpace space,bool backclosing=false);
        void CloseSpace(ISpace space);
    }
}
