using DesignPatterns.Models.Data;
using DesignPatterns.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository.Class
{
    public class UnitOfWork : IUnitOfWork
    {

        private DesignPatternsAppASPContext _context;
        public IRepository<Beer> _beers;
        public IRepository<Brand> _brands;

        public UnitOfWork(DesignPatternsAppASPContext context)
        {
            this._context = context;
        }

        public IRepository<Beer> Beers
        {
            get
            {
                return _beers == null ?
                    _beers = new Repository<Beer>(_context) :
                    _beers;
            }
        }

        public IRepository<Brand> Brands
        {
            get
            {
                return _brands == null ?
                    _brands = new Repository<Brand>(_context) :
                    _brands;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
