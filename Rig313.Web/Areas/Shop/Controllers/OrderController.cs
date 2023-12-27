using Microsoft.AspNetCore.Mvc;
using Rig313.Web.Models;
using System.Diagnostics;

namespace Rig313.Web.Areas.Shop.Controllers
{
    [Area("Shop")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Details(int? id)
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
