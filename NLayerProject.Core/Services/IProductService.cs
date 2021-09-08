using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
   interface IProductService:IService<Product>
    {
        //örneğin kontrol ettik. burada veri tabanına gitmek yerine veri tabanı dışında yazacağım kodları buraya yazarım
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
