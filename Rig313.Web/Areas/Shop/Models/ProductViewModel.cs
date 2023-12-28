using Rig313.Core.Categories;
using Rig313.Core.Inventories;
using Rig313.Core.Products;

namespace Rig313.Web.Areas.Shop.Models
{
	public class ProductViewModel
	{
        public IEnumerable<Category?> Categories { get; set; }
		public Product Product { get; set; }
		public Inventory Inventory { get; set; }
		public Category Category { get; set; }
    }
}
