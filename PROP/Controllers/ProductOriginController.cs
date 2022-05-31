using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROP.Models;
using PROP.Services.Interface;

namespace PROP.Controllers
{
    public class ProductOriginController : Controller
    {
        private readonly IProductOrigin _Origin;
        public ProductOriginController(IProductOrigin Origin)
        {
            _Origin = Origin;
        }
        public IActionResult Index()
        {
            var product = _Origin.GetAll();
            return View(product);
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
        public IActionResult Create(ProductOrigin ProductOrigins)
        {
            _Origin.Add(ProductOrigins);
            _Origin.Save();
            return RedirectToAction("Index");
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int OriginId)
        {
            var product = _Origin.GetById(OriginId);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(ProductOrigin ProductOrigins)
        {
            _Origin.Delete(ProductOrigins);
            _Origin.Save();
            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int OriginId)
        {
            var product = _Origin.GetById(OriginId);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(ProductOrigin ProductOrigins)
        {
            _Origin.Update(ProductOrigins);
            _Origin.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int OriginId)
        {
            var product = _Origin.GetById(OriginId);
            return View(product);
        }
    }
}