#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Interfaces;
using Library.Code;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Controls;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditState : EditControl
    {

        public TemplateEditState()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string _value = null; 
        public new string Value
        {
            get
            {
                _value = GetValue();
                return _value; 
            }
            set
            {
                _value = value;
                SetValue(_value);
            }
        }
        
        private void SetValue(string value)
        {
            try
            {
                if (value != null && value.Length > 0)
                {
                    var _state = new StateDescriptionImage(value);
                    editControl.Value = _state.Description;
                    editControl.State = _state.State;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetValue()
        {
            try
            {
                string description = (string)editControl.Value;
                var state = editControl.State;
                var _state = new StateDescriptionImage(state, description);
                var value = _state.ToString();
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


    }
}