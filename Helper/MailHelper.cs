using Microsoft.AspNetCore.Http;
using ParishApi.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ParishApi.Helper
{
    public class MailHelper
    {
        public static void SentMail(MailModel mailDetails)
        {
            AlternateView HTMLEmail = AlternateView.CreateAlternateViewFromString(mailDetails.body, Encoding.UTF8, "text/html");
            //LinkedResource imageResource = new LinkedResource(HttpContext.Current.Server.MapPath("~/SMIOC/images/Church.jpg"));
            //imageResource.ContentId = "HDIImage";
            HTMLEmail.TransferEncoding = TransferEncoding.QuotedPrintable;
            //HTMLEmail.LinkedResources.Add(imageResource);

            var mail = new MailMessage
            {
                From = new MailAddress(mailDetails.fromAddress, mailDetails.displayName),
                Subject = mailDetails.mailSubject,
                // Body = mailDetails.body,
                IsBodyHtml = mailDetails.IsHtmlBody,
            };
            mail.AlternateViews.Add(HTMLEmail);
            if (mailDetails.toAddress != null)
            {
                mail.To.Add(mailDetails.toAddress);
            }
            else
            {
                mailDetails.toAddress = "syampsatheesan@gmail.com";
                mail.To.Add(mailDetails.toAddress);
            }
            mail.To.Add(mailDetails.toAddress);
            if (mailDetails.toAddress1 != null)
            {
                mail.To.Add(mailDetails.toAddress1);
            }

            if (mailDetails.ccAddresss != null)
            {
                mail.CC.Add(mailDetails.ccAddresss);
            }


            try
            {
                using (var client = new SmtpClient())
                {
                    client.Send(mail);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
