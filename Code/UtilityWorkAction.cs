using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityWorkAction
    {

    }

    public class WorkAction : IWorkAction
    {

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual TimeSpan Interval { get; set; }

        public virtual System.Web.HttpContext Context { get; set; }

        public virtual void Start() { }

        private IList<WorkLog> logs = null;
        public IList<WorkLog> Logs
        {
            get
            {
                return logs;
            }
            set
            {
                logs = value;
            }
        }

        public WorkAction()
        {
            try
            {
                this.logs = new List<WorkLog>();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void AddLog(string description, string state)
        {
            try
            {
                var log = new WorkLog(this.Name, description, state);
                if(logs!=null)  
                    logs.Add(log);

                ClearLogs();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private int maxLogs = 20;
        private void ClearLogs()
        {
            try
            {
                if(logs!=null)
                {
                    if (logs.Count >= maxLogs)
                        logs.RemoveAt(0);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }

    public class WorkLog
    {
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public string State { get; set; }

        public WorkLog(string action, string description, string state)
        {
            try
            {
                this.Date = DateTime.Now;
                this.Action = action;
                this.Description = description;
                this.State = state;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
