#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Library.Interfaces;
using Library.Code;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Controls;
using System.Collections;


#endregion

namespace Library.Template.Controls
{
    public partial class TemplateEditDropDown : EditControl
    {

        public TemplateEditDropDown()
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

        private void SetValue(string _value)
        {
            try
            {
                var value = _value;
                if (displayValues != null && displayValues.Count >= 1)
                    value = (from q in displayValues where q.Value == _value select new DisplayValue { Value = q.Value, Display = q.Display }.ToString()).FirstOrDefault();
                
                editControl.Value = value;
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
                var  value = (string)editControl.Value;
                if (displayValues != null && displayValues.Count >= 1)
                    value = (from q in displayValues where new DisplayValue { Value = q.Value, Display = q.Display }.ToString() == value select q.Value).FirstOrDefault();
                return value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IList<string> items = null;
        public IList<string> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                SetItems(items);
            }
        }

        private void SetItems(IList<string> items)
        {
            try
            {
                editControl.Items = items;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<DisplayValue> displayValues = null;
        public IList<DisplayValue> DisplayValues
        {
            get
            {
                return displayValues;
            }
            set
            {
                displayValues = value;
                SetDisplayValues(displayValues);
            }
        }

        private void SetDisplayValues(IList<DisplayValue> displayValues)
        {
            try
            {
                var _displayValues = (from q in displayValues select new DisplayValue { Value = q.Value, Display = q.Display }.ToString()).ToList();
                editControl.Items = _displayValues;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public class DisplayValue 
        {
            private string _value = null;
            public string Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }

            private string display = null;
            public string Display
            {
                get
                {
                    return display;
                }
                set
                {
                    display = value;
                }
            }

            public DisplayValue()
            {

            }

            public override string ToString()
            {
                try
                {
                    var displayValue = Value + " - " + display;
                    return displayValue;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
                return null;
            }
        }
    }
}