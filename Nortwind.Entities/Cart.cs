using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Entities
{
    public class Cart
    {
        List<CartLine> lines = new List<CartLine>();

        public void AddToCart(Product product, int UrunSayisi)
        {

            CartLine cartLine = lines.FirstOrDefault(c => c.CartProduct.ProductID == product.ProductID);
            if (cartLine == null)
            {
                lines.Add(new CartLine { CartProduct = product, CartUrunSayisi = UrunSayisi });
            }
            else
            {
                cartLine.CartUrunSayisi++;
            }
        }
        public void RemoveToCart(Product product)
        {
            lines.RemoveAll(c => c.CartProduct.ProductID == product.ProductID);
        }
        public decimal TotalPrice()
        {
            return lines.Sum(c => c.CartProduct.UnitPrice * c.CartUrunSayisi);
        }
        public void Clear()
        {
            lines.Clear();
        }
        public List<CartLine> Lines()
        {
            return lines;
        }

    }
    public class CartLine
    {
        public Product CartProduct { get; set; }
        public int CartUrunSayisi { get; set; }


    }
}
