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
    public partial class TextStato : UserControl, IJQControl, IMaskControl
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
                var jqscript = jquery.GetMask(editText, mask);
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

        public TextStato()
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
                editText.Text = (text == null || text.Length == 0 ? mask : text);
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
                var text = editText.Text.Replace(mask,null);
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
                var value = GetText();
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
                var text = (string)value;
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
                return mask;
            }
            set
            {
                mask = value;
            }
        }

        private TypeStato stato = TypeStato.None;
        public TypeStato Stato
        {
            get
            {
                return stato;
            }
            set
            {
                stato = value;
                SetStato(stato);
            }
        }

        private void SetStato(TypeStato stato)
        {
            try
            {
                editText.ForeColor = Color.Black;
                if (stato == TypeStato.None)
                {
                    imgStato.Image = "";
                }
                else if (stato == TypeStato.Normal)
                {
                    imgStato.Image = "Images.messageConfirm.png";
                    editText.ForeColor = Color.Blue;
                }
                else if (stato == TypeStato.Warning)
                {
                    imgStato.Image = "Images.messageQuestion.png";
                    editText.ForeColor = Color.OrangeRed;
                }
                else if (stato == TypeStato.Critical)
                {
                    imgStato.Image = "Images.messageAlert.png";
                    editText.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }



      
    }
}