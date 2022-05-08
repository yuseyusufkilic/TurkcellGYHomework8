using Microsoft.AspNetCore.Mvc;
using RetroShirt.Business.Abstract;
using System.Threading.Tasks;

namespace RetroShirtWeb.ViewComponents
{
    public class DropDownMenuViewComponent:ViewComponent
    {
        private ICategoryService categoryService;

        public DropDownMenuViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryService.GetCategories();
            return View(categories);
        }
    }   
}
