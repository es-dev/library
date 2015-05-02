using Gizmox.WebGUI.Forms;
using Library.Code;
using Library.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Library.Template.Controls;
using Library.Interfaces;
using System.Linq;

namespace Library.Template.Controls
{
    public partial class TemplateEditCombo : EditControl, IComboControl 
	{
        public TemplateEditCombo()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
                editControl.ComboClick -= editControl_ComboClick;
                editControl.ComboClick += editControl_ComboClick;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
               
        private object model = null;
        public object Model
        {
            get 
            {
                return model;
            }
            set 
            {
                model = value;
            }
        }

        private int? id = null;
        public int? Id
        {
            get
            {
                id = (int?)UtilityPOCO.GetPrimaryKeyValue(model);
                return id;
            }
        }

        private IView view = null;
        public void Show(IView view)
        {
            try
            {
                this.view = view;
                if (view != null)
                {
                    SetLayoutView(view);
                    var owner = this.Parent;
                    var popup = new Popup(owner, TypeDirection.Vertical);
                    popup.Confirm += OnConfirm;
                    popup.Show(view.Control);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetLayoutView(IView view)
        {
            try
            {
                if(view!=null && view.Control!=null)
                {
                    var control=view.Control;
                    if(control!=null)
                    {
                        var controls=control.Controls;
                        if(controls!=null)
                        {
                            var panelCommands = (from Control q in controls where q.Name == "panelCommands" select q).FirstOrDefault();
                            if(panelCommands!=null)
                                panelCommands.Visible = false;
                        }
                    }
                     
                }                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ComboConfirmHanlder(object model);
        public event ComboConfirmHanlder ComboConfirm;

        private void OnConfirm()
        {
            try
            {
                if (view != null)
                {
                    var item = view.SelectedItem;
                    if (item != null)
                    {
                        model = item.Model;
                        editControl.Focus();
                        if (ComboConfirm != null)
                            ComboConfirm(model);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ComboClickHandler();
        public event ComboClickHandler ComboClick;

        private void editControl_ComboClick()
        {
            try
            {
                if (editControl != null && !editControl.ReadOnly)
                {
                    if (ComboClick != null)
                        ComboClick();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public new string Value
        {
            get
            {
                return (string)editControl.Value;
            }
            set
            {
                editControl.Value = value;
            }
        }
    }
}
