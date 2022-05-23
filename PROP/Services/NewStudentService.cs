using PROP.Data;
using PROP.Models;
using PROP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services
{
    public class NewStudentService : INewStudent
    {
        private readonly PropContext _context;
        public NewStudentService(PropContext context)
        {
            _context = context;
        }
        public void Add(NewStudent newStudent)
        {
            _context.NewStudents.Add(newStudent);
        }

        public void Delete(NewStudent newStudent)
        {
            _context.NewStudents.Remove(newStudent);
        }

        public List<NewStudent> GetAll()
        {
           return _context.NewStudents.ToList();
        }

        public NewStudent GetById(int Id)
        {
            return _context.NewStudents.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(NewStudent newStudent)
        {
            _context.NewStudents.Update(newStudent);
        }
    }
}
