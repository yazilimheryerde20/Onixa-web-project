using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onixa.Core.DataAccess.EntityFramework
{
    public class EFQueryableRepository<T> : IQueryableRepository<T> where T : class, new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;
        public EFQueryableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Table
        {
            get { return this.Entities; }
        }

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities==null)
                {
                    _entities = _context.Set<T>();
                }

                return _entities;
            }
        }
    }
    
}
