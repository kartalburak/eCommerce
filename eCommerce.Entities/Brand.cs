using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    [Table("Brand")]
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public int PictureId { get; set; }

        //public Brand GetBrandById(int id)
        //{
        //    var sql = Sql.Builder.Append("Select * from Brand where BrandId=@0", id);
        //    return StaticContext.db.Single<Brand>(sql);
        //}
    }
}