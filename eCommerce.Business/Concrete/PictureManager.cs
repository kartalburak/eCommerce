using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using eCommerce.Interfaces;
using System.Collections.Generic;

namespace eCommerce.Business.Concrete
{
    public class PictureManager : IPictureService
    {
        private IPictureDal _PictureDal;

        public PictureManager(IPictureDal PictureDal)
        {
            _PictureDal = PictureDal;
        }

        public List<Picture> GetAll()
        {
            return _PictureDal.GetAll();
        }

        public Picture Get(int id)
        {
            return _PictureDal.Get(id);
        }

        public void Delete(int id)
        {
            _PictureDal.Delete(id);
        }

        public void Update(Picture Picture)
        {
            _PictureDal.Update(Picture);
        }

        public void Add(Picture Picture)
        {
            _PictureDal.Add(Picture);
        }


    }
}
