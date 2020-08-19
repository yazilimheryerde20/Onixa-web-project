using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onixa.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, new() where TContext:DbContext,new()
    {
        
        public TEntity Add(TEntity Entity)
        {
            using (var context=new TContext())
            {
                var AddedEntity = context.Entry(Entity);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
                return Entity;
            }
        }

        public void Delete(TEntity Entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetList(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
