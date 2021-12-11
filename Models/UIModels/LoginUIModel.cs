using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models.UIModels
{
    public class LoginUIModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
        public bool Status { get; set; }
        public string MSG { get; set; }
        public DateTime lastloggedin { get; set; }
    }
}
