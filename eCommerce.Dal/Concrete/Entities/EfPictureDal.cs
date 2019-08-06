using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Dal.Concrete.Entities
{
    public class EfPictureDal : IPictureDal
    {
        private ECommerceContext _context = new ECommerceContext();

        public List<Picture> GetAll()
        {
            return _context.Picture.ToList();
        }

        public Picture Get(int PictureId)
        {
            return _context.Picture.FirstOrDefault(p => p.PictureId == PictureId);
        }

        public void Add(Picture Picture)
        {
            _context.Picture.Add(Picture);
            _context.SaveChanges();
        }

        public void Delete(int PictureId)
        {
            _context.Picture.Remove(Get(PictureId));
        }

        public void Update(Picture Picture)
        {
            Picture PictureToUpdate = _context.Picture.FirstOrDefault(p => p.PictureId == Picture.PictureId);
            PictureToUpdate.BigPath = Picture.BigPath;
            PictureToUpdate.MidPath = Picture.MidPath;
            PictureToUpdate.SmallPath = Picture.SmallPath;
            PictureToUpdate.IsDefault = Picture.IsDefault;
            PictureToUpdate.PictureRowNumber = Picture.PictureRowNumber;
            //ToDo: devamı yazılacak
            _context.SaveChanges();
        }


    }
}
