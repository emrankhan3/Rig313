using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Data;
using Rig313.Core.Categories;
using Rig313.Data.IRepository;
using Rig313.Core.Customers;
using Rig313.Services.IServices;

namespace Rig313.Services
{
	public class CustomerService : IService
	{
		private readonly IRepository<Customer> _repository;

        public CustomerService(IRepository<Customer> repository)
        {
			_repository = repository;
        }

        
		public Customer? GetById(int id)
		{
			return _repository.GetById(id);
		}
	}
}
