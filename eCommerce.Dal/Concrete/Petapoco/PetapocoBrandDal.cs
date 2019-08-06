using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using PetaPoco;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Dal.Concrete.Petapoco
{
    public class PetapocoBrandDal : IBrandDal
    {
        private Database _context = new Database("ECommerceContext");

        public List<Brand> GetAll()
        {

            var sql = Sql.Builder.Append("Select * from Brand");
            return _context.Query<Brand>(sql).ToList();

        }

        public Brand Get(int BrandId)
        {

            var sql = Sql.Builder.Append("Select * from Brand where BrandId=@0", BrandId);
            return _context.Single<Brand>(sql);

        }

        public void Add(Brand Brand)
        {

            _context.Insert(Brand);

        }

        public void Delete(int BrandId)
        {

            _context.Delete(BrandId);

        }

        public void Update(Brand Brand)
        {

            Brand _brand = new Brand();
            _brand.BrandName = Brand.BrandName;
            _brand.BrandDescription = Brand.BrandDescription;
            _brand.PictureId = Brand.PictureId;


            _context.Update(_brand);

        }
    }
}
