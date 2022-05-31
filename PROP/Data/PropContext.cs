using Microsoft.EntityFrameworkCore;
using PROP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Data
{
    public class PropContext: DbContext
    {
        public PropContext(DbContextOptions<PropContext> options) : base(options)
        {
        }  
        public virtual DbSet<NewStudent> NewStudents { get; set; }
        public virtual DbSet<ProductOrigin> ProductOrigins { get; set; }    
        public virtual DbSet<Product> Products { get; set; }    
    }
  
}
