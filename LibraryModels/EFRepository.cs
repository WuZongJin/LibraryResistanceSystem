using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LibraryEntities
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private MyDbContext _myDbContext;

        public EFRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }


        public DbContext DbContext
        {
            get { return _myDbContext; }
        }

        public DbSet<TEntity> Entities
        {
            get { return _myDbContext.Set<TEntity>(); }
        }

        public IQueryable<TEntity> Table
        {
            get { return Entities; }
        }

        public void Delete(TEntity entity, bool isSave = true)
        {
            Entities.Remove(entity);
            if (isSave)
                _myDbContext.SaveChanges();
        }

        public TEntity GetById(object id)
        {
            return _myDbContext.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity, bool isSave = true)
        {
            Entities.Add(entity);
            if (isSave)
                _myDbContext.SaveChanges();
        }

        public void Update(TEntity entity, bool isSave = true)
        {
            Entities.Update(entity);
            if (isSave)
                _myDbContext.SaveChanges();
        }
    }
}
