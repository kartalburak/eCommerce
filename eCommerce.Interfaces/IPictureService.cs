using eCommerce.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace eCommerce.Interfaces
{
    [ServiceContract]
    public interface IPictureService
    {
        [OperationContract]
        List<Picture> GetAll();

        [OperationContract]
        Picture Get(int PictureId);

        [OperationContract]
        void Add(Picture Picture);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        void Update(Picture Picture);

    }
}
