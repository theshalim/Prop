using PROP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROP.Services.Interface
{
    public interface IProductOrigin
    {
        List<ProductOrigin> GetAll();
        ProductOrigin GetById(int Id);
        void Add(ProductOrigin productOrigins);
        void Delete(ProductOrigin productOrigins);
        void Update(ProductOrigin productOrigins);
        void Save();
    }
}
