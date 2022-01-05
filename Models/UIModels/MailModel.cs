using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models.UIModels
{
    public class MailModel
    {
        public string fromAddress { get; set; }
        public string toAddress { get; set; }
        public string toAddress1 { get; set; }
        public string ccAddresss { get; set; }
        public string displayName { get; set; }
        public string mailSubject { get; set; }

        public string body { get; set; }
        public string headerText { get; set; }
        public string footerText { get; set; }
        public bool IsHtmlBody { get; set; }
    }
}
