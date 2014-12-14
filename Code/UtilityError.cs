using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityError
    {   
        public static void Write(Exception exc)
        {
            try
            {
                var pathErrorLog = GetPathErrorLog();
                if (!Directory.Exists(pathErrorLog))
                    Directory.CreateDirectory(pathErrorLog);
                string pathFileErrorLog = pathErrorLog + "\\" + DateTime.Today.ToString("ddMMyyyy") + ".txt";
                if (!File.Exists(pathFileErrorLog))
                {
                    Stream stream = File.Create(pathFileErrorLog);
                    stream.Close();
                }
                var urlSource = GetUrlSourceError();
                var helperLog = new HelperErrorLog(exc, pathFileErrorLog, urlSource);
                var thread = new Thread(new ThreadStart(helperLog.WriteErrorLog));
                thread.Start();
            }
            catch (Exception)
            {
            }
        }

        private class HelperErrorLog
        {
            public Exception exc = null;
            public string pathFileErrorLog = null;
            public string urlSource = null;

            public HelperErrorLog(Exception exc, string pathFileErrorLog, string urlSource)
	        {
                try
                {
                    this.exc = exc;
                    this.pathFileErrorLog = pathFileErrorLog;
                    this.urlSource = urlSource;
                }
                catch (Exception)
                {
                }
	        }

            public void WriteErrorLog()
            {
                try
                {
                    using (StreamWriter writer = File.AppendText(pathFileErrorLog))
                    {
                        writer.WriteLine("Log Entry: " + DateTime.Now.ToString("dd/MM/yyyy HH.mm.ss"));
                        writer.WriteLine("Error in: " + urlSource);
                        writer.WriteLine("Error Message: " + exc.Message);
                        writer.WriteLine("Stack Trace: " + exc.StackTrace);
                        writer.WriteLine("Error Source: " + exc.Source);
                        if (exc.InnerException != null)
                            writer.WriteLine("Inner Exception: " + exc.InnerException.Message);
                        writer.WriteLine("____________________________________________________________________________________________________");
                        writer.Flush();
                        writer.Close();
                    }
                }
                catch (Exception)
                {
                }
            }

        }

        private static string GetUrlSourceError()
        {
            try
            {
                var context = System.Web.HttpContext.Current;
                if (context != null && context.Request != null)
                {
                    var url = context.Request.Url.ToString();
                    return url;
                }
            }
            catch (Exception)
            {
            }
            return null;
        }
             
        private static string GetPathErrorLog()
        {
            try
            {
                var pathRoot = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
                var pathErrorLog = pathRoot + "ErrorLog";
                return pathErrorLog;
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
