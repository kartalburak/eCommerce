using eCommerce.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace eCommerce.Interfaces
{
    [ServiceContract]
    public interface IBrandService
    {
        [OperationContract]
        List<Brand> GetAll();

        [OperationContract]
        Brand Get(int BrandId);

        [OperationContract]
        void Add(Brand Brand);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Brand Brand);
    }
}
