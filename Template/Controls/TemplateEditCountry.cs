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
    public partial class TemplateEditCountry : EditControl
    {
        public TemplateEditCountry()
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

        private Countries.City _value = null;
        public new Countries.City Value
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

        private Countries.City GetValue()
        {
            try
            {
                var _value = (Countries.City)editControl.Value;
                return _value;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public delegate void ConfirmHanlder(Countries.City value);
        public event ConfirmHanlder Confirm;

        private void editControl_Confirm(Countries.City value)
        {
            try
            {
                if (Confirm != null)
                    Confirm(value);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
    }
}