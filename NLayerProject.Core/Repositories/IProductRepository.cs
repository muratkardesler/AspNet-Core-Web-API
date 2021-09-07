using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
   public interface IProductRepository:IRepository<Product>
    {
        //herhangi bir ürünü aldığımız zaman ona bağlı olarak kategoriside gelsin

        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
