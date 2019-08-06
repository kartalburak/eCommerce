using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Business.Concrete;
using eCommerce.Dal.Concrete.Entities;
using eCommerce.Entities;
using eCommerce.Interfaces;

namespace eCommerce.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        //servis sınıfında constructor olmaz.
        //Instance provider ile ezilecek
        private ProductManager _productManager = new ProductManager(new EfProductDal());

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }

        public void Add(Product product)
        {
            _productManager.Add(product);
        }
    }
}