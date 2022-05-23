using PROP.Areas.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        void Save();
    }
}
