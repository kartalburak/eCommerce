using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Dal.Abstract;
using eCommerce.Entities;
using PetaPoco;

namespace eCommerce.Dal.Concrete.Petapoco
{
    public class PetapocoProductDal : IProductDal
    {
        private Database _context = new Database("ECommerceContext");

        public List<Product> GetAll()
        {

            var sql = Sql.Builder.Append("Select * from Product");
            return _context.Query<Product>(sql).ToList();


        }

        public Product Get(int productId)
        {

            var sql = Sql.Builder.Append("Select * from Product where ProductId=@0", productId);
            return _context.Single<Product>(sql);

        }

        public void Add(Product product)
        {

            _context.Insert(product);

        }

        public void Delete(int productId)
        {

            _context.Delete(productId);

        }

        public void Update(Product product)
        {

            Product _product = new Product();
            _product.ProductName = product.ProductName;
            _product.ProductCode = product.ProductCode;
            _product.ProductDescription = product.ProductDescription;
            //todo:devamı yazılacak


            _context.Update(_product);

        }
    }
}
