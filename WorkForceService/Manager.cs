#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Template.MVVM;
using Library.Code;
using Library.Interfaces;
using System.Linq;

#endregion

namespace Library.WorkForceService
{
    public partial class Manager : TemplateModel
    {
        public Manager()
        {
            InitializeComponent();
        }

        public override void Init()
        {
            try
            {
                base.Init();
                btnDelete.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                infoSubtitle.Text = "Enterprise Manager";
                infoSubtitleImage.Image = "Images.dashboard.account.png";
                infoTitle.Text = "WORK FORCE MANAGER";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)
        {
            try
            {
                if(model!=null)
                {
                    var obj = (IWorkFlow)model;
                    editStato.Value = obj.State;
                    editUltimoControllo.Value = obj.LastWork.ToString("dd/MM/yyyy HH:mm:ss");
                    editProssimoControllo.Value = obj.LastWork.Add(obj.Interval).ToString("dd/MM/yyyy HH:mm:ss");
                    BindViewWorkProcesses(obj.WorkProcesses);
                    BindViewWorkLogs(obj.WorkProcesses);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewWorkLogs(IList<WorkProcess> workProcesses)
        {
            try
            {
                if (workProcesses != null && workProcesses.Count >= 1)
                {
                    var logs=GetWorkLogs(workProcesses);
                    if (logs != null && logs.Count >= 1)
                    {
                        foreach (var log in logs)
                        {
                            var exist = ((from ListViewItem q in editLogs.Items where IsEqual((WorkLog)q.Tag, log) select q).Count() >= 1);
                            if (!exist)
                            {
                                var item = new ListViewItem();
                                item.SubItems.Add(log.Date.ToString());
                                item.SubItems.Add(log.Action);
                                item.SubItems.Add(log.Description);
                                item.SubItems.Add(log.State);
                                item.Tag = log;

                                editLogs.Items.Insert(0, item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsEqual(WorkLog tagLog, WorkLog log)
        {
            try
            {
                if(tagLog!=null)
                {
                    var equal = (tagLog.Date == log.Date && tagLog.Action == log.Action);
                    return equal;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static IList<WorkLog> GetWorkLogs(IList<WorkProcess> workProcesses)
        {
            try
            {
                var logs = new List<WorkLog>();
                foreach (var workProcess in workProcesses)
                {
                    var workAction = workProcess.WorkAction;
                    if (workAction != null)
                    {
                        var logsWorkAction = workAction.Logs;
                        if (logsWorkAction != null && logsWorkAction.Count >= 1)
                        {
                            logs.AddRange(logsWorkAction);
                        }
                    }
                }
                var workLogs = (from q in logs orderby q.Date ascending select q).Take(20).ToList();

                return workLogs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
            
        }

        private void BindViewWorkProcesses(IList<WorkProcess> workProcesses)
        {
            try
            {
                if (workProcesses != null && workProcesses.Count >= 1)
                {
                    foreach(var workProcess in workProcesses)
                    {
                        var item = GetItem(workProcess);
                        BindView(item, workProcess);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                var obj = (IWorkFlow)model;
                var enabled = UtilityValidation.GetBoolean(editStato.Value);
                if (enabled)
                    obj.Start();
                else
                    obj.Stop();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private ListViewItem GetItem(WorkProcess workProcess)
        {
            try
            {
                var item = (from ListViewItem q in editProcessi.Items where q.Tag != null && GetWorkProcess(q) == workProcess select q).FirstOrDefault();
                return item;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private WorkProcess GetWorkProcess(ListViewItem item)
        {
            try
            {
                var workProcess = (WorkProcess)item.Tag;
                return workProcess;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void BindView(ListViewItem item, WorkProcess workProcess)
        {
            try
            {
                if (item == null)
                {
                    item = new ListViewItem();
                    item.Tag = workProcess;
                    item.SubItems.Add(workProcess.Name);
                    item.SubItems.Add(workProcess.WorkAction.Description);
                    item.SubItems.Add(workProcess.TimeStart.ToString());
                    item.SubItems.Add(workProcess.Interval.ToString());

                    editProcessi.Items.Add(item);                    
                }
                else
                {
                    item.SubItems[clmLastRunning.Index].Text = workProcess.TimeStart.ToString();
                    item.SubItems[clmInterval.Index].Text  = workProcess.Interval.ToString();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void timerWorkForce_Tick(object sender, EventArgs e)
        {
            try
            {
                UtilityAsync.Execute(new Action(RefreshView));
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void RefreshView()
        {
            try
            {
                var model = UtilityWorkFlow.Read();
                BindView(model);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        
    }
}