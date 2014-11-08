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


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditOra : UserControl, IEditControl, IEditValue<TimeSpan?>
    {
        const string mask = "--";
        private string JQScript = null;
        protected override void Render(IContext objContext, IResponseWriter objWriter, long lngRequestID)
        {
            try
            {
                base.Render(objContext, objWriter, lngRequestID);
                InitJQ();
                ExecuteJQ();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void InitJQ()
        {
            try
            {
                var jquery = new UtilityJQuery();
                JQScript = jquery.GetEditOra(editHour,editMinutes,imgUP,imgDown,mask);
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
                    if (JQScript != null && JQScript.Length > 0)
                        InvokeScript(JQScript);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private string label = null;
        
        public string Label
        {
            get
            {
                label = UtilityWeb.GetText(editLabel);
                return label;
            }
            set
            {
                label = value;
                UtilityWeb.SetText(editLabel,label);
                UtilityWeb.SetSiteName(this,label);
            }
        }

        private int labelWidth = 108;
        
        public int LabelWidth
        {
            get
            {
                return labelWidth;
            }
            set
            {
                labelWidth = value;
                SetLabelWidth();
            }
        }

        private TimeSpan? _value = null;

        public TimeSpan? Value
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

        private object oldValue = null;
        private bool editing = false;
        
        public bool Editing
        {
            get
            {
                return editing;
            }
            set
            {
                editing = value;
                SetEditing(editing);
                SetReadOnly(!editing || readOnly);
                bool verified = IsVerified(required);
                SetVerified(verified);
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
                bool verified = IsVerified(required);
                SetVerified(verified);
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
                SetReadOnly(readOnly);
            }
        }

        private bool changed = false;
        
        public bool Changed
        {
            get
            {
                return changed;
            }
            set
            {
                changed = value;
                SetChanged(changed);
            }
        }

        private TimeSpan interval = new TimeSpan(00, 10, 00);
        
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

        public TemplateEditOra()
        {
            InitializeComponent();
        }

        private void TemplateEditOra_Load(object sender, EventArgs e)
        {
            try
            {
                SetEditing(editing);
                SetReadOnly(!editing || readOnly);
                bool verified = IsVerified(required);
                SetVerified(verified);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetValue(TimeSpan? value)
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    if (value != null)
                    {
                        TimeSpan time = (TimeSpan)value;
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

        private TimeSpan? GetValue()
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    TimeSpan? value = null;
                    int? hours = UtilityWeb.GetIntegerNothing(editHour, mask);
                    int? minutes = UtilityWeb.GetIntegerNothing(editMinutes, mask);
                    if(hours!=null && minutes!=null)
                        value = new TimeSpan((int)hours, (int)minutes, 0);                    
                    return value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public void SetEditing(bool editing)
        {
            try
            {
                if (editing)
                    oldValue = _value;
                UtilityWeb.SetImage(editing, changed, verified, imgEdit);
                UtilityWeb.SetBackColor(editHour, editing);
                UtilityWeb.SetBackColor(editMinutes, editing);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool IsVerified(bool required)
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    string hours = UtilityWeb.GetText(editHour, mask);
                    string minutes = UtilityWeb.GetText(editMinutes, mask);

                    bool compiled = (hours != null && hours.Length > 0) || (minutes != null && minutes.Length > 0);
                    bool isTime = UtilityValidation.IsTime(hours, minutes);
                    bool verified = (required && isTime) || (!required && (!compiled ||isTime));

                    return verified;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private bool IsChanged()
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    string hour = UtilityWeb.GetText(editHour, mask);
                    string minutes = UtilityWeb.GetText(editMinutes, mask);
                    string oldHour = "";
                    string oldMinutes = "";
                    if (oldValue != null)
                    {
                        oldHour = ((TimeSpan)oldValue).Hours.ToString("00");
                        oldMinutes = ((TimeSpan)oldValue).Minutes.ToString("00");
                    }
                    bool changed = (hour != oldHour) || (minutes!=oldMinutes);
                    return changed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private void SetVerified(bool verified)
        {
            try
            {
               UtilityWeb.SetImage(editing, changed, verified,imgEdit); 
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetChanged(bool changed)
        {
            try
            {
                if (imgEdit != null)
                {
                    UtilityWeb.SetImage(editing, changed, verified, imgEdit);                  
                }

            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void SetLabelWidth()
        {
            try
            {
                if (panelTime != null && imgEdit != null)
                {
                    editLabel.Width = labelWidth;
                    panelTime.Left = editLabel.Left + editLabel.Width;
                    panelTime.Width = this.Width - labelWidth - imgEdit.Width;
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void SetReadOnly(bool readOnly)
        {
            try
            {
                if (editHour != null && editMinutes != null)
                {
                    editHour.ReadOnly = readOnly;
                    editMinutes.ReadOnly = readOnly;
                    imgUP.Enabled = !readOnly;
                    imgDown.Enabled = !readOnly;
                    InitJQ();
                    ExecuteJQ();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }       

        private void editValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (editing)
                {
                    bool changed = IsChanged();
                    SetChanged(changed);
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void imgUP_Click(object sender, EventArgs e)
        {
            try
            {
                var minutes = UtilityWeb.GetInteger(editMinutes, mask);
                var hours = UtilityWeb.GetInteger(editHour, mask);
              
                TimeSpan time = new TimeSpan(hours, minutes, 00);
                time=time.Add(interval);

                editHour.Text = time.Hours.ToString("00");
                editMinutes.Text = time.Minutes.ToString("00");
                bool changed = IsChanged();
                SetChanged(changed);
                InitJQ();
                ExecuteJQ();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void imgDown_Click(object sender, EventArgs e)
        {
            try
            {
                var minutes = UtilityWeb.GetInteger(editMinutes, mask);
                var hours = UtilityWeb.GetInteger(editHour, mask); 

                TimeSpan time = new TimeSpan(10, hours, minutes, 0);
                time= time.Subtract(interval);                

                editHour.Text = time.Hours.ToString("00");
                editMinutes.Text = time.Minutes.ToString("00");
                bool changed = IsChanged();
                SetChanged(changed);
                InitJQ();
                ExecuteJQ();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        
    }
}