using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    interface ICategoryServices:IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);

        //category'e özgü metotlarımız varsa burada tanımlanır...

    }
}
