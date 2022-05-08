using RetroShirtDtos.Responses;
using RetroShirtEntities;
using System.Collections.Generic;
using System.Linq;

namespace RetroShirtWeb.Models
{
    
    //TODO: Giriş yapıldıktan sonra products'a giden bi nav gözüksün.

    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class CartCollection
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public void Add(CartItem item)
        {
            var finding = CartItems.Find(c => c.Product.Id == item.Product.Id);
            if (finding == null)
            {
                CartItems.Add(item);
            }
            else
            {
                finding.Quantity += item.Quantity;
            }
        }
        public void ClearAll() => CartItems.Clear();

        public double GetTotalPrice() => CartItems.Sum(c => c.Product.Price * (1 - (c.Product.Discount ?? 0)) * c.Quantity);
        public void RemoveIt(int id) => CartItems.RemoveAll(c => c.Product.Id == id);

        public CartItem Delete(int id) => CartItems.Where(x => x.Product.Id == id).FirstOrDefault();
       
       

        

    }
}
