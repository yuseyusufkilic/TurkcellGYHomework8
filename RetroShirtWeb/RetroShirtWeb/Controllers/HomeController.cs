using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetroShirt.Business.Abstract;
using RetroShirtWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RetroShirtWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public async Task<IActionResult> Index(int currentPage = 1, int? catId = 0)
        {
            var productsFromService = await productService.GetProducts();
            var products = catId == 0 ? productsFromService.ToList() : productsFromService.Where(x => x.CategoryId == catId).ToList();
            var productsPerPage = 4;

            var paginatedProducts = products.OrderBy(x => x.Id).Skip((currentPage - 1) * productsPerPage).Take(productsPerPage);

            ViewBag.currentStandingPage = currentPage;
            ViewBag.Category = catId;
            ViewBag.TotalPages = Math.Ceiling((decimal)products.Count / productsPerPage);

            //visitor count

            var visitString = Request.Cookies["visits"];
            int visits = 0;
            int.TryParse(visitString, out visits);

            if (visits >= 50)
            {
                visits = 0;
            }
            visits++;
            

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(30);
            
            Response.Cookies.Append("visits", visits.ToString(), options);

            ViewBag.visits = visits;
            return View(paginatedProducts);
        }

        [HttpPost]
        public async Task<IActionResult> Index (string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var foundedItems = await productService.SearcyByName(search);
                if (foundedItems.Any(x=>x.IsActive== true)) {
                    return View(foundedItems.Where(x => x.IsActive == true));
                }
                
            }


            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
