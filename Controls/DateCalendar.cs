#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Code;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Interfaces;

#endregion

namespace Library.Controls
{
    public partial class DateCalendar : UserControl, IJQControl, IMaskControl
    {
        private string GetJQScript()
        {
            try
            {
                var jquery = new UtilityJQuery();
                var jqscript = jquery.GetDate(editDay, editMonth, editYear, mask);
                return jqscript;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        
        protected override void Render(IContext objContext, IResponseWriter objWriter, long lngRequestID)
        {
            try
            {
                base.Render(objContext, objWriter, lngRequestID);
                ExecuteJQ();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void ExecuteJQ()
        {
            try
            {
                if (!DesignMode)
                {
                    var jqscript = GetJQScript();
                    if (jqscript != null && jqscript.Length > 0)
                        InvokeScript(jqscript);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
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
                editDay.ReadOnly = readOnly;
                editMonth.ReadOnly = readOnly;
                editYear.ReadOnly = readOnly;
                btnCalendar.Enabled = !readOnly;
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
                var readOnly = editDay.ReadOnly && editMonth.ReadOnly && editYear.ReadOnly;
                return readOnly;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
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
                if (editDay != null && editMonth != null && editYear != null)
                {
                    string day = editDay.Text.Replace(mask,null);
                    string month = editMonth.Text.Replace(mask, null);
                    string year = editYear.Text.Replace(mask+mask, null);
                    var value = UtilityValidation.GetData(day, month, year);
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
                if (editDay != null && editMonth != null && editYear != null)
                {
                    if (value != null)
                    {
                        var date = (DateTime)value;
                        editDay.Text = date.Day.ToString("00");
                        editMonth.Text = date.Month.ToString("00");
                        editYear.Text = date.Year.ToString("0000");
                    }
                    else
                    {
                        editDay.Text = mask;
                        editMonth.Text = mask;
                        editYear.Text = mask+mask;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string text= null;
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
                var splits = text.Split(new string[] {"/"}, StringSplitOptions.None);
                if (splits.Length >= 1)
                {
                    string day = splits[0];
                    editDay.Text = day;
                }
                if (splits.Length >= 2)
                {
                    string month = splits[1];
                    editMonth.Text = month;
                }
                if (splits.Length >= 3)
                {
                    string year = splits[2];
                    editYear.Text = year;
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
                string text = null;
                string day = editDay.Text.Replace(mask, null);
                string month = editMonth.Text.Replace(mask, null);
                string year = editYear.Text.Replace(mask+mask, null);
                if (day != null && day.Length > 0 && month != null && month.Length > 0 && year != null && year.Length > 0)
                    text = day+"/" + month+"/" + year;

                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        
        public DateCalendar()
        {
            InitializeComponent();
        }

        private void EditDateCalendar_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                var calendar = new Calendar(this);
                calendar.BackColor = Color.White;
                _value = GetValue();
                calendar.Value = (DateTime?)_value;
                calendar.Confirm += Calendar_Confirm;

                UtilityWeb.AddJQControl(btnCalendar, calendar, JQTypePosition.Docked);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ConfirmHanlder(DateTime? value);
        public event ConfirmHanlder Confirm;

        void Calendar_Confirm(DateTime? value)
        {
            try
            {
                SetValue(value);
                if (Confirm != null)
                    Confirm(value);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string mask = "--";
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
    }
}