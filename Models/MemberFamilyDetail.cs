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
        public int memberfamilyid { get; set; }

        public Nullable<int> memberid { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Relative Name can only be 100 characters long!!")]
        public string relname { get; set; }
        public Nullable<System.DateTime> reldob { get; set; }
        [MaxLength(20, ErrorMessage = "Gender can only be 20 characters long!!")]
        public string relgender { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Relative Mobile number can only be 20 characters long!!")]
        public string relmobileno { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string address1 { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "State can only be 20 characters long!!")]
        public string state { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Country can only be 20 characters long!!")]
        public string country { get; set; }
        public Nullable<bool> isapproved { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Bloodgroup can only be 20 characters long!!")]
        public string bloodgroup { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Bloodgroup can only be 50 characters long!!")]
        public string relation { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Email can only be 20 characters long!!")]
        public string emailid { get; set; }
    }
}
