using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Data;
using Rig313.Data.IRepository;
using Rig313.Core.Inventories;
using Rig313.Services.IServices;

namespace Rig313.Services
{
	public class InventoryService : IService
	{
		private readonly IRepository<Inventory> _repository;

        public InventoryService(IRepository<Inventory> repository)
        {
			_repository = repository;
        }

		public Inventory? GetInventoryByProductId(int id)
		{
			return _repository.GetAll().Where(u => u.ProductId == id).FirstOrDefault();
		}

	}
}
