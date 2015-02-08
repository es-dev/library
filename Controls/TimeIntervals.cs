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
using Gizmox.WebGUI.Common.Interfaces;
using Library.Controls;
using Library.Interfaces;
using Library.Code.Enum;

#endregion

namespace Library.Controls
{
    public partial class TimeIntervals : UserControl, IJQControl, IMaskControl
    {
        private string jqscript = null;
        public string JQScript
        {
            get
            {
                jqscript = GetJQScript();
                return jqscript;
            }
        }

        private string GetJQScript()
        {
            try
            {
                var jquery = new UtilityJQuery();
                var jqscript = jquery.GetOra(editHour, editMinutes, mask);
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

        private void SetValue(object value)
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    if (value != null)
                    {
                        var time = (TimeSpan)value;
                        string hours = time.Hours.ToString("00");
                        string minutes = time.Minutes.ToString("00");
                        editHour.Text = hours;
                        editMinutes.Text = minutes;
                    }
                    else
                    {
                        editHour.Text = mask;
                        editMinutes.Text = mask;
                    }
                }
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
                if (editHour != null && editMinutes != null)
                {
                    TimeSpan? value = null;
                    string hours = editHour.Text.Replace(mask, null);
                    string minutes = editMinutes.Text.Replace(mask, null);
                    int? _hours = UtilityValidation.GetIntegerNothing(hours);
                    int? _minutes = UtilityValidation.GetIntegerNothing(minutes);
                    if (_hours != null && _minutes != null)
                        value = new TimeSpan((int)_hours, (int)_minutes, 0);
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                editHour.ReadOnly = readOnly;
                editMinutes.ReadOnly = readOnly;
                btnIntervals.Enabled = !readOnly;
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
                var readOnly = editHour.ReadOnly && editMinutes.ReadOnly;
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

        private string GetText()
        {
            try
            {
                string hours = editHour.Text.Replace(mask,null);
                string minutes = editMinutes.Text.Replace(mask, null);
                var text = hours + ":" + minutes;
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetText(string text)
        {
            try
            {
                var splits = text.Split(new string[] { ":" }, StringSplitOptions.None);
                if (splits.Length >= 1)
                {
                    string hour = splits[0];
                    editHour.Text = hour;
                }
                if (splits.Length >= 2)
                {
                    string minutes = splits[1];
                    editMinutes.Text = minutes;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private TimeSpan interval = new TimeSpan(0, 15, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
            set
            {
                interval = value;
            }
        }

        private TimeSpan startInterval = new TimeSpan(7, 00, 00);
        public TimeSpan StartInterval
        {
            get
            {
                return startInterval;
            }
            set
            {
                startInterval = value;
            }
        }

        private TimeSpan endInterval = new TimeSpan(21, 00, 00);
        public TimeSpan EndInterval
        {
            get
            {
                return endInterval;
            }
            set
            {
                endInterval = value;
            }
        }

        public TimeIntervals()
        {
            InitializeComponent();
        }

        private void EditTimeIntervals_Load(object sender, EventArgs e)
        {
            try
            { 

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void btnIntervals_Click(object sender, EventArgs e)
        {
            try
            {
                var intervals = new Intervals(this);
                intervals.Interval = interval;
                intervals.StartInterval = startInterval;
                intervals.EndInterval = endInterval;
                intervals.Confirm += OnConfirm;

                UtilityWeb.AddJQControl(btnIntervals, intervals, JQTypePosition.Docked);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        void OnConfirm(TimeSpan? value)
        {
            try
            {
                SetValue(value);
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