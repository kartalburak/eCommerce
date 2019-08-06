using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Entities
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        List<CartLine> _lines = new List<CartLine>();


        public void AddtoCart(Product product, int quantity)
        {
            //sepette varsa adeti artırılır.
            CartLine cartLine = _lines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine == null)//sepette bu ürün yoksa sepete ekle
            {
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                cartLine.Quantity += quantity;
            }
        }

        public void RemoveFromCart(Product product)
        {

            _lines.RemoveAll(p => p.Product.ProductId == product.ProductId);

        }

        public decimal Total
        {
            get { return _lines.Sum(c => c.Product.SalePrice * c.Quantity); }
        }

        public void Clear()
        {
            _lines.Clear();
        }

        public List<CartLine> Lines
        {
            get { return _lines; }
        }








    }

    public class CartLine
    {
        [Key]
        public int CartLineId { get; set; }  
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
