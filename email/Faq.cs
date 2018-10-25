using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class Faq : Mail
    {
        public Faq(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_preguntas-frecuentes"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_preguntas-frecuentes_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}