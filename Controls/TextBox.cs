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

#endregion

namespace Library.Controls
{
    public partial class TextBox : UserControl, IJQControl, IMaskControl
    {
        private TypeBehavior behavior = TypeBehavior.Text;
        public TypeBehavior Behavior
        {
            get
            {
                return behavior;
            }
            set
            {
                behavior = value;
                SetBehavior(behavior);
            }
        }

        private void SetBehavior(TypeBehavior behavior)
        {
            try
            {
                if (behavior == TypeBehavior.Password)
                {
                    editText.UseSystemPasswordChar = true;
                    editText.PasswordChar = char.Parse("*");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetJQScript()
        {
            try
            {
                string jqscript = null;
                var mask = GetMask();
                var jquery = new UtilityJQuery();
                if (behavior == TypeBehavior.Numeric)
                    jqscript = jquery.GetNumeric(editText, mask);
                else if (behavior == TypeBehavior.Decimal || behavior == TypeBehavior.Percent)
                    jqscript = jquery.GetDecimal(editText, mask);
                else if (behavior == TypeBehavior.PartitaIva)
                    jqscript = jquery.GetPartitaIva(editText, mask);
                else if (behavior == TypeBehavior.CodiceFiscale)
                    jqscript = jquery.GetCodiceFiscale(editText, mask);
                else if (behavior == TypeBehavior.Cap)
                    jqscript = jquery.GetCap(editText, mask);
                else
                    jqscript = jquery.GetMask(editText, mask);
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

        public TextBox()
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
                    if (behavior == TypeBehavior.Numeric)
                        value = int.Parse(text);
                    else if (behavior == TypeBehavior.Decimal)
                        value = UtilityValidation.GetEuro(text);
                    else if (behavior == TypeBehavior.Percent)
                        value = UtilityValidation.GetPercent(text);
                    else
                        value = text;
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
                    if (behavior == TypeBehavior.Numeric)
                        text = ((int)value).ToString("0");
                    else if (behavior == TypeBehavior.Decimal)
                        text = UtilityValidation.GetEuro((decimal?)value);
                    else if (behavior == TypeBehavior.Percent)
                        text = UtilityValidation.GetPercent((decimal?)value);
                    else
                        text = (string)value;
                }
                SetText(text);
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
                if (behavior == TypeBehavior.Password)
                    mask = "------";
                else if (behavior == TypeBehavior.CodiceFiscale)
                    mask = "-----------";
                else if (behavior == TypeBehavior.PartitaIva)
                    mask = "-----------";
                else if (behavior == TypeBehavior.Cap)
                    mask = "-----";
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