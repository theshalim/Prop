using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Models
{
    public class ProductOrigin
    {
        [Key]
        [Required]
        public int OriginId { get; set; }

        [Required]
        public string Origin { get; set; }


    }
}
