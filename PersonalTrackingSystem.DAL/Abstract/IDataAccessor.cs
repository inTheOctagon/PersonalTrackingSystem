using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.DAL.Abstract
{
    public interface IDataAccessor<T>
    {
        void Insert(T entity); 
        void Delete(T entity); 
        void Update(T entity);
        T Get(int id);
        List<T> GetAll(); 
    }
}
