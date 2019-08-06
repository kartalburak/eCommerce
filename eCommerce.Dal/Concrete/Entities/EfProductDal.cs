using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Dal.Abstract;
using eCommerce.Entities;

namespace eCommerce.Dal.Concrete.Entities
{
    public class EfProductDal : IProductDal
    {
        private ECommerceContext _context = new ECommerceContext();

        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public Product Get(int productId)
        {
            return _context.Product.FirstOrDefault(p => p.ProductId == productId);
        }

        public void Add(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Product.Remove(Get(productId));
        }

        public void Update(Product product)
        {
            Product productToUpdate = _context.Product.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductCode = product.ProductCode;
            productToUpdate.ProductDescription = product.ProductDescription;
            //ToDo: devamı yazılacak
            _context.SaveChanges();
        }
    }
}