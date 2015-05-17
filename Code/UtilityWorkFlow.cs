using Gizmox.WebGUI.Common.Interfaces;
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
        public static void Start(TimeSpan interval)
        {
            try
            {
                var processes = UtilityProcess.GetWorkProcesses();
                var workFlow = new WorkFlow(interval, processes); //todo: memorizzare workFlow in Application per manager
                UtilityAsync.Execute(workFlow.Start);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }
    }

    public class WorkFlow
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
                state = true;
            }
        }

        private IList<WorkProcess> processes = null;
        public IList<WorkProcess> Processes
        {
            get
            {
                return processes;
            }
        }

        public WorkFlow(TimeSpan interval, IList<WorkProcess> processes, bool state = true)
        {
            try
            {
                this.interval = interval;
                this.state = state;
                this.processes = processes;
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
                    foreach (var process in processes)
                    {
                        if (process.Timeout && (process.State == TypeProcess.Stopped))
                            process.Start();
                    }
                    if (!state)
                        break;

                    System.Threading.Thread.Sleep(interval);
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
