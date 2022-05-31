using PROP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services.Interface
{
    public interface IProduct
    {
        List<Product> GetAll();
        Product GetById(int Id);
        void Add(Product products);
        void Delete(Product products);
        void Update(Product products);
        void Save();
    }
}
