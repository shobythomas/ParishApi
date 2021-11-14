using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models
{
    public class MemberFamilyDetail
    {
        [Key]
        public int MemberFamilyId { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string RelName { get; set; }
        public Nullable<System.DateTime> RelDOB { get; set; }
        public string RelGender { get; set; }
        public string RelMobileNo { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string BloodGroup { get; set; }
        public string Relation { get; set; }
        public string EmailID { get; set; }
    }
}
