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

        private string _value = null; //formato della variabile di stato --> Stato | Descrizione
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
                    var splits = value.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length >= 2)
                    {
                        string _stato = splits[0].Trim();
                        string descrizione = splits[1].Trim();
                        var stato = (TypeStato)Enum.Parse(typeof(TypeStato), _stato);
                        editControl.Value = descrizione;
                        editControl.Stato = stato;
                    }
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
                string value = stato.ToString() + " | " + descrizione;
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }
}