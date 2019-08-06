using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Dal.Concrete.Entities
{
    public class EfBrandDal:IBrandDal
    {

        private ECommerceContext _context = new ECommerceContext();

        public List<Brand> GetAll()
        {
            return _context.Brand.ToList();
        }

        public Brand Get(int BrandId)
        {
            return _context.Brand.FirstOrDefault(p => p.BrandId == BrandId);
        }

        public void Add(Brand Brand)
        {
            _context.Brand.Add(Brand);
            _context.SaveChanges();
        }

        public void Delete(int BrandId)
        {
            _context.Brand.Remove(Get(BrandId));
        }

        public void Update(Brand Brand)
        {
            Brand BrandToUpdate = _context.Brand.FirstOrDefault(p => p.BrandId == Brand.BrandId);
            BrandToUpdate.BrandName = Brand.BrandName;
            BrandToUpdate.PictureId = Brand.PictureId;
            BrandToUpdate.BrandDescription = Brand.BrandDescription;
            

            _context.SaveChanges();
        }


    }
}
