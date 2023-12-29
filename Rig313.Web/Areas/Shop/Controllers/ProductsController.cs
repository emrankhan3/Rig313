using Microsoft.AspNetCore.Mvc;
using Rig313.Core.Categories;
using Rig313.Core.Products;
using Rig313.Data.IRepository;
using Rig313.Services;
using Rig313.Web.Areas.Shop.Models;
using Rig313.Web.Models;
using System.Diagnostics;

namespace Rig313.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
		private readonly CategoryService _categoryService;
		private readonly ProductService _productService;

		public ProductsController(ILogger<ProductsController> logger, CategoryService categoryService, ProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Category(int? id)
        {
            if (id == null) return NotFound();
            if (id == 0) return NotFound();
            if (id.GetType() != typeof(int)) return NotFound();
			
			CategoryViewModel categoryViewModel = new CategoryViewModel();

            categoryViewModel.Categories = _categoryService.GetAllCategories();
            categoryViewModel.Category = _categoryService.GetById((int)id);
			if (categoryViewModel.Category == null) return NotFound();
			categoryViewModel.Products = _productService.GetAllProducts().Where(u => u.CategoryId == id).ToList();
            return View(categoryViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
