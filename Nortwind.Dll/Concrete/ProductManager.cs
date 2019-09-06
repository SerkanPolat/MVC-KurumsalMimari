using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Dal.Abstract;

namespace Nortwind.Dll.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Add(Product product)
        {
            this.productDal.Add(product);
        }

        public void Delete(int productID)
        {
            this.productDal.Delete(productID);
        }

        public Product Get(int productID)
        {
            return this.productDal.Get(productID);
        }

        public List<Product> GetAll()
        {
            return this.productDal.GetAll();
        }

        public void Update(Product product)
        {
            this.productDal.Update(product);
        }
    }
}
