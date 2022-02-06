using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models.UIModels
{
    public class MemberFamilyUIModel
    {
        public string membername { get; set; }
        public string relname { get; set; }
        public int memberfamilyid { get; set; }
        public int memberid { get; set; }
        public string relation { get; set; }
        public bool isapproved { get; set; }
    }
    public class MemberFamily
    {
        public int memberfamilyid { get; set; }

        public int memberid { get; set; }

        public string relname { get; set; }
        public DateTime reldob { get; set; }

        public string relgender { get; set; }

        public string relmobileno { get; set; }

        public string address { get; set; }

        public string address1 { get; set; }

        public string state { get; set; }


        public string country { get; set; }
        public bool isapproved { get; set; }

        public string bloodgroup { get; set; }

        public string relation { get; set; }

        public string emailid { get; set; }
    }
}
