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

#endregion

namespace Library.Controls
{
    [DefaultEvent("Click")]
    public partial class ButtonSeparatorH : UserControl
    {
        
        private string imageButton="";
        
        public string ImageButton
        {
            get 
            { 
                return imageButton; 
            }
            set
            {
                imageButton = value;
                btnControl.Image = (imageButton!=null? imageButton : "");
            }
        }

        private string imageSeparator = "Images.separator_vr.png";
        
        public string ImageSeparator
        {
            get 
            { 
                return imageSeparator; 
            }
            set
            {
                imageSeparator = value;
                imgSeparator.Image = (imageSeparator != null ? imageSeparator : "");
            }
        }

        private string textButton = null;
        public string TextButton
        {
            get 
            { 
                return textButton; 
            }
            set
            {
                textButton = value;
                btnControl.Text = textButton;
            }
        }

        private bool enabled = true;
        public override bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                btnControl.Enabled = enabled;
                btnControl.ForeColor = (enabled ? originalForeColor : Color.LightGray);
            }
        }

        public ButtonSeparatorH()
        {
            InitializeComponent();
            try
            {
                originalForeColor = btnControl.ForeColor;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private Color originalForeColor = Color.FromArgb(0, 45, 100);
        public Color OriginalForeColor
        {
            get
            {
                return originalForeColor;
            }
            set
            {
                originalForeColor = value;
            }
        }

        private Color foreColorButton = Color.FromArgb(0, 45, 100);
        public Color ForeColorButton
        {
            get
            {
                foreColorButton = btnControl.ForeColor;
                return foreColorButton;
            }
            set
            {
                foreColorButton = value;
                btnControl.ForeColor = foreColorButton;
            }
        }

        public delegate void ButtonSeparatorClick(object sender, EventArgs e);
        public new event ButtonSeparatorClick Click;

        private void btnControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (Click != null)
                    Click(sender, e);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}