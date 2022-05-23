using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Areas.HR.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string EmpName { get; set; }
     
        [DataType(DataType.PhoneNumber)]
        public string EmpPhone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmpEmail { get; set; }
        
    }
}
