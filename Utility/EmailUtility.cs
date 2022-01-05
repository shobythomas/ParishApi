using ParishApi.Helper;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Utility
{
    public class EmailUtility
    {
        public static void SendEmail(MailModel newMail)
        {
            MailHelper.SentMail(newMail);
        }
        public static MailModel PrepareRegistrationPassword(MemberRegistrationPasswordModel model)
        {
            //var smtpDetails = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
            //var message = new RegistrationPasswordEmailTemplate(model).TransformText();
            //var subject = "Password for Login";
            //var newMail = EmailCreation(message, model.Name, subject, smtpDetails.From, model.EmailID);
            return null;
        }
    }
}
