using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Data;
using Rig313.Core.Categories;
using Rig313.Data.IRepository;
using Rig313.Core.Products;
using Rig313.Core.Inventories;
using Rig313.Services.IServices;

namespace Rig313.Services
{
	public class ProductService: IService
	{
		private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
			_repository = repository;
        }

        public IEnumerable<Product?> GetNewFiveProducts()
		{
			return _repository.GetAll();
		}
		public IEnumerable<Product?> GetAllProducts()
		{
			return _repository.GetAll();
		}

		public Product? GetProductById(int id)
		{
			return _repository.GetById(id);
		}


	}
}
