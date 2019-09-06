using Nortwind.Dal.Abstract;
using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dal.Concrete.EntityFramework
{
    public class EfCategory : ICategoriesDal
    {
        NortwindContext context = new NortwindContext();
        public void Add(Category category)
        {
            context.Categories.Add(category);

        }

        public void Delete(Category category)
        {
            context.Categories.Remove(category);
        }

        public Category Get(int CategoryID)
        {
            return context.Categories.Where(c => c.CategoryID == CategoryID)
                .FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
