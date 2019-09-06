using Nortwind.Dal.Abstract;
using Nortwind.Dal.Concrete.EntityFramework;
using Nortwind.Dll.Concrete;
using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.WCFLibrary.Concrete
{
    public class ProductService : IProductService
    {

        ProductManager productManager = new ProductManager(new EfProduct());
        public void Add(Product product)
        {
            productManager.Add(product);
        }

        public void Delete(int productID)
        {
            productManager.Delete(productID);
        }

        public Product Get(int productID)
        {
            return productManager.Get(productID);
        }

        public List<Product> GetAll()
        {
            return productManager.GetAll();
        }

        public void Update(Product product)
        {
            productManager.Update(product);
        }
    }
}
