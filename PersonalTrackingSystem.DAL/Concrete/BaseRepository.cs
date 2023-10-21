using Microsoft.EntityFrameworkCore;
using PersonalTrackingSystem.DAL.Abstract;
using PersonalTrackingSystem.DAL.Context;
using PersonalTrackingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.DAL.Concrete
{
    public class BaseRepository<T> : IDataAccessor<T> where T : class, IEntity
    {
        protected AppDbContext AppDbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public BaseRepository()
        {
            AppDbContext = new AppDbContext();
            DbSet = AppDbContext.Set<T>();
        }

        public void Insert(T entity)
        {
            DbSet.Add(entity);
            AppDbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            AppDbContext.Remove(entity);
            AppDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            AppDbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return DbSet.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }
    }
}
