using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class Saludos : Mail
    {
        public Saludos(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_saludos-a-pacientes"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_saludos-a-pacientes_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}