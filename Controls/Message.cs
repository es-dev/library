using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Library.Controls;
using Gizmox.WebGUI.Forms;
using Library.Code;

namespace Library.Controls
{
    public partial class Message : PopupBase
    {
        public Message() : base()
        {
            InitializeComponent();
        }

        public Message(Control owner) : base(owner, TypeDirection.Horizontal)
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void MessageControl_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public void Show(string title,string description,TypeMessage typeMessage)
        {
            try
            {
                lblTitle.Text = title;
                lblDescription.Text = description;
                SetTypeMesasge(typeMessage);
                base.Show();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetTypeMesasge(TypeMessage typeMessage)
        {
            try
            {
                if (typeMessage == TypeMessage.Info)
                {
                    imgIcon.BackgroundImage = "Images.messageInfo.png";
                    btnCancel.Visible = false;
                    btnConfirm.Visible = true;
                    btnConfirm.TextButton = "Chiudi";
                }
                else if (typeMessage == TypeMessage.Alert)
                {
                    imgIcon.BackgroundImage = "Images.messageAlert.png";
                    btnCancel.Visible = false;
                    btnConfirm.Visible = true;
                    btnConfirm.TextButton = "Chiudi";
                }
                else if (typeMessage == TypeMessage.Question)
                {
                    imgIcon.BackgroundImage = "Images.messageQuestion.png";
                    btnCancel.Visible = true;
                    btnConfirm.Visible = true;
                    btnConfirm.TextButton = "Continua";
                }
                btnCancel.TextButton = "Annulla";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }       
    }

    public enum TypeMessage
    {
        Info,
        Question,
        Alert
    }
}
