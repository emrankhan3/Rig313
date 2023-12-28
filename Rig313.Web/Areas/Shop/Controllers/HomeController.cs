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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<Product> _productRepo;

        public HomeController(ILogger<HomeController> logger, IRepository<Category> categoryRepo,
            IRepository<Product> productRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            CategoryService categoryService = new CategoryService(_categoryRepo);
            ProductService productService = new ProductService(_productRepo);
            HomeViewModel model = new HomeViewModel();
            model.Categories = categoryService.GetAllCategories();
            model.NewProducts = productService.GetNewFiveProducts();
            return View(model);
        }

        public IActionResult Profile()
        {
            return View();
        }

		public IActionResult Registration()
		{
			return View();
		}
        
		public IActionResult Login()
		{
			return View();
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
