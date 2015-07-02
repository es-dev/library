using Gizmox.WebGUI.Common.Resources;
using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityAsync
    {
        public static void Execute(Action action, Action callback=null, int interval = 1000, ResourceHandle icon=null, params Control[] controls)
        {
            try
            {
                var asyncExecute = new AsyncExecute(interval, icon, controls);
                asyncExecute.Start(action, callback);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private class AsyncExecute
        {
            private ErrorProvider errorProvider = null;
            private Control[] controls = null;

            Gizmox.WebGUI.Forms.Timer timer = null;
            public AsyncExecute(int interval, ResourceHandle icon=null, Control[] controls=null)
            {
                try
                {
                    this.controls = controls;
                    if(controls!=null)
                    {
                        errorProvider = new ErrorProvider();
                        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                        if(icon!=null)
                            errorProvider.Icon=icon;
                    }
                    timer = new Gizmox.WebGUI.Forms.Timer();
                    timer.Interval = interval;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }

            public void Start(Action action, Action callback=null)
            {
                try
                {
                    if (action != null)
                    {
                        if (controls != null)
                            Editing(true);
                        action.BeginInvoke(new AsyncCallback(Stop), callback);
                        timer.Start();
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }
           
            private void Stop(IAsyncResult ar)
            {
                try
                {
                    if (timer != null)
                    {
                        timer.Stop();
                        timer = null;
                    }
                    if (controls != null)
                        Editing(false);

                    if (ar != null)
                    {
                        var callback = (Action)ar.AsyncState;
                        if (callback != null)
                            callback.Invoke();
                    }
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }

            private void Editing(bool enable)
            {
                try
                {
                    if (controls != null)
                    {
                        foreach (var control in controls)
                            errorProvider.SetError(control, (enable?"Attendere, elaborazione in corso...":null));
                    }
                    if (!enable)
                        errorProvider = null;
                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                }
            }

        }

    }
}
