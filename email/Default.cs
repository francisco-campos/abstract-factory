using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class Default : Mail
    {
        public Default(string subject, string body, string emails)
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_default"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_default_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;
        }
    }
}