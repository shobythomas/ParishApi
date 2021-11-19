using System;
using System.ComponentModel.DataAnnotations;

namespace ParishApi.Models
{
    public class UserLogin
    {
        [Key]
        [Required]
        [MaxLength(20, ErrorMessage = "Usercode can only be 20 characters long!!")]
        public string usercode { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Username can only be 100 characters long!!")]
        public string username { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Password can only be 100 characters long!!")]
        public string password { get; set; }
        public Nullable<System.DateTime> lastloggedin { get; set; }
        public Nullable<int> usertype { get; set; }
    }
}
