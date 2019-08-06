using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("FeatureType")]
    public class FeatureType
    {
        public int FeatureTypeId { get; set; }
        public string FeatureTypeName { get; set; }
        public string FeatureTypeDescription { get; set; }
        public int CategoryId { get; set; }
    }
}