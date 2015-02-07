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
using Library.Controls;
using Library.Code.Enum;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditStato : EditControl
    {

        public TemplateEditStato()
        {
            InitializeComponent();
            try
            {
                base.MaskControl = editControl;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private string _value = null; 
        public new string Value
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
        
        private void SetValue(string value)
        {
            try
            {
                if (value != null && value.Length > 0)
                {
                    statoDescrizione = new StatoDescrizione(value);
                    editControl.Value = statoDescrizione.Descrizione;
                    editControl.Stato = statoDescrizione.Stato;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetValue()
        {
            try
            {
                string descrizione = (string)editControl.Value;
                var stato = editControl.Stato;
                statoDescrizione = new StatoDescrizione(stato, descrizione);
                var value = statoDescrizione.ToString();
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private StatoDescrizione statoDescrizione = null;
        public StatoDescrizione StatoDescrizione
        {
            get
            {
                return statoDescrizione;
            }
            set
            {
                statoDescrizione = value;
                _value = statoDescrizione.ToString();
            }
        }

        


    }
}