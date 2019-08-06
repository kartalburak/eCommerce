using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using eCommerce.Interfaces;
using System.Collections.Generic;

namespace eCommerce.Business.Concrete
{
    public class BrandManager : IBrandService
    {

        private IBrandDal _brandDal;

        public BrandManager(IBrandDal BrandDal)
        {
            _brandDal = BrandDal;
        }

        public List<Brand> GetAll()
        {
            //validation
            //security
            //ex.handling
            // EfBrandDal
            return _brandDal.GetAll();
        }

        public Brand Get(int id)
        {
            return _brandDal.Get(id);
        }

        public void Delete(int id)
        {
            _brandDal.Delete(id);
        }

        public void Update(Brand Brand)
        {
            _brandDal.Update(Brand);
        }

        public void Add(Brand Brand)
        {
            _brandDal.Add(Brand);
        }

    }
}
