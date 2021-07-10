using Data.Implementation.Interfaces;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Repositories
{
    public class RepositoryUser : IRepositoryUser
    {

        private FantasyContext context;

        public RepositoryUser(FantasyContext context)
        {
            this.context = context;
        }

        public void Add(User entity)
        {
            context.Add(entity);
        }

        public void Delete(User s)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public User FindWithInclude(Predicate<User> condition)
        {
            throw new NotImplementedException();
        }

        public User FindWithoutInclude(Predicate<User> condition)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByUsernameAndPasswor(User user)
        {
            return context.Users.Single(u => u.Email == user.Email && u.Password == user.Password);
        }
        public List<User> Search(Expression<Func<User, bool>> pred)
        {
            return context.Users.Where(pred).ToList();
        }
    }
}
