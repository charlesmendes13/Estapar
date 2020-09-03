using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(object id);
        void Insert(T entidade);
        void Update(T entidade);
        void Delete(T entidade);
        void Commit();
        void Dispose();
    }
}
