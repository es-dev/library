using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library.Code
{
    public class UtilityEmail
    {
        public static bool Send(string email, string subject, string body, IList<string> files=null)
        {
            try
            {
                if (email != null && email.Length > 0)
                {
                    string from = "support@es-dev.it";
                    string to = email;

                    var message = new MailMessage(from, to);
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = true;
                    if (files != null && files.Count>=1)
                    {
                        foreach (var file in files)
                        {
                            var attachment = new Attachment(file);
                            message.Attachments.Add(attachment);
                        }
                    }

                    var server = GetSMTPServer();
                    server.Send(message);
                    return true;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        private static SmtpClient GetSMTPServer()
        {
            try
            {
                string SMTPServer = "smtp.es-dev.it";
                string SMTPUser = "support@es-dev.it";
                string SMTPPassword = "Gaia230!";
                var server = new SmtpClient(SMTPServer);
                server.Credentials = new NetworkCredential(SMTPUser, SMTPPassword);
                server.Port = 25;
                return server;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
           
        }
    }
}
