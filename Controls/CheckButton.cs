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
        public CheckButton()
        {
            InitializeComponent();
        }
        
        private int trueWidth = 104;
        public int TrueWidth
        {
            get
            {
                return trueWidth;
            }
            set
            {
                trueWidth = value;
                SetTrueWidth(trueWidth);
            }
        }

        private void SetTrueWidth(int trueWidth)
        {
            try
            {
                int spread = 6;
                lblTrue.Width = trueWidth;
                imgFalse.Left = lblTrue.Left + lblTrue.Width;
                lblFalse.Left = imgFalse.Left + imgFalse.Width + spread;
                lblFalse.Width = this.Width - lblFalse.Left;
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
                imgTrue.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
                imgFalse.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
                lblTrue.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
                lblFalse.Cursor = (readOnly ? Cursors.Default : Cursors.Hand);
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
                var readOnly = !imgTrue.Enabled && !imgFalse.Enabled;
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
                imgTrue.BackColor = backColor;
                imgFalse.BackColor = backColor;
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
                textTrue = lblTrue.Text;
                return textTrue;
            }
            set
            {
                textTrue = value;
                lblTrue.Text = textTrue;
            }
        }

        private string textFalse = "NO";
        public string TextFalse
        {
            get
            {
                textFalse = lblFalse.Text;
                return textFalse;
            }
            set
            {
                textFalse = value;
                lblFalse.Text = textFalse;
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
                if (imgTrue != null && imgFalse != null)
                {
                    var trueValue = (bool?)imgTrue.Tag;
                    var falseValue = (bool?)imgFalse.Tag;
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
                    var value = (bool)_value;
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
        
   
       
        private void SetTrueFalse(bool trueValue, bool falseValue)
        {
            try
            {
                imgTrue.Image = (trueValue ? "Images.on.png" : "Images.off.png");
                imgTrue.Tag = trueValue;

                imgFalse.Image = (falseValue ? "Images.on.png" : "Images.off.png");
                imgFalse.Tag = falseValue;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void imgTrue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!readOnly)
                {
                    bool? value = (bool?)imgTrue.Tag;
                    if (value == true)
                        SetValue(null);
                    else
                        SetValue(true);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private void imgFalse_Click(object sender, EventArgs e)
        {
            try
            {
                if (!readOnly)
                {
                    var value = (bool?)imgFalse.Tag;
                    if (value == true)
                        SetValue(null);
                    else
                        SetValue(false);
                }
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