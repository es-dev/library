using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common.Interfaces;
using Library.Interfaces;
using Library.Code;

namespace Library.Controls
{
	public partial class JQContainer : Panel, IJQControl
	{
        private string GetJQScript()
        {
            try
            {
                var jquery = new UtilityJQuery();
                var jqscript = jquery.GetOpacity(this, jqBackColor, jqOpacity);
                return jqscript;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        
        public JQContainer()
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

        private Color jqBackColor = Color.DimGray;
        public Color JQBackColor
        {
            get
            {
                return jqBackColor;
            }
            set
            {
                jqBackColor = value;
            }
        }

        private double jqOpacity = 0.5;
        public double JQOpacity
        {
            get 
            { 
                return jqOpacity; 
            }
            set 
            { 
                jqOpacity = value; 
            }
        }
	}
}
