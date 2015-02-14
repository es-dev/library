using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityAsync
    {

        public static void Execute(Action action, int interval = 250)
        {
            try
            {
                var asyncExecute = new AsyncExecute(interval);
                asyncExecute.Start(action);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

        private class AsyncExecute
        {
            Gizmox.WebGUI.Forms.Timer timer = null;
            public AsyncExecute(int interval)
            {
                try
                {
                    timer = new Gizmox.WebGUI.Forms.Timer();
                    timer.Interval = interval;
                    timer.Start();

                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }

            public void Start(Action action)
            {
                try
                {
                    var callback = new AsyncCallback(Callback);
                    action.BeginInvoke(callback, null);

                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }

            private void Callback(IAsyncResult ar)
            {
                try
                {
                    timer.Stop();
                    timer = null;

                }
                catch (Exception ex)
                {
                    UtilityError.Write(ex);
                } 
            }

        }

    }
}
