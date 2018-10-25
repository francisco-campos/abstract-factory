using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public abstract class Mail
    {
        private string serverSmtp, domain, status;

        public string Status
        {
            get { return status; }
        }

        public string ServerSmtp
        {
            get { return serverSmtp; }
        }

        public string Domain
        {
            get { return domain; }
        }

        protected string Subject, Body, Mails, MailOrigin, MailOriginPass;

        //Constructor
        public Mail() {
            this.serverSmtp = ConfigurationManager.AppSettings["serverSmtp"];
            this.domain = ConfigurationManager.AppSettings["serverSmtpDomain"];
            this.status = "sin-enviar";
        }

        public string GetMailOrigin()
        {
            return this.MailOrigin;
        }

        public string GetSubject()
        {
            return this.Subject;
        }

        public void SendEmail()
        {
            try
            {
                var msg = new MailMessage();
                msg.From = new MailAddress(this.MailOrigin);
                msg.BodyEncoding = System.Text.UTF8Encoding.UTF8;
                msg.HeadersEncoding = System.Text.UTF8Encoding.UTF8;
                msg.SubjectEncoding = System.Text.UTF8Encoding.UTF8;
                msg.Priority = MailPriority.High;
                msg.IsBodyHtml = true;

                var arrMails = this.Mails.Split(',');
                foreach (var mail in arrMails)
                {
                    msg.To.Add(mail);
                }

                //msg.Bcc.Add("francisco.campos@fusiona.cl"); //copia oculta
                msg.Subject = this.Subject;
                msg.Body = this.Body;

                var smtp = new SmtpClient(this.serverSmtp, Convert.ToInt32(this.domain));
                smtp.Credentials = new System.Net.NetworkCredential(this.MailOrigin, this.MailOriginPass);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(msg);
                this.status = "enviado";
            }
            catch (Exception e)
            {
                Utilities.Logs.GenericLog.Save(e.Message.ToString(), "method SendEmail", e.StackTrace.ToString());
                this.status = "error";
            }
        }
    }
}