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
	public partial class TemplateEditCombo : TemplateEditText
	{
        private int labelWidth = 108;
        
        public override int LabelWidth
        {
            get
            {
                return labelWidth;
            }
            set
            {
                labelWidth = value;
                SetLabelWidth();
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
                id = (int?)UtilityPOCO.GetValue(model,"Id");
                return id;
            }
        }

		public TemplateEditCombo()
		{
			InitializeComponent();
		}

        IView view = null;
        public void Show(IView view)
        {
            try
            {
                if (!editValue.ReadOnly)
                {
                    
                    this.view = view;
                    SetLayoutControl();
                    var owner = this.Parent;
                    var popup = new Popup(owner, TypeDirection.Vertical);
                    popup.Confirm += OnConfirm;
                    popup.Cancel += OnCancel;
                    popup.Show(view.Control);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetLayoutControl()
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
                            var controlPanel = (from Control q in controls where q.Name == "panelCommands" select q).FirstOrDefault();
                            if(controlPanel!=null)
                                controlPanel.Visible = false;
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
        public delegate void ComboCancelHanlder();

        
        public event ComboConfirmHanlder ComboConfirm;
       
        
        public event ComboCancelHanlder ComboCancel;

        private void OnConfirm()
        {
            try
            {
                var item = view.SelectedItem;
                if (item != null)
                {
                    model = item.Model;
                    editValue.Focus();
                    if (ComboConfirm != null)
                        ComboConfirm(model);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void OnCancel()
        {
            try
            {
                if (ComboCancel != null)
                    ComboCancel();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ComboClickHandler();
        public event ComboClickHandler ComboClick;

        private void showCombo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboClick != null)
                    ComboClick();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetLabelWidth()
        {
            try
            {
                if (editValue != null && editLabel != null)
                {
                    editLabel.Width = labelWidth;
                    editValue.Left = editLabel.Left + editLabel.Width;
                    editValue.Width = this.Width - labelWidth - imgEdit.Width;
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }        

	}
}
