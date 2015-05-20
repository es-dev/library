using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IWorkProcess
    {
        TypeProcess State { get; }
        IWorkAction WorkAction { get; set; }
        bool Timeout { get; }
        DateTime TimeStart { get; }
        DateTime TimeStop { get; }
        void Start();
        void Stop();

    }
}
