using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    //[TableName("Picture")]
    public class Picture
    {
        public int PictureId { get; set; }
        public string BigPath { get; set; }
        public string MidPath { get; set; }
        public string SmallPath { get; set; }
        public bool IsDefault { get; set; }
        public byte PictureRowNumber { get; set; }
        // public int ProductId { get; set; }
    }
}