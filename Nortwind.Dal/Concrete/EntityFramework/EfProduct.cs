using Nortwind.Dal.Abstract;
using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dal.Concrete.EntityFramework
{
    public class EfProduct : IProductDal
    {
        NortwindContext context = new NortwindContext();
        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(int productID)
        {
            context.Products.Remove(Get(productID));

            context.SaveChanges();
        }

        public Product Get(int productID)
        {
            return context.Products.Where(p => p.ProductID == productID).FirstOrDefault();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Product product)
        {
            Product productUpdate = context.Products
                                    .FirstOrDefault(p => p.ProductID == product.ProductID);

            productUpdate.ProductName = product.ProductName;
            productUpdate.UnitPrice = product.UnitPrice;
            productUpdate.UnitsInStock = product.UnitsInStock;
            productUpdate.CategoryID = product.CategoryID;
            context.SaveChanges();

        }
    }
}