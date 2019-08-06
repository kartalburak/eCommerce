using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    [Table("Order")]
    //[PrimaryKey("OrderId", AutoIncrement = true)]
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public bool IsCart  { get; set; }
        public int CargoId { get; set; }
        public string CargoTrackingNo { get; set; }
        public int OrderStatusId { get; set; }
    }
}