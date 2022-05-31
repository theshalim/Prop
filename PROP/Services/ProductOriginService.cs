using PROP.Data;
using PROP.Models;
using PROP.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services
{
    public class ProductOriginService : IProductOrigin
    {
        private readonly PropContext _context;
        public ProductOriginService(PropContext context)
        {
            _context = context;
        }
        public void Add(ProductOrigin ProductOrigins)
        {
            _context.ProductOrigins.Add(ProductOrigins);
        }

        public void Delete(ProductOrigin ProductOrigins)
        {
            _context.ProductOrigins.Remove(ProductOrigins);
        }

        public List<ProductOrigin> GetAll()
        {
           return _context.ProductOrigins.ToList();
        }

        public ProductOrigin GetById(int Id)
        {
            return _context.ProductOrigins.Where(x => x.OriginId == Id).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ProductOrigin ProductOrigins)
        {
            _context.ProductOrigins.Update(ProductOrigins);
        }

       
    }
}
