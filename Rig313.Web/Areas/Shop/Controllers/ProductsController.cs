using Microsoft.AspNetCore.Mvc;
using Rig313.Core.Categories;
using Rig313.Core.Products;
using Rig313.Data.IRepository;
using Rig313.Web.Areas.Shop.Models;
using Rig313.Web.Models;
using System.Diagnostics;

namespace Rig313.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IRepository<Category> _categoryRepo;
        private readonly IRepository<Product> _productRepo;

        public ProductsController(ILogger<ProductsController> logger, IRepository<Category> categoryRepo,
            IRepository<Product> productRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _productRepo = productRepo;
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
            categoryViewModel.Categories = _categoryRepo.GetAll();
            categoryViewModel.Category = _categoryRepo.GetById((int)id);
			if (categoryViewModel.Category == null) return NotFound();
			categoryViewModel.Products = _productRepo.GetAll().Where(u => u.CategoryId == id).ToList();
            return View(categoryViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
