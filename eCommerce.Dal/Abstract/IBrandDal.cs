using eCommerce.Entities;
using System.Collections.Generic;

namespace eCommerce.Dal.Abstract
{
    public interface IBrandDal
    {
        List<Brand> GetAll();

        Brand Get(int BrandId);

        void Add(Brand Brand);

        void Delete(int BrandId);

        void Update(Brand Brand);
    }
}
