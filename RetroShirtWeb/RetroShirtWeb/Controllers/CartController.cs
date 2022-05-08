using Microsoft.AspNetCore.Mvc;
using RetroShirt.Business.Abstract;
using RetroShirtDtos.Responses;
using RetroShirtWeb.Extensions;
using RetroShirtWeb.Models;
using System;
using System.Threading.Tasks;

namespace RetroShirtWeb.Controllers
{
   
    public class CartController : Controller
    {
        private IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            var shopCart = getSessionCollection();
            return View(shopCart);
        }

        public async Task<IActionResult> Add(int id)
        {
            var product=await productService.GetProductById(id);
            if (await productService.ProductIsExist(product))
            {
                CartCollection cartCollection=getSessionCollection();
                cartCollection.Add(new CartItem { Product = product, Quantity = 1 });
                saveToSession(cartCollection);
                return Json($"{product.Name} added to cart.");
            }

            return NotFound();
        }

        public async Task<IActionResult> Remove(int id)
        {
            try
            {
               
                var product = await productService.GetProductById(id);

                CartCollection cartCollection = getSessionCollection();

                var product1 = cartCollection.Delete(id);

                if (product1.Quantity==1)
                {
                    cartCollection.RemoveIt(id);
                }
                product1.Quantity = (product1.Quantity - 1);

                saveToSession(cartCollection);
                return RedirectToAction("Index");
            }
            catch (NullReferenceException)
            {

                return RedirectToAction("Index");
            }
        }

        public  IActionResult RemoveAllCart()
        {
            CartCollection cartCollection=getSessionCollection();
            cartCollection.ClearAll();
            saveToSession(cartCollection);
            return RedirectToAction(nameof(Index));
        }

        


        // object to json - serialize
        // json to object- deserialize
        private CartCollection getSessionCollection()
        {
            CartCollection cartCollection = null;
            cartCollection=HttpContext.Session.GetJson<CartCollection>("shopCart") ?? new CartCollection();
            return cartCollection;
        }

        private void saveToSession(CartCollection cartCollection)
        {
            HttpContext.Session.SetJson("shopCart", cartCollection);
        }
    }
}
