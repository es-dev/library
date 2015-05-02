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
    public partial class TextCountry : UserControl, IJQControl, IMaskControl
    {
        private string GetJQScript()
        {
            try
            {
                var jquery = new UtilityJQuery();
                var jqscript = jquery.GetCountries(editCity, editCounty, mask);
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

        public TextCountry()
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
                editCity.ReadOnly = readOnly;
                btnCombo.Visible = !readOnly;
                editCounty.ReadOnly = readOnly;
                toolTip.SetToolTip(editCity, readOnly ? null : "Scrivi le iniziali di un comune e premi il tasto INVIO per avviare la ricerca nell'archivio dati...");
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
                var readOnly = editCity.ReadOnly;
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
                editCity.BackColor = backColor;
                btnCombo.BackColor = backColor;
                editCounty.BackColor = backColor;
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
                var codeDescription = mask;
                var county = mask;
                if (text != null && text.Length > 0)
                {
                    var city = new Countries.City(text);
                    codeDescription = city.CodeDescription;
                    county = city.County;
                }
                editCity.Text = (codeDescription == null || codeDescription.Length == 0 ? mask : codeDescription);
                editCounty.Text = (county == null || county.Length == 0 ? mask : county);
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
                var city = (Countries.City)editCity.Tag;
                if(city!=null)
                {
                    var text = city.ToString();
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
                var value = (Countries.City)editCity.Tag;
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
                var city = (Countries.City)value;
                string text = null;
                if (city != null)
                    text = city.ToString();
                SetText(text);
                editCity.Tag = city;
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
                    var countries = new Countries(this);
                    countries.Confirm += Countries_Confirm;

                    UtilityWeb.AddJQControl(btnCombo, countries, JQTypePosition.Docked);
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

        public delegate void ConfirmlHanlder(Countries.City value);
        public event ConfirmlHanlder Confirm;

        void Countries_Confirm(Countries.City value)
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


        private void editCity_EnterKeyDown(object objSender, KeyEventArgs objArgs)
        {
            try
            {
                if (objArgs.KeyCode == Keys.Enter)
                {
                    var search = editCity.Text;
                    var countries = new Countries(this, search);
                    countries.Confirm += Countries_Confirm;

                    UtilityWeb.AddJQControl(editCity, countries, JQTypePosition.Docked);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}