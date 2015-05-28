using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IWorkFlow
    {
        TimeSpan Interval { get; set; }
        bool State { get; set; }
        DateTime LastWork { get; }
        IList<WorkProcess> WorkProcesses { get; }
        void Start();
        void Stop();

    }
}
