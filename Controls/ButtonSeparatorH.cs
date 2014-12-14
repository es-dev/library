#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

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
            }
        }

        public ButtonSeparatorH()
        {
            InitializeComponent();
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
                Library.Code.UtilityError.Write(ex);
            }
        }

    }
}