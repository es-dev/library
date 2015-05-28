using Gizmox.WebGUI.Common.Interfaces;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Code
{
    public class UtilityWorkProcess
    {
        public static IList<WorkProcess> GetWorkProcesses(HttpContext context)
        {
            try
            {
                var workProcesses = new List<WorkProcess>();
                var pathRoot = UtilityWeb.GetRootPath();
                var pathBin = pathRoot + @"bin";
                var files = System.IO.Directory.GetFiles(pathBin, "ES.*BusinessLogic*.dll");
                foreach (var file in files)
                {
                    var assembly = Assembly.LoadFile(file);
                    if (assembly != null)
                    {
                        var types = assembly.GetTypes();
                        if (types != null)
                        {
                            var typeWorkActions = (from q in types where q.GetInterface("Library.Interfaces.IWorkAction") != null select q).ToList();
                            if (typeWorkActions != null)
                            {
                                
                                foreach (var typeWorkAction in typeWorkActions)
                                {
                                    if (typeWorkAction != null)
                                    {
                                        var workAction = (IWorkAction)Activator.CreateInstance(typeWorkAction);
                                        workAction.Context = context;
                                        var workProcess = new WorkProcess(workAction);
                                        workProcess.Name = assembly.GetName().Name;
                                        workProcesses.Add(workProcess);
                                    }
                                }
                                
                            }
                        }
                    }
                }
                return workProcesses;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }

    public class WorkProcess : IWorkProcess
    {
        private string name = null;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private TypeProcess state = TypeProcess.None;
        public TypeProcess State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        private bool timeout = false;
        public bool Timeout
        {
            get
            {
                timeout = GetTimeout();
                return timeout;
            }
        }

        private bool GetTimeout()
        {
            try
            {
                var now = DateTime.Now;
                var elapsed = now.Subtract(timeStart);
                bool timeout = (elapsed.TotalSeconds >= interval.TotalSeconds);
                return timeout;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private TimeSpan interval = new TimeSpan(0, 1, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
        }

        private HttpContext context = null;
        public HttpContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }

        private DateTime timeStart = DateTime.MinValue;
        public DateTime TimeStart
        {
            get
            {
                return timeStart;
            }
        }

        private DateTime timeStop = DateTime.MinValue;
        public DateTime TimeStop
        {
            get
            {
                return timeStop;
            }
        }

        private IWorkAction workAction = null;
        public IWorkAction WorkAction
        {
            get
            {
                return workAction;
            }
        }

        public WorkProcess(IWorkAction workAction)
        {
            try
            {
                this.workAction = workAction;
                this.state = TypeProcess.Stopped;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void Start()
        {
            try
            {
                timeStart = DateTime.Now;
                state = TypeProcess.Started;
                UtilityAsync.Execute(workAction.Start, Stop);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void Stop()
        {
            try
            {
                timeStop = DateTime.Now;
                state = TypeProcess.Stopped;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        
    }
}
