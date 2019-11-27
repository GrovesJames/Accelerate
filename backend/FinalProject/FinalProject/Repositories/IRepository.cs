using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repositories
{
    public interface IRepository<T> where T : class
    {
            IEnumerable<T> GetAll();
            T GetById(int id);
            void Create(T entity);
            void Delete(T entity);
            void Update(T entity);
            IEnumerable<T> GetByCompleted();
            IEnumerable<T> GetByNotCompleted();
    }
}
