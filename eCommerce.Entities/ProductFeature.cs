using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("ProductFeature")]
    public class ProductFeature
    {
        [Key]
        public int ProductId { get; set; }
        public int FeatureTypeId { get; set; }
        public int FeatureValueId { get; set; }
    }
}