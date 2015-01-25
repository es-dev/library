using Gizmox.WebGUI.Forms;
using Library.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityMessage
    {
        public static void Show(Control owner, string title, string description, TypeMessage typeMessage, Action confirm = null)
        {
            try
            {
                var message= new Message(owner);
                message.Confirm += () => 
                {
                    OnMessageConfirm(confirm);  
                };
                message.Show(title, description, typeMessage);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static void OnMessageConfirm(Action confirm)
        {
            try
            {
                if (confirm != null)
                    confirm.Invoke();      
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


    }
}
