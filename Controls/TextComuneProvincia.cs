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
    public partial class TextComuneProvincia : UserControl, IJQControl, IMaskControl
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
                var jqscript = jquery.GetComuneProvincia(editComune, editProvincia, mask);
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

        public TextComuneProvincia()
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
                editComune.ReadOnly = readOnly;
                btnCombo.Visible = !readOnly;
                editProvincia.ReadOnly = readOnly;
                toolTip.SetToolTip(editComune, readOnly ? null : "Scrivi le iniziali di un comune e batti il tasto INVIO per avviare la ricerca nell'archivio dati...");
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
                var readOnly = editComune.ReadOnly;
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
                editComune.BackColor = backColor;
                btnCombo.BackColor = backColor;
                editProvincia.BackColor = backColor;
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
                var denominazioneCodiceCatastale = mask;
                var provincia = mask;
                if (text != null && text.Length > 0)
                {
                    var comune = new ComuniProvince.Comune(text);
                    denominazioneCodiceCatastale = comune.DenominazioneCodiceCatastale;
                    provincia = comune.Provincia;
                }
                editComune.Text = (denominazioneCodiceCatastale == null || denominazioneCodiceCatastale.Length == 0 ? mask : denominazioneCodiceCatastale);
                editProvincia.Text = (provincia == null || provincia.Length == 0 ? mask : provincia);
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
                var comune = (ComuniProvince.Comune)editComune.Tag;
                if(comune!=null)
                {
                    var text = comune.ToString();
                    return text;
                }
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
                var value = (ComuniProvince.Comune)editComune.Tag;
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
                var comune = (ComuniProvince.Comune)value;
                string text = null;
                if (comune != null)
                    text = comune.ToString();
                SetText(text);
                editComune.Tag = comune;
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

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var comuniProvince = new ComuniProvince(this);
                    comuniProvince.Confirm += ComuniProvince_Confirm;

                    UtilityWeb.AddJQControl(btnCombo, comuniProvince, JQTypePosition.Docked);
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public delegate void ConfirmlHanlder(ComuniProvince.Comune value);
        public event ConfirmlHanlder Confirm;

        void ComuniProvince_Confirm(ComuniProvince.Comune value)
        {
            try
            {
                if (value != null)
                {
                    SetValue(value);
                    if (Confirm != null)
                        Confirm(value);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void editComune_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            try
            {
                if (objArgs.KeyCode == Keys.Enter)
                {
                    var search = editComune.Text;
                    var comuniProvince = new ComuniProvince(this, search);
                    comuniProvince.Confirm += ComuniProvince_Confirm;

                    UtilityWeb.AddJQControl(btnCombo, comuniProvince, JQTypePosition.Docked);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}