using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        List<T> Search(Expression<Func<T, bool>> pred);
    }
}
