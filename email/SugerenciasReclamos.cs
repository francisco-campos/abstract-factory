using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class SugerenciasReclamos : Mail
    {
        public SugerenciasReclamos(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_sugerencias-y-reclamos"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_sugerencias-y-reclamos_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}