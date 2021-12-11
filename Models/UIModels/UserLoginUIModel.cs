using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models.UIModels
{
    public class UserLoginUIModel
    {
        public string usercode { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime lastloggedin { get; set; }
        public Nullable<int> usertype { get; set; }
    }
}
