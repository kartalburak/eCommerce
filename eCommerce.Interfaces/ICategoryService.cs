using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Entities;

namespace eCommerce.Interfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();
        [OperationContract]
        Category Get(int categoryId);
        [OperationContract]
        void Add(Category category);
        [OperationContract]
        void Delete(int categoryId);
        [OperationContract]
        void Update(Category category);







    }
}
