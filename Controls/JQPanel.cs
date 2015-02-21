#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Code;
using Library.Interfaces;

#endregion

namespace Library.Controls
{
    public partial class JQPanel : UserControl, IJQControl
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
                var jqscript = jquery.GetMouseOverColor(this.jqContainer, JQEnterBackColor, BackColor, JQDownBackColor, JQEnterBorderColor, BorderColor);
                return jqscript;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public JQPanel()
		{
			InitializeComponent();
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
                if (!DesignMode && Enabled)
                {
                    if (JQScript != null && JQScript.Length > 0)
                        InvokeScript(JQScript);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private Color jqEnterBackColor = Color.LightSteelBlue;
        public Color JQEnterBackColor
        {
            get
            {
                return jqEnterBackColor;
            }
            set
            {
                jqEnterBackColor = value;
            }
        }

        private Color jqDownBackColor = Color.LightBlue;
        public Color JQDownBackColor
        {
            get
            {
                return jqDownBackColor;
            }
            set
            {
                jqDownBackColor = value;
            }
        }

        private Color jqEnterBorderColor = Color.DimGray;
        public Color JQEnterBorderColor
        {
            get
            {
                return jqEnterBorderColor;
            }
            set
            {
                jqEnterBorderColor = value;
            }
        }

        public Panel JQContainer
        {
            get
            {
                return jqContainer;
            }
        }
    }
}