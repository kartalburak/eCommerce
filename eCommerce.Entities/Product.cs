using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    [Table("Product")]
    //[PrimaryKey("ProductId", AutoIncrement = true)]
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        //public List<Product> GetProducts()
        //{
        //    var sql = Sql.Builder.Append("Select * from Product");
        //    return StaticContext.db.Fetch<Product>(sql);
        //}

        //public Product GetProductById(int id)
        //{
        //    var sql = Sql.Builder.Append("Select * from Product where ProductId=@0", id);
        //    return StaticContext.db.Single<Product>(sql);
        //}

        //public List<Product> GetProductBetweenPrice(double minPrice, double maxPrice)
        //{
        //    var sql = Sql.Builder.Append("Select * from Product where SalePrice between @0 and @1", minPrice, maxPrice);
        //    return StaticContext.db.Fetch<Product>(sql);
        //}
    }
}