using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Unidad_2
{
    public class Program
    {
        public static void Main()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public interface IRepository<T>
            where T : class
        {
            List<T> AllEntities();
            T Get(int ID);
            T Add(T Entity);
            T Update(T Entity);
            T Delete(int D);
        }
        public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext
        {
            private readonly TContext _dbContext;


            protected BaseRepository(TContext dbContext)
            {
                _dbContext = dbContext;
            }

            public List<TEntity> GetAllEntities()
            {
                return _dbContext.Set<TEntity>().ToList();
            }

            public TEntity Get(int Id)
            {
                return _dbContext.Set<TEntity>().Find(Id);
            }

            public TEntity Add(TEntity entity)
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }

            public TEntity Update(TEntity entity)
            {
                throw new NotImplementedException();
            }

            public TEntity Delete(int id)
            {
                throw new NotImplementedException();
            }

            public List<TEntity> AllEntities()
            {
                throw new NotImplementedException();
            }
        }


    }
}
