using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("FeatureValue")]
    public class FeatureValue
    {
        public int FeatureValueId { get; set; }
        public string FeatureValueName { get; set; }
        public string FeatureValueDescription { get; set; }
        public int FeatureTypeId { get; set; }
    }
}