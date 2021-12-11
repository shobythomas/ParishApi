using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models.UIModels
{
    public class MemberUIModel
    {
        public string username { get; set; }
        public string membercode { get; set; }

        public string firstname { get; set; }

        public string middlename { get; set; }
        public string lastname { get; set; }
        public Nullable<System.DateTime> dob { get; set; }


        public string email { get; set; }

        public string mobileno { get; set; }
        public string gender { get; set; }
        public Nullable<bool> isemailnotification { get; set; }
        public Nullable<bool> issmsnotification { get; set; }
        public Nullable<bool> isapproved { get; set; }
        public Nullable<bool> isactive { get; set; }

        public string notes { get; set; }
        public string presentaddress { get; set; }

        public string homephone { get; set; }

        public string workphone { get; set; }


        public string bloodgroup { get; set; }

        public string occupation { get; set; }

        public string qualification { get; set; }
        public string permanentaddress { get; set; }
        public Nullable<System.DateTime> joiningdate { get; set; }
        public Nullable<bool> ismarried { get; set; }

        public string accoundcode { get; set; }

        public string country { get; set; }


        public string city { get; set; }

        public string street { get; set; }

        public string pincode { get; set; }

        public string state { get; set; }
        public decimal subscriptionamount { get; set; }
        public string profileimage { get; set; }
        public Nullable<System.DateTime> weddingdate { get; set; }
        public string homeparish { get; set; }
    }
}
