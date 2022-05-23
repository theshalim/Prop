using PROP.Areas.HR.Models;
using PROP.Data;
using PROP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly PropContext _context;
        public EmployeeService(PropContext context)
        {
            _context = context;
        }
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
         return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
    }
}
