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
    public class UtilityProcess
    {
        public static IList<WorkProcess> GetWorkProcesses()
        {
            try
            {
                var processes = new List<WorkProcess>();
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
                            var type = (from q in types where q.GetInterface("Library.Interfaces.IWorkFlow") != null select q).FirstOrDefault();
                            if (type != null)
                            {
                                var workFlow = (IWorkFlow)Activator.CreateInstance(type);
                                var action = new Action(workFlow.Tick);
                                var name = workFlow.Name;
                                var interval = workFlow.Interval;
                                var process = new WorkProcess(name, interval, action);
                                processes.Add(process);
                            }
                        }
                    }
                }
                return processes;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }

    public class WorkProcess
    {
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

        private string name = null;
        public string Name
        {
            get
            {
                return name;
            }
        }

        private Action action = null;
        public Action Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }

        private TimeSpan interval = new TimeSpan(0, 5, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
            set
            {
                interval = value;
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

        public WorkProcess(string name, TimeSpan interval, Action action)
        {
            try
            {
                this.name = name;
                this.interval = interval;
                this.action = action;
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
                UtilityAsync.Execute(action, Stop);
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
