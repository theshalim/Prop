using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROP.Models;
using PROP.Services.Interface;

namespace PROP.Controllers
{
    public class NewStudentController : Controller
    {
        private readonly INewStudent _newStudent;
        public NewStudentController(INewStudent newStudent)
        {
            _newStudent = newStudent;
        }
        public IActionResult Index()
        {
            var NewStu = _newStudent.GetAll();
            return View(NewStu);
        }

        //ShowSearchForm
       
        public IActionResult ShowSearchForm()
        {
           
            return View();
        }
       
        //public async Task< IActionResult> ShowSearchResults(string SearchPhrase)
        //{ 
        //    return View("Index",await _newStudent.NewStudents.ToListAsync());
        //}


        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NewStudent NewStudents)
        {
            _newStudent.Add(NewStudents);
            _newStudent.Save();
            return RedirectToAction("Index");
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var newStudent = _newStudent.GetById(Id);
            return View(newStudent);
        }
        [HttpPost]
        public IActionResult Delete(NewStudent NewStudents)
        {
            _newStudent.Delete(NewStudents);
            _newStudent.Save();
            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var newStudent = _newStudent.GetById(Id);
            return View(newStudent);
        }
        [HttpPost]
        public IActionResult Edit(NewStudent NewStudents)
        {
            _newStudent.Update(NewStudents);
            _newStudent.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var newStudent = _newStudent.GetById(Id);
            return View(newStudent);
        }
    }
}