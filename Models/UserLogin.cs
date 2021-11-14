using System;
using System.ComponentModel.DataAnnotations;

namespace ParishApi.Models
{
    public class UserLogin
    {
        [Key]
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastLoggedIn { get; set; }
        public Nullable<int> userType { get; set; }
    }
}
