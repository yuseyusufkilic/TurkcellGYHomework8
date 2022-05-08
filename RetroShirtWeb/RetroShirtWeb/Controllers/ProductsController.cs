using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RetroShirt.Business.Abstract;
using RetroShirtDtos.Requests;
using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RetroShirtWeb.Controllers
{
    [Authorize(Roles = "admin,editor")]
    public class ProductsController : Controller
    {
        private ICategoryService categoryService;
        private IProductService productService;
        private ITeamService teamService;
        private ICategoryTeamService categoryTeamService;

        public ProductsController(ICategoryService categoryService, IProductService productService, ITeamService teamService, ICategoryTeamService categoryTeamService)
        {
            this.categoryService = categoryService;
            this.productService = productService;
            this.teamService = teamService;
            this.categoryTeamService = categoryTeamService;

        }
        public async Task<IActionResult> Index(int currentPage=1)
        {
            var products = await productService.GetEntitiesWithActiveStatus();
            var productsPerPage = 5;
            var paginatedProducts= products.OrderBy(x => x.Price).Skip((currentPage - 1) * productsPerPage).Take(productsPerPage);

            ViewBag.currentStandingPage = currentPage;
            ViewBag.TotalPages= Math.Ceiling((decimal)products.Count / productsPerPage);

            return View(paginatedProducts);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            List<SelectListItem> selectedCategories = new List<SelectListItem>();
            selectedCategories = await getCategoriesforDD();

            List<SelectListItem> selectedTeams = new List<SelectListItem>();
            selectedTeams = await getTeamsforDD();

            ViewBag.Categories = selectedCategories;
            ViewBag.Teams = selectedTeams;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductAddingRequest productAdding,CategoryTeam categoryTeam)
        {
            if (ModelState.IsValid)
            {
                int addedProductId = await productService.AddProduct(productAdding);
                await categoryTeamService.addMany2Many(productAdding, categoryTeam);
                TempData["AlertMessage"] = "Product added successfully";

                return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> CreateTeam()
        {
            List<SelectListItem> selectedTeams = new List<SelectListItem>();
            selectedTeams = await getTeamsforDD();
            ViewBag.Teams = selectedTeams;
            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam([Bind("TeamId,Name,Products,CategoryTeams")] Team team)
        {          
            if (ModelState.IsValid)
            {
                if (!await teamService.TeamIsExist(team) && team.Name!=null)
                {
                    await teamService.AddTeam(team);
                    TempData["AlertMessage"] = "Team added successfully";
                    return View();
                }
                TempData["AlertMessage"] = "Team name already exist or entered empty. Please check team list before adding.";
                
                return View();

            }
            
            return BadRequest();
        }

        //soft-delete inactive item.

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        { 
            var product = await productService.GetProductById(id);

            if (await productService.ProductIsExist(product))
            {
                var sendProduct= await productService.GetProductById(product.Id);
                return View(sendProduct);
            }

            return View();
        }

        [ActionName(nameof(Delete))]
        public async Task<IActionResult> DeleteOk(int id)
        {
            var product = await productService.GetProductById(id);
            
            if (product.IsActive == true)
            {
                await productService.DeleteProduct(id);
                return RedirectToAction(nameof(Index)); 
            }
            return BadRequest();
        }

        //hard-delete delist item from company page.

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await productService.GetProductById(id);

            if (await productService.ProductIsExist(product))
            {
                var sendProduct = await productService.GetProductById(product.Id);
                return View(sendProduct);
            }

            return View();

        }

        [HttpPost]
        [ActionName(nameof(Remove))]
        public async Task<IActionResult> RemoveOk(int id)
        {
            var deleteProduct = await productService.GetProductById(id);
            if (await productService.ProductIsExist(deleteProduct))
            {
                await productService.RemoveProductCompletely(id);
                return RedirectToAction(nameof(Index));
                
            }
            TempData["Alert"] = "Something went wrong. Please make sure it is proper deleting.";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductById(id);

            if (await productService.ProductIsExist(product))
            {
                var sendProduct = await productService.GetProductById(product.Id);
                return View(sendProduct);
            }

            return NotFound();

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            

            var product = await productService.GetProductById(id);

            if (await productService.ProductIsExist(product))
            {
                var sendProduct = await productService.GetProductById(product.Id);

                List<SelectListItem> selectedCategories = new List<SelectListItem>();
                selectedCategories = await getCategoriesforDD();

                List<SelectListItem> selectedTeams = new List<SelectListItem>();
                selectedTeams = await getTeamsforDD();

                ViewBag.Categories = selectedCategories;
                ViewBag.Teams = selectedTeams;
                return View(sendProduct);
            }
            

            return NotFound();

        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductUpdateRequest productToUpdate)
        {

            if (ModelState.IsValid)
            {
                
                int affectedRows= await productService.UpdateProduct(productToUpdate);

                if (affectedRows>0)
                {

                    TempData["RowAlert"] = "Edit successfully performed.";
                    return View();

                }
               
                return View();

            }
            TempData["RowAlert"] = "Your entries are not acceptable. Check your properties.";
            List<SelectListItem> selectedCategories = new List<SelectListItem>();
            selectedCategories = await getCategoriesforDD();

            List<SelectListItem> selectedTeams = new List<SelectListItem>();
            selectedTeams = await getTeamsforDD();

            ViewBag.Categories = selectedCategories;
            ViewBag.Teams = selectedTeams;
            return View();
        }



        private async Task<List<SelectListItem>> getCategoriesforDD()
        {
            var selectedItems = new List<SelectListItem>();
            var getCategories = await categoryService.GetCategories();

            getCategories.ToList().ForEach(x => selectedItems.Add(new SelectListItem { Text = x.Name, Value = x.CategoryId.ToString() }));

            return selectedItems;
        }
        private async Task<List<SelectListItem>> getTeamsforDD()
        {
            var selectedItems = new List<SelectListItem>();
            var getTeams = await teamService.GetTeams(); 

            getTeams.ToList().ForEach(x => selectedItems.Add(new SelectListItem { Text = x.Name, Value = x.TeamId.ToString() }));

            return selectedItems;
        }
     
    }
    
}
