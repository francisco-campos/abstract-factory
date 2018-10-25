using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public class SimpleMailFactory
    {
        public SimpleMailFactory() { }

        public Mail createMail(MailType type, string subject, string body, string emails)
        {
            Mail mail = null;
            switch (type)
            {
                case MailType.Default:
                    mail = new Default(subject, body, emails);
                    break;

                case MailType.Newsletter:
                    mail = new Newsletter(subject, body, emails);
                    break;

                case MailType.Sugerencias:
                    mail = new SugerenciasReclamos(subject, body, emails);
                    break;

                case MailType.AppDeBebes:
                    mail = new AppBebes(subject, body, emails);
                    break;

                case MailType.PreguntasFrecuentes:
                    mail = new Faq(subject, body, emails);
                    break;

                case MailType.SaludosPaciente:
                    mail = new Saludos(subject, body, emails);
                    break;

                case MailType.NotifDeReserva:
                    mail = new NotifReserva(subject, body, emails);
                    break;
            }

            return mail;
        }
    }
}