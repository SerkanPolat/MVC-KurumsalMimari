using Nortwind.Dal.Abstract;
using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dll.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoriesDal categoryDal; 

        public CategoryManager(ICategoriesDal categoriesDal)
        {
            categoryDal = categoriesDal;
        }

        public void Add(Category category)
        {
            categoryDal.Add(category);


        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public Category Get(int categoryID)
        {
            return categoryDal.Get(categoryID);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }
    }
}
