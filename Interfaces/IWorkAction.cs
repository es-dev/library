using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Interfaces
{
    public interface IWorkAction
    {
        void Tick();
        string Name { get; }
        TimeSpan Interval { get; }
        HttpContext Context { get; set; }
    }
}
