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
    public partial class CheckButton : UserControl, IMaskControl
    {
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
                editTrue.Enabled = !readOnly;
                editFalse.Enabled = !readOnly;
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
                var readOnly = !editTrue.Enabled && !editFalse.Enabled;
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
                editTrue.BackColor = backColor;
                editFalse.BackColor = backColor;
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
                bool trueValue = (text == "true");
                bool falseValue = (text == "false");
                SetTrueFalse(trueValue, falseValue);
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
                var _checked = GetValue();
                if(_checked!=null)
                {
                    var value = (bool)_checked;
                    var text = (value ? "true" : "false");
                    return text;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string textTrue = "SI";
        public string TextTrue
        {
            get
            {
                textTrue = editTrue.Text;
                return textTrue;
            }
            set
            {
                textTrue = value;
                editTrue.Text = textTrue;
            }
        }

        private string textFalse = "NO";
        public string TextFalse
        {
            get
            {
                textFalse = editFalse.Text;
                return textFalse;
            }
            set
            {
                textFalse = value;
                editFalse.Text = textFalse;
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
                _value = (bool?)value;
                SetValue(_value);
            }
        }

        private object GetValue()
        {
            try
            {
                bool? _value = null;
                if (editTrue != null && editFalse != null)
                {
                    bool? trueValue = (bool?)editTrue.Tag;
                    bool? falseValue = (bool?)editFalse.Tag;
                    if (trueValue != null && falseValue != null)
                    {
                        if (trueValue == true && falseValue == false)
                            _value = true;
                        else if (trueValue == false && falseValue == true)
                            _value = false;
                    }
                }
                return _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void SetValue(object _value)
        {
            try
            {
                if (_value != null)
                {
                    bool value = (bool)_value;
                    SetTrueFalse(value, !value);
                }
                else
                    SetTrueFalse(false, false);
            }
            catch (Exception ex)
            {
                Library.Code.UtilityError.Write(ex);
            }
        }
        
        public CheckButton()
        {
            InitializeComponent();
        }

        private void CheckButton_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                int width = this.Width;
                editTrue.Left = 0;
                editTrue.Width = width / 2;
                editFalse.Left = editTrue.Left + editTrue.Width;
                editFalse.Width = editTrue.Width;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
        
        private void SetTrueFalse(bool trueValue, bool falseValue)
        {
            try
            {
                editTrue.Image = (trueValue ? "Images.on.png" : "Images.off.png");
                editTrue.Tag = trueValue;

                editFalse.Image = (falseValue ? "Images.on.png" : "Images.off.png");
                editFalse.Tag = falseValue;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editTrue_Click(object sender, EventArgs e)
        {
            try
            {
                bool? value = (bool?)editTrue.Tag;
                if (value == true)
                    SetValue(null);
                else
                    SetValue(true);
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
                bool? value = (bool?)editFalse.Tag;
                if (value == true)
                    SetValue(null);
                else
                    SetValue(false);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 

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
    }
}