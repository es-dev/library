using Gizmox.WebGUI.Common.Interfaces;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.Code
{
    public class UtilityWorkFlow
    {
        public static string Name = "WorkFlow";
        private static bool started=false;
        private static HttpContext context = null;

        public static void Start(HttpContext context, TimeSpan interval)
        {
            try
            {
                UtilityWorkFlow.context = context;
                if (!started)
                {
                    started = true;
                    var processes = UtilityWorkProcess.GetWorkProcesses(context);
                    var workFlow = new WorkFlow(interval, processes);
                    if(context!=null)
                        context.Application[Name] = workFlow;
                    UtilityAsync.Execute(workFlow.Start);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public static void Stop()
        {
            try
            {
                started = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        internal static WorkFlow Read()
        {
            try
            {
                if (context != null)
                {
                    var workFlow = (WorkFlow)context.Application[Name];
                    return workFlow;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }

    public class WorkFlow : IWorkFlow
    {
        private TimeSpan interval = new TimeSpan(0,5,0);
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

        private bool state = true;
        public bool State
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

        private DateTime lastWork = DateTime.MinValue;
        public DateTime LastWork
        {
            get
            {
                return lastWork;
            }
        }

        private IList<WorkProcess> workProcesses = null;
        public IList<WorkProcess> WorkProcesses
        {
            get
            {
                return workProcesses;
            }
        }

        public WorkFlow(TimeSpan interval, IList<WorkProcess> workProcesses)
        {
            try
            {
                this.interval = interval;
                this.workProcesses = workProcesses;
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
                state = true;
                while (state)
                {
                    if (workProcesses != null && workProcesses.Count >= 1)
                    {
                        foreach (var workProcess in workProcesses)
                        {
                            if (workProcess.Timeout && (workProcess.State == TypeProcess.Stopped))
                                workProcess.Start();
                        }
                    }
                    if (!state)
                        break;

                    System.Threading.Thread.Sleep(interval);
                    lastWork = DateTime.Now;
                }
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
                state = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
