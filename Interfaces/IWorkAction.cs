using Library.Code;
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
        string Name { get; }
        string Description { get; }
        TimeSpan Interval { get; }
        HttpContext Context { get; set; }
        void Start();
        IList<WorkLog> Logs { get; set; }
    }

}
