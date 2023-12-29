using Microsoft.AspNetCore.Mvc;
using Rig313.Core.Categories;
using Rig313.Core.Customers;
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
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;

        public HomeController(ILogger<HomeController> logger, CategoryService categoryService, ProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Categories = _categoryService.GetAllCategories();
            model.NewProducts = _productService.GetNewFiveProducts();
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
