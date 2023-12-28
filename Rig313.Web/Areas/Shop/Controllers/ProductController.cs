using Microsoft.AspNetCore.Mvc;
using Rig313.Core.Categories;
using Rig313.Core.Inventories;
using Rig313.Core.Products;
using Rig313.Data.IRepository;
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
		private readonly IRepository<Category> _categoryRepo;
		private readonly IRepository<Product> _productRepo;
		private readonly IRepository<Inventory> _inventoryRepo;

		public ProductController(ILogger<ProductController> logger, IRepository<Category> categoryRepo,
			IRepository<Product> productRepo, IRepository<Inventory> inventoryRepo )
		{
			_logger = logger;
			_categoryRepo = categoryRepo;
			_productRepo = productRepo;
			_inventoryRepo = inventoryRepo;
		}

		public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int? id)
        {
			if (id == null) return NotFound();
			CategoryService categoryService = new CategoryService(_categoryRepo);
			ProductService productService = new ProductService(_productRepo);
			InventorService inventorService = new InventorService(_inventoryRepo);
			ProductViewModel model = new ProductViewModel();
			model.Categories = categoryService.GetAllCategories();
			model.Product = productService.GetProductById((int)id);
			model.Inventory = inventorService.GetInventoryByProductId((int)id);
			model.Category = categoryService.GetById((int)model.Product.CategoryId);
			return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
