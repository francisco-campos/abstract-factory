using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class Mailing
    {
        SimpleMailFactory factory;

        public Mailing(SimpleMailFactory factory)
        {
            this.factory = factory;
        }

        public Mail sendMail(MailType type, string subject, string body, string listEmails)
        {
            Mail mail;
            mail = factory.createMail(type, subject, body, listEmails);
            mail.SendEmail();

            return mail;
        }
    }
}