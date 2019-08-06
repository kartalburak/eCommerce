using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("Cargo")]
    public class Cargo
    {
        public int CargoId { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public char Phone { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
    }
}