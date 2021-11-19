using System;
using System.ComponentModel.DataAnnotations;

namespace ParishApi.Models
{
    public class Member
    {
        [Key]
        public int memberid { get; set; }
        
        [Required]
        [MaxLength(20, ErrorMessage = "Member Code can only be 20 characters long!!")]
        public string membercode { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Firstname can only be 100 characters long!!")]
        public string firstname { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Middlename can only be 100 characters long!!")]
        public string middlename { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Lastname can only be 100 characters long!!")]
        public string lastname { get; set; }
        public Nullable<System.DateTime> dob { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Email can only be 20 characters long!!")]
        public string email { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Mobile Number can only be 20 characters long!!")]
        public string mobileno { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Gender can only be 10 characters long!!")]
        public string gender { get; set; }
        public Nullable<bool> isemailnotification { get; set; }
        public Nullable<bool> issmsnotification { get; set; }
        public Nullable<bool> isapproved { get; set; }
        public Nullable<bool> isactive { get; set; }

        public string notes { get; set; }
        public string presentaddress { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Home Phone can only be 20 characters long!!")]
        public string homephone { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Work Phone can only be 20 characters long!!")]
        public string workphone { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Blood Group can only be 20 characters long!!")]
        public string bloodgroup { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Occupation can only be 50 characters long!!")]
        public string occupation { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Qualification can only be 50 characters long!!")]
        public string qualification { get; set; }
        public string permanentaddress { get; set; }
        public Nullable<System.DateTime> joiningdate { get; set; }
        public Nullable<bool> ismarried { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Account Code can only be 20 characters long!!")]
        public string accoundcode { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Country can only be 50 characters long!!")]
        public string country { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "City can only be 50 characters long!!")]
        public string city { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Street can only be 100 characters long!!")]
        public string street { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Pincode can only be 20 characters long!!")]
        public string pincode { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "State can only be 50 characters long!!")]
        public string state { get; set; }
        public decimal subscriptionamount { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Profile Image can only be 500 characters long!!")]
        public string profileimage { get; set; }
        public Nullable<System.DateTime> weddingdate { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Home Parish can only be 100 characters long!!")]
        public string homeparish { get; set; }
    }
}
