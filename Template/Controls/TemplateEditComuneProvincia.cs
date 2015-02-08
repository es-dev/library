#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Controls;
using Library.Code;

using Library.Interfaces;
#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditComuneProvincia : EditControl
    {
        public TemplateEditComuneProvincia()
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

        private ComuniProvince.Comune _value = null;
        public new ComuniProvince.Comune Value
        {
            get
            {
                _value = GetValue();
                return _value;
            }
            set
            {
                _value = value;
                SetValue();
            }
        }

        private void SetValue()
        {
            try
            {
                editControl.Value = _value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private ComuniProvince.Comune GetValue()
        {
            try
            {
                var _value = (ComuniProvince.Comune)editControl.Value;
                return _value;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public delegate void ConfirmHanlder(ComuniProvince.Comune value);
        public event ConfirmHanlder Confirm;

        private void editControl_Confirm(ComuniProvince.Comune value)
        {
            try
            {
                if (Confirm != null)
                    Confirm(value);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
    }
}