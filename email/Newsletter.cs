using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class Newsletter : Mail
    {        
        public Newsletter(string subject, string body, string emails) 
        {
            this.MailOrigin = ConfigurationManager.AppSettings["mailorigin_newsletter"];
            this.MailOriginPass = ConfigurationManager.AppSettings["mailorigin_newsletter_pass"];
            this.Subject = subject;
            this.Body = body;
            this.Mails = emails;            
        }   
    }
}