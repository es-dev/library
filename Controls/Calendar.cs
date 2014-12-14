#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;

#endregion

namespace Library.Controls
{
    public partial class Calendar : UserControl
    {
        private Control owner = null;
        public Calendar(Control owner)
        {
            InitializeComponent();
            try
            {
                this.owner = owner;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ConfirmHanlder(DateTime? value);
        public event ConfirmHanlder Confirm;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Confirm != null)
                    Confirm(monthCalendar.Value);

                UtilityWeb.RemoveJQControl(this);
                if(owner.CanFocus)
                    owner.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                UtilityWeb.RemoveJQControl(this);
                if (owner.CanFocus)
                    owner.Focus();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private DateTime? _value = null;
        public DateTime? Value
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

        private void SetValue(DateTime? _value)
        {
            try
            {
                if (_value == null)
                    monthCalendar.Value = DateTime.Today;
                else
                    monthCalendar.Value = (DateTime)_value;
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
                var _value=monthCalendar.Value;
                return _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}