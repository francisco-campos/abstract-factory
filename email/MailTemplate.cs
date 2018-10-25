using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SitefinityWebApp.lib.email
{
    public static class MailTemplate
    {
        private static string dominio = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority;

        public static string GetNewsletter(string linkValidation)
        {
            string templateHtml = System.AppDomain.CurrentDomain.BaseDirectory + "\\Templates\\email\\new_mail.htm";
            string pathEmail = dominio + "/Templates/email/";
            
            StreamReader objReader = new StreamReader(templateHtml);
            StringBuilder objBuilder = new StringBuilder(objReader.ReadToEnd());
            objReader.Close();
            objBuilder.Replace("{_link}", linkValidation);
            objBuilder.Replace("{msg_bajada}", "Para activar su cuenta, haga clic en el link que aparece a continuación:");
            objBuilder.Replace("{Dominio}", pathEmail);

            string msgBody = objBuilder.ToString();

            return msgBody;
        }

        public static string GetOpiniones(string message)
        {
            string templateHtml = System.AppDomain.CurrentDomain.BaseDirectory + "\\Templates\\email\\new_mail.htm";
            string pathEmail = dominio + "/Templates/email/";

            StreamReader objReader = new StreamReader(templateHtml);
            StringBuilder objBuilder = new StringBuilder(objReader.ReadToEnd());
            objReader.Close();
            objBuilder.Replace("{_link}", "");
            objBuilder.Replace("{msg_bajada}", message);
            objBuilder.Replace("{Dominio}", pathEmail);

            string msgBody = objBuilder.ToString();

            return msgBody;
        }

        public static string GetContacto(string name, string email, string subject, string message)
        {
            string templateHtml = System.AppDomain.CurrentDomain.BaseDirectory + "\\Templates\\email\\mail-contacto.html";
            string pathEmail = dominio + "/Templates/email/";

            StreamReader objReader = new StreamReader(templateHtml);
            StringBuilder objBuilder = new StringBuilder(objReader.ReadToEnd());
            objReader.Close();
            objBuilder.Replace("@nombre", name);
            objBuilder.Replace("@email", email);
            objBuilder.Replace("@asunto", subject);
            objBuilder.Replace("@mensaje", message);
            objBuilder.Replace("{Dominio}", pathEmail);

            string msgBody = objBuilder.ToString();

            return msgBody;
        }
    }
}