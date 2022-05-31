using PROP.Data;
using PROP.Models;
using PROP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services
{
    public class ProductService : IProduct
    {
        private readonly PropContext _context;
        public ProductService(PropContext context)
        {
            _context = context;
        }
        public void Add(Product products)
        {
            _context.Products.Add(products);
        }

        public void Delete(Product products)
        {
            _context.Products.Remove(products);
        }

        public List<Product> GetAll()
        {
           return _context.Products.ToList();
        }

        public Product GetById(int Id)
        {
            return _context.Products.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product products)
        {
            _context.Products.Update(products);
        }

       
    }
}
