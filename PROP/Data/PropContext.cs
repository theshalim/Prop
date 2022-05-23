using Microsoft.EntityFrameworkCore;
using PROP.Areas.HR.Models;
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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<NewStudent> NewStudents { get; set; }
    }
  
}
