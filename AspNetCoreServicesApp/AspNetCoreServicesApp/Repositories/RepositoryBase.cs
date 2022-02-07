using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspNetCoreServicesApp.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected LocationContext LocationContext { get; set; }

        public RepositoryBase(LocationContext locationContext)
        {
            this.LocationContext = locationContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.LocationContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.LocationContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.LocationContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.LocationContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.LocationContext.Set<T>().Remove(entity);
        }
    }
}
