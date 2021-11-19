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
        public int docid { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Document Name can only be 100 characters long!!")]
        public string docname { get; set; }
        public Nullable<System.DateTime> docdate { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Document Url can only be 500 characters long!!")]
        public string docurl { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "File Extention can only be 100 characters long!!")]
        public string fileextension { get; set; }
        [Required]
        public string doccomment { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
    }
}
