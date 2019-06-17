using System.Collections.Generic;

namespace TestTaskVMs.Repositories
{
    public interface IRepository<T>
    {
        bool Add(T item);
        bool Update(string id, T item);
        bool Delete(T item);
        bool Delete(string id);
        IEnumerable<T> GetAll();
        
    }
}