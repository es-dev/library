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
                    editControl.Value = _state.Value;
                    editControl.State = _state.State;
                    editControl.Description = _state.Description;    
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
                string _value = (string)editControl.Value; 
                string description = editControl.Description;
                var state = editControl.State;
                var stateDescription = new StateDescriptionImage(_value, state, description);
                var value = stateDescription.ToString();
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