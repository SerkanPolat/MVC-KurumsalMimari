using Nortwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Interfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();

        [OperationContract]
        Category Get(int categoryID);

        [OperationContract]
        void Add(Category category);

        [OperationContract]
        void Delete(Category category);

    }
}
