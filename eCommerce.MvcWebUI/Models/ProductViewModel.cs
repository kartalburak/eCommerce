using System.Collections.Generic;
using eCommerce.Entities;

namespace eCommerce.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}