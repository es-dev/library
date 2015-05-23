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
                //btnSave.Visible = false;
                //btnUpdateCancel.Visible = false;
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
                    editState.Value = obj.State;
                    editLastWork.Value = obj.LastWork.ToString("dd/MM/yyyy HH:mm:ss");
                    editNextWork.Value = obj.LastWork.Add(obj.Interval).ToString("dd/MM/yyyy HH:mm:ss");
                    BindView(obj.WorkProcesses);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindView(IList<WorkProcess> workProcesses)
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

        private ListViewItem GetItem(WorkProcess workProcess)
        {
            try
            {
                var item = (from ListViewItem q in editWorkProcesses.Items where q.Tag != null && GetWorkProcess(q) == workProcess select q).FirstOrDefault();
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
                    item.SubItems.Add(workProcess.WorkAction.Name);
                    item.SubItems.Add(workProcess.TimeStart.ToString());
                    item.SubItems.Add(workProcess.Interval.ToString());
                    item.SubItems.Add(workProcess.State.ToString());

                    editWorkProcesses.Items.Add(item);                    
                }
                else
                {
                    item.SubItems[clmLastRunning.Index].Text = workProcess.TimeStart.ToString();
                    item.SubItems[clmInterval.Index].Text  = workProcess.Interval.ToString();
                    item.SubItems[clmState.Index].Text= workProcess.State.ToString();
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