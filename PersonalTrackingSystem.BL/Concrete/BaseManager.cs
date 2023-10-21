using PersonalTrackingSystem.BL.Abstract;
using PersonalTrackingSystem.DAL.Concrete;
using PersonalTrackingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.BL.Concrete
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        protected BaseRepository<T> repository;
        public BaseManager()
        {
            repository = new BaseRepository<T>();
        }

        public virtual void Add(T entity)
        {
            repository.Insert(entity);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual void Update(T entity)
        {
            repository.Update(entity);
        }

        public virtual T? Get(int id)
        {
            return repository.Get(id);
        }

        public virtual List<T> GetAll(T entity)
        {
            return repository.GetAll();
        }  
    }
}
