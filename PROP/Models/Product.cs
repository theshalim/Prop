using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Models
{
    public class Product
    {
        [Key]
        [StringLength(6)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display (Name= "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [ForeignKey("ProductOrigin")]
        public int OriginId { get; set; }

        public virtual ProductOrigin ProductOrigins { get; set; }
    }
}
