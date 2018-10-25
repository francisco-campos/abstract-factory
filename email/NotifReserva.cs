using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class NotifReserva : Mail
    {
        public NotifReserva(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_notif-de-reserva"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_notif-de-reserva_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}