using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParishApi.Models
{
    public class MST_Documents
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string Docurl { get; set; }
        public string FileExtension { get; set; }
        public string DocComment { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
