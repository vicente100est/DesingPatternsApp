using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using DesignPatterns.Models.Data;

namespace DesignPatterns.Repository.Class
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private DesignPatternsAppASPContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DesignPatternsAppASPContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dateToDelete = _dbSet.Find(id);
            _dbSet.Remove(dateToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
