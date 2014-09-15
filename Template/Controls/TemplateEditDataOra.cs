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

#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditDataOra : UserControl , IEditControl
    {
        public TemplateEditDataOra()
        {
            InitializeComponent();
        }

        private object _value = null;
        public object Value
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

        private void SetValue(object _value)
        {
            try
            {
                var dataOra = (DateTime?)_value;
                DateTime? data = null;
                TimeSpan? ora = null;
                if (dataOra!=null)
                {
                    int year = dataOra.Value.Year;
                    int month = dataOra.Value.Month;
                    int day = dataOra.Value.Day;
                    int hours = dataOra.Value.Hour;
                    int minutes = dataOra.Value.Minute;
                    int seconds = dataOra.Value.Second;
                    data = new DateTime(year, month, day);
                    ora = new TimeSpan(hours, minutes, seconds);
                }
                editData.Value = data;
                editOra.Value = ora;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private object GetValue()
        {
            try
            {
                DateTime? value=null;
                var data = (DateTime?)editData.Value;
                var ora = (TimeSpan?)editOra.Value;
                if(data!=null && ora!=null)
                {
                    int year = data.Value.Year;
                    int month = data.Value.Month;
                    int day = data.Value.Day;
                    int hours = ora.Value.Hours;
                    int minutes = ora.Value.Minutes;
                    int seconds = ora.Value.Seconds;
                    value = new DateTime(year, month, day, hours, minutes, seconds);
                }
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private bool editing= false;
        public bool Editing
        {
            get
            {
                return editing;
            }
            set
            {
                editing = value;
                editData.Editing = editing;
                editOra.Editing = editing;
            }
        }

        private bool readOnly = false;
        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }
            set
            {
                readOnly = value;
                editData.ReadOnly = readOnly;
                editOra.ReadOnly = readOnly;
            }
        }

        private bool verified = true;
        public bool Verified
        {
            get
            {
                verified = IsVerified(required);
                return verified;
            }
        }

        private bool IsVerified(bool required)
        {
            try
            {
                bool dataVerified = editData.verified;
                bool oraVerified = editOra.Verified;
                bool verified = (dataVerified && oraVerified);
                return verified;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private bool required = false;
        public bool Required
        {
            get
            {
                return required;
            }
            set
            {
                required = value;
                editData.Required = required;
                editOra.Required = required;
            }
        }

        private bool changed = false;
        public bool Changed
        {
            get 
            {
                return changed;
            }
        }
    }
}