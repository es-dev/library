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
using Gizmox.WebGUI.Common.Interfaces;
using Library.Code.Enum;

#endregion

namespace Library.Controls
{
    public partial class TextProgress : UserControl, IJQControl, IMaskControl
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
                string jqscript = null;
                var mask = GetMask();
                var jquery = new UtilityJQuery();
                jqscript = jquery.GetDecimal(editText, mask);
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

        public TextProgress()
        {
            InitializeComponent();
           
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
                editText.ReadOnly = readOnly;
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
                var readOnly = editText.ReadOnly;
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
                editText.BackColor=backColor;
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
                var mask = GetMask();
                editText.Text=(text==null || text.Length==0? mask: text);
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
                var mask = GetMask();
                var text = editText.Text.Replace(mask, null);
                if (text != null && text.Length == 0)
                    text = null;
                return text;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                object value = null;
                var text = GetText();
                if (text != null)
                {
                    value = UtilityValidation.GetPercent(text);
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
                string text = null;
                if (value != null)
                {
                    text = UtilityValidation.GetPercent((decimal?)value);
                }
                SetText(text);
                SetProgress((decimal?)value);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetProgress(decimal? value)
        {
            try
            {
                if(value!=null)
                {
                    var progress = (int)value;
                    if (progress > 100)
                        progress = 100;
                    if (progress < 0)
                        progress = 0;
                    editProgressBar.Value = progress;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string mask = "---";
        public string Mask
        {
            get
            {
                mask = GetMask();
                return mask;
            }
            set
            {
                mask = value;
            }
        }

        private string GetMask()
        {
            try
            {
                var mask = "---";
                return mask;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}