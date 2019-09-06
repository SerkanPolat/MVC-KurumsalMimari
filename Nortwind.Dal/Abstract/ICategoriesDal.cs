using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Dal.Abstract
{
    public interface ICategoriesDal
    {
        List<Category> GetAll();
        Category Get(int CategoryID);
        void Add(Category category);
        void Delete(Category category);

    }
}
