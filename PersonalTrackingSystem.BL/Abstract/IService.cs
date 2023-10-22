using PersonalTrackingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.BL.Abstract
{
    public interface IService<T> where T : class, IEntity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T? Get(int id);
        List<T> GetAll();
    }
}
