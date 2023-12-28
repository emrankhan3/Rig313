using Microsoft.EntityFrameworkCore;
using Rig313.Core;
using Rig313.Data.DataAccess;
using Rig313.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public Repository(AppDbContext context) {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T?> GetAll(bool noTrack = false)
        {
            if(noTrack) return _table.AsNoTracking().ToList();
			return _table.ToList();
        }



		public T? GetById(int id)
        {
            return _table.Where(u => u.Id == id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _table.Update(entity);
            _context.SaveChanges();
        }
    }
}
