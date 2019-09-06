using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int productID);
        void Add(Product product);
        void Delete(int productID);
        void Update(Product product);

    }
}
