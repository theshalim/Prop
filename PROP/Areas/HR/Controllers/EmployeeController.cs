using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROP.Areas.HR.Models;
using PROP.Services.Interface;

namespace PROP.Areas.HR.Controllers
{
    [Area("HR")]
    [Route("hr/[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        public IActionResult Index()
        {
            var employee = _employee.GetAll();
            return View(employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee Employees)
        {
            _employee.Add(Employees);
            _employee.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee Employees)
        {
            _employee.Delete(Employees);
            _employee.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee Employees)
        {
            _employee.Update(Employees);
            _employee.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var employee = _employee.GetById(Id);
            return View(employee);
        }
    }
}