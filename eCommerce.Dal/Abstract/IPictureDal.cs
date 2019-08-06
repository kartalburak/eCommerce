using eCommerce.Entities;
using System.Collections.Generic;

namespace eCommerce.Dal.Abstract
{
    public interface IPictureDal
    {

        List<Picture> GetAll();

        Picture Get(int PictureId);

        void Add(Picture Picture);

        void Delete(int PictureId);

        void Update(Picture Picture);

    }
}
