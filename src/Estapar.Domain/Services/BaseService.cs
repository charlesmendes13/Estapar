using System;
using System.Collections.Generic;
using System.Text;

namespace Estapar.Domain
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(T entidade)
        {
            _repository.Delete(entidade);
        }

        public IEnumerable<T> Get()
        {
            return _repository.Get();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Insert(T entidade)
        {
            _repository.Insert(entidade);
        }

        public void Update(T entidade)
        {
            _repository.Update(entidade);
        }

        public int Commit()
        {
            return _repository.Commit();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
