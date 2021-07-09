using System;
using System.Collections.Generic;

namespace Data
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        List<T> GetAll();
        T FindWithoutInclude(Predicate<T> condition);
        T FindWithInclude(Predicate<T> condition);

        void Delete(T s);
        T FindById(int id);
    }
}
