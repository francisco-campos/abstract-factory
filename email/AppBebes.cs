using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class AppBebes : Mail
    {
        public AppBebes(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_aplicacion-de-bebes"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_aplicacion-de-bebes_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}