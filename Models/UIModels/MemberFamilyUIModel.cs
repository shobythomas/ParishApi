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

        public string relation { get; set; }
        public Nullable<bool> isapproved { get; set; }
    }
}
