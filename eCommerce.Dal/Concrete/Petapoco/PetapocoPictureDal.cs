using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using PetaPoco;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Dal.Concrete.Petapoco
{
    public class PetapocoPictureDal : IPictureDal
    {
        private Database _context = new Database("ECommerceContext");

        public List<Picture> GetAll()
        {

            var sql = Sql.Builder.Append("Select * from Picture");
            return _context.Query<Picture>(sql).ToList();


        }

        public Picture Get(int PictureId)
        {

            var sql = Sql.Builder.Append("Select * from Picture where PictureId=@0", PictureId);
            return _context.Single<Picture>(sql);

        }

        public void Add(Picture Picture)
        {

            _context.Insert(Picture);

        }

        public void Delete(int PictureId)
        {

            _context.Delete(PictureId);

        }

        public void Update(Picture Picture)
        {

            Picture _Picture = new Picture();
            _Picture.BigPath = Picture.BigPath;
            _Picture.MidPath = Picture.MidPath;
            _Picture.SmallPath = Picture.SmallPath;
            _Picture.IsDefault = Picture.IsDefault;
            _Picture.PictureRowNumber = Picture.PictureRowNumber;



            _context.Update(_Picture);

        }
    }
}
