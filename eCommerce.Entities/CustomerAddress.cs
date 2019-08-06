using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("CustomerAddress")]
    public class CustomerAddress
    {
        public int CustomerAddressId { get; set; }
        public Guid CustomerId { get; set; }
        public string Address { get; set; }
        public string AddressName { get; set; }
    }
}