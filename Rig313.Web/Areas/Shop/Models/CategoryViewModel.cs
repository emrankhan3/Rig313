using Rig313.Core.Categories;
using Rig313.Core.Inventories;
using Rig313.Core.Products;

namespace Rig313.Web.Areas.Shop.Models
{
	public class CategoryViewModel
	{
        public IEnumerable<Category?> Categories { get; set; }
        public IEnumerable<Product?> Products { get; set; }
        public Category Category { get; set; }
    }
}
