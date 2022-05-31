using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PROP.Models;
using PROP.Services.Interface;

namespace PROP.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductOrigin _Origin;
        private readonly IProduct _product;

        public ProductController(IProduct product, IProductOrigin Origin)
        {
            _product = product;
            _Origin = Origin;
        }
        public IActionResult Index()
        {
            //    string sortExpression ="", string SearchText = "", 
            //    int pg = 1, int pazeSize = 5  )
            //{
            //    SortModel sortModel = new SortModel();
            //    sortModel.AddColumn("ProductName");
            //    sortModel.AddColumn("Description");
            //    sortModel.ApplySort(sortExpression);
            //    ViewData["sortModel"] = sortModel;

            //    ViewBag.SearchText = SearchText;

            //    PaginatedList<Product> Products = _product


            var product = _product.GetAll();
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
            //Product product = new Product();
            //ViewBag.ProductOrigins = GetOrigins();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product Products)
        {
            _product.Add(Products);
            _product.Save();
            return RedirectToAction("Index");
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = _product.GetById(Id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product Products)
        {
            _product.Delete(Products);
            _product.Save();
            return RedirectToAction("Index");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = _product.GetById(Id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product Products)
        {
            _product.Update(Products);
            _product.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var product = _product.GetById(Id);
            return View(product);
        }


        //private List<SelectListItem> GetProductOrigins()
        //{
        //    var IstOrigins = new List<SelectListItem>();

        //    PaginatedList<ProductOrigin> ProductOrigins = _Origin.GetItems("Name", SortOrder.Assending);

        //        return IstOrigins;
            
        //}
        
    }
}