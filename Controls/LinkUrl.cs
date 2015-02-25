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
    public partial class LinkUrl : UserControl, IJQControl, IMaskControl
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
                var jqscript = jquery.GetMask(editLink, mask);
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

        public LinkUrl()
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
                editLink.Enabled = !readOnly;
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
                var readOnly = !editLink.Enabled;
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
                editLink.BackColor=backColor;
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
                editLink.Text = (text == null || text.Length == 0 ? mask : text);
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
                var text = editLink.Text.Replace(mask, null);
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

        private Library.Code.Enum.TypeReport typeReport = Library.Code.Enum.TypeReport.None;
        public Library.Code.Enum.TypeReport TypeReport
        {
            get
            {
                return typeReport;
            }
            set
            {
                typeReport = value;
                SetTypeReport(typeReport);
            }
        }

        private string url = null;
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                SetUrl(url);
            }
        }

        private void SetUrl(string url)
        {
            try
            {
                if (url != null && url.Length > 0)
                    editLink.RegisterClientAction("open", url);
                else
                    editLink.UnregisterClientAction();

                typeReport = GetTypeReport(url);
                SetTypeReport(typeReport);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private Code.Enum.TypeReport GetTypeReport(string url)
        {
            try
            {
                if (url.ToUpper().EndsWith(".DOC"))
                    return Code.Enum.TypeReport.DOC;
                else if (url.ToUpper().EndsWith(".XLS"))
                    return Code.Enum.TypeReport.XLS;
                else if (url.ToUpper().EndsWith(".PDF"))
                    return Code.Enum.TypeReport.PDF;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Code.Enum.TypeReport.None;
        }

        private void SetTypeReport(Library.Code.Enum.TypeReport typeReport)
        {
            try
            {
                if (typeReport == Library.Code.Enum.TypeReport.None)
                {
                    imgReport.Image = "";
                }
                else if (typeReport == TypeReport.DOC)
                {
                    imgReport.Image = "Images.doc.png";
                }
                else if (typeReport == TypeReport.XLS)
                {
                    imgReport.Image = "Images.xls.png";
                }
                else if (typeReport == TypeReport.PDF)
                {
                    imgReport.Image = "Images.pdf.png";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }



      
    }
}