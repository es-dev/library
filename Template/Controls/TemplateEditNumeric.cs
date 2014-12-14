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
    public partial class TemplateEditNumeric : EditControl
    {

        public TemplateEditNumeric()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
                editControl.Behavior = Library.Controls.TextBox.TypeBehavior.Numeric;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private int? _value = null;
        public new int? Value
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

        private void SetValue(int? _value)
        {
            try
            {
                editControl.Value = _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private int? GetValue()
        {
            try
            {
                var text = (string)editControl.Value;
                if (text != null && UtilityValidation.IsNumeric(text))
                {
                    var value = int.Parse(text);
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

             

    }
}