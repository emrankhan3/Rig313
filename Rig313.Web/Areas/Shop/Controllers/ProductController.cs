using Microsoft.AspNetCore.Mvc;
using Rig313.Services;
using Rig313.Web.Areas.Shop.Models;
using Rig313.Web.Models;
using System.Diagnostics;

namespace Rig313.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private readonly InventoryService _inventoryService;


		public ProductController(ILogger<ProductController> logger, CategoryService categoryService,
            ProductService productService, InventoryService inventoryService)
		{
			_logger = logger;
            _categoryService = categoryService;
            _productService = productService;
            _inventoryService = inventoryService;
		}

		public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int? id)
        {
			if (id == null) return NotFound();
			ProductViewModel model = new ProductViewModel();
			model.Categories = _categoryService.GetAllCategories();
			model.Product = _productService.GetProductById((int)id);
			model.Inventory = _inventoryService.GetInventoryByProductId((int)id);
			model.Category = _categoryService.GetById((int)model.Product.CategoryId);
			return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
