using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Interfaces
{
    public interface IWorkProcess : IWorkAction
    {
        TypeProcess State { get; }
        bool Timeout { get; }
        DateTime TimeStart { get; }
        DateTime TimeStop { get; }
        void Stop();
        IWorkAction WorkAction { get; }
    }
}
