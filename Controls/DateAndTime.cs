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
using Library.Interfaces;

#endregion

namespace Library.Controls
{
    public partial class DateAndTime : UserControl, IMaskControl
    {
        public DateAndTime()
        {
            InitializeComponent();
        }

        private Color backColor = Color.Transparent;
        public override Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                SetBackColor(backColor);
            }
        }

        private void SetBackColor(Color backColor)
        {
            try
            {
                base.BackColor = backColor;
                editDate.BackColor = backColor;
                editTime.BackColor = backColor;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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

        private object GetValue()
        {
            try
            {
                var date = editDate.Value;
                var time = editTime.Value;
                if(date!=null && time!=null)
                {
                    var _date = (DateTime)date;
                    var _time = (TimeSpan)time;
                    var value = new DateTime(_date.Year,_date.Month,_date.Day,_time.Hours,_time.Minutes,_time.Seconds);
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetValue(object value)
        {
            try
            {
                if (value != null)
                {
                    var _value = (DateTime)value;
                    var date = _value;
                    var time = new TimeSpan(_value.Hour, _value.Minute, _value.Second);
                    editDate.Value = date;
                    editTime.Value = time;
                }
                else
                {
                    editDate.Value = null;
                    editTime.Value = null;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string text = null;
        public override string Text
        {
            get
            {
                text = GetText();
                return text;
            }
            set
            {
                text = value;
                SetText(text);
            }
        }

        private void SetText(string text)
        {
            try
            {
                var splits = text.Split(new string[] { " " }, StringSplitOptions.None);
                if (splits.Length >= 2)
                {
                    editDate.Text = splits[0];
                    editTime.Text = splits[1];
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string GetText()
        {
            try
            {
                var text = "";
                var textDate = editDate.Text;
                var textTime = editTime.Text;
                if (textDate != null)
                    text = textDate;
                if (textTime != null)
                    text += " " + textTime;
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string mask = "";
        public string Mask
        {
            get
            {
                return mask;
            }
            set
            {
                mask = value;
            }
        }

        private bool readOnly = false;
        public bool ReadOnly
        {
            get
            {
                readOnly = GetReadOnly();
                return readOnly;
            }
            set
            {
                readOnly = value;
                SetReadOnly(readOnly);
            }
        }

        private void SetReadOnly(bool readOnly)
        {
            try
            {
                editDate.ReadOnly = readOnly;
                editTime.ReadOnly = readOnly;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool GetReadOnly()
        {
            try
            {
                var readOnly = editDate.ReadOnly && editTime.ReadOnly;
                return readOnly;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }
    }
}