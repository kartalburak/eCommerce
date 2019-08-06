using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using eCommerce.Interfaces;

namespace eCommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //validation
            //security
            //ex.handling
            // EfProductDal
            return _productDal.GetAll();
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public void Delete(int id)
        {
            _productDal.Delete(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }
    }
}