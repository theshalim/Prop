using PROP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services.Interface
{
    public interface INewStudent
    {
        List<NewStudent> GetAll();
        NewStudent GetById(int Id);
        void Add(NewStudent newStudent);
        void Delete(NewStudent newStudent);
        void Update(NewStudent newStudent);
        void Save();
    }
}
