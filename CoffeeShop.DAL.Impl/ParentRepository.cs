using CoffeeShop.DAO.Impl.DataContext;
using DAL.Abstract;
using DAO.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.DAL.Impl
{
    public abstract class ParentRepository<TContext, TEntity> : IRepository<TEntity> where TEntity:class,
        IEntity where TContext: CoffeeShopAppContext
    {
        private TContext context;

        public ParentRepository(TContext context)
        {
            this.context = context;
        }

        public void Create(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
        }
        public void Delete(int id)
        {
            var temp = this.Get(id);
            if (temp != null)
                this.context.Set<TEntity>().Remove(temp);
        }

        public TEntity Get(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>();
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
        }
    }
}
