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
                    var obj = (WorkFlow)model;
                    editState.Value = obj.State;
                    editLastWork.Value = obj.LastWork.ToString("dd/MM/yyyy HH:mm:ss");
                    editNextWork.Value = obj.LastWork.Add(obj.Interval).ToString("dd/MM/yyyy HH:mm:ss");
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