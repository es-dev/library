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
        private string JQScript = null;
		public JQContainer()
		{
			InitializeComponent();
		}

        protected override void Render(IContext objContext, IResponseWriter objWriter, long lngRequestID)
        {
            try
            {
                base.Render(objContext, objWriter, lngRequestID);
                InitJQ();
                ExecuteJQ();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void InitJQ()
        {
            try
            {
                var jquery = new UtilityJQuery();
                JQScript = jquery.GetOpacity(this, JQBackColor, JQOpacity);
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
                    if (JQScript != null && JQScript.Length > 0)
                        InvokeScript(JQScript);
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
