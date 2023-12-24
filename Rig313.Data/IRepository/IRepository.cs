using Rig313.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Data.IRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        public T? GetById(int id);
        public IEnumerable<T?> GetAll();
        public void Add(T entity);

        public void Update(T entity);
        public void Delete(T entity);

    }
}
