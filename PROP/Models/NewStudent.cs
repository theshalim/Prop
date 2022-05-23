using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Models
{
    public class NewStudent
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [Display(Name ="Father Name")]
        public string fName { get; set; }
        [Display(Name = "Mother Name")]
        public string mName { get; set; }
        public string Contact { get; set; }
    }
}
