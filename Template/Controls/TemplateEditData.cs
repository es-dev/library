#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Controls;
using Library.Code;

using Library.Interfaces;
#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditData : EditControl
    {
        public TemplateEditData()
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

        private DateTime? _value = null;
        public new DateTime? Value
        {
            get
            {
                _value = GetValue();
                return _value;
            }
            set
            {
                _value = value;
                SetValue();
            }
        }

        private void SetValue()
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

        private DateTime? GetValue()
        {
            try
            {
                var _value = (DateTime?)editControl.Value;
                return _value;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public delegate void ConfirmHanlder(DateTime? value);
        public event ConfirmHanlder Confirm;

        private void editControl_Confirm(DateTime? value)
        {
            try
            {
                if (Confirm != null)
                {
                    Confirm(value);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
    }
}