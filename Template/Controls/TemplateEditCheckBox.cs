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
    public partial class TemplateEditCheckBox : UserControl,IEditControl
    {
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

        private string textTrue = null;
        
        public string TextTrue
        {
            get
            {
                textTrue =UtilityWeb.GetText( editTrue);
                return textTrue;
            }
            set
            {
                textTrue = value;
                UtilityWeb.SetText(editTrue,textTrue);
            }
        }

        private string textFalse =null;
        
        public string TextFalse
        {
            get
            {
                textFalse =UtilityWeb.GetText(editFalse);
                return textFalse;
            }
            set
            {
                textFalse = value;
                UtilityWeb.SetText(editFalse,textFalse);
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
               // SetReadOnly(readOnly);
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

        public TemplateEditCheckBox()
        {
            InitializeComponent();
        }

        private void TemplateEditCheckBox_Load(object sender, EventArgs e)
        {
            try
            {
                SetEditing(editing);
                //SetReadOnly(!editing || readOnly);
                bool verified = IsVerified(required);
                SetVerified(verified);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private bool? GetValue()
        {
            try
            {
                bool? value = null;
                if(editTrue!=null && editFalse!=null)
                {
                    bool? trueValue=(bool?)editTrue.Tag;
                    bool? falseValue=(bool?)editFalse.Tag;
                    if(trueValue!=null && falseValue!=null)
                    {
                        if (trueValue == true && falseValue == false)
                            value = true;
                        else if (trueValue == false && falseValue == true)
                            value = false;
                    }
                }
                return value;
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
                    bool enable = (bool)value;
                    SetTrueFalse(enable, !enable);
                }
                else
                    SetTrueFalse(false, false);
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void SetTrueFalse(bool trueValue, bool falseValue)
        {
            try
            {
                editTrue.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
                editTrue.BorderWidth = 0;
                editTrue.BorderColor = Color.Transparent;
                editTrue.BackColor = (trueValue ? Color.FromArgb(0, 45, 100) : Color.White);
                editTrue.ForeColor = (trueValue ? Color.White : Color.Black);
                editTrue.Image = (trueValue ? "Images.on.png" : "Images.off.png");

                editFalse.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
                editFalse.BorderWidth = 0;
                editFalse.BorderColor = Color.Transparent;
                editFalse.BackColor = (falseValue ? Color.FromArgb(0, 45, 100) : Color.White);
                editFalse.ForeColor = (falseValue ? Color.White : Color.Black);
                editFalse.Image = (falseValue ? "Images.on.png" : "Images.off.png");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void SetEditing(bool editing)
        {
            try
            {
                if (editing)
                    oldValue = _value;
                UtilityWeb.SetImage(editing, changed, verified, imgEdit);
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
                if (editTrue != null && editFalse != null)
                {
                    bool? value = GetValue();
                    bool compiled = (value != null);
                    bool verified = (required && compiled) || (!required && (!compiled || compiled));
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
                if (editTrue != null && editFalse!=null)
                {
                    bool? value = GetValue();
                    bool changed = (value != (bool?)oldValue);
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
                    UtilityWeb.SetImage(editing, changed, verified, imgEdit);                  

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
                if (panelCheck != null && editLabel != null)
                {
                    editLabel.Width = labelWidth;
                    panelCheck.Left = editLabel.Left + editLabel.Width;
                    panelCheck.Width = this.Width - labelWidth - imgEdit.Width;
                }
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }

        private void editTrue_Click(object sender, EventArgs e)
        {
            try
            {
                if (editing && !readOnly)
                {
                    editTrue.Tag = true;
                    editFalse.Tag = false;
                    SetValue(true);
                    bool changed = IsChanged();
                    SetChanged(changed);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFalse_Click(object sender, EventArgs e)
        {
            try
            {
                if (editing && !readOnly)
                {
                    editTrue.Tag = false;
                    editFalse.Tag = true;
                    SetValue(false);
                    bool changed = IsChanged();
                    SetChanged(changed);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }      
    }
}