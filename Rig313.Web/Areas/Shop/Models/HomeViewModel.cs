using Rig313.Core.Categories;
using Rig313.Core.Products;

namespace Rig313.Web.Areas.Shop.Models
{
	public class HomeViewModel
	{
        public IEnumerable<Category?> Categories { get; set; }
        public IEnumerable<Product?> NewProducts { get; set; }
    }
}
