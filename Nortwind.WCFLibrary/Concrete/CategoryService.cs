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
    public class CategoryService:ICategoryService
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategory());
        public void Add(Category category)
        {
            categoryManager.Add(category);
        }
        public void Delete(Category category)
        {
            categoryManager.Delete(category);
        }
        public Category Get(int categoryID)
        {
            return categoryManager.Get(categoryID);
        }

        public List<Category> GetAll()
        {
            return categoryManager.GetAll().ToList();
        }
    }
}
