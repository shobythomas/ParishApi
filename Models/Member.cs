using System;
using System.ComponentModel.DataAnnotations;

namespace ParishApi.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        public string MemberCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> IsEmailNotification { get; set; }
        public Nullable<bool> IsSMSNotification { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Notes { get; set; }
        public string Present_Address { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string BloodGroup { get; set; }
        public string Occupation { get; set; }
        public string Qualification { get; set; }
        public string Permenant_Address { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<bool> IsMarried { get; set; }
        public string Account_Code { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public Nullable<decimal> Subscription_Amount { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<System.DateTime> WeddingDate { get; set; }
        public string HomeParish { get; set; }
    }
}
