using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Interfaces
{
    public interface IRepositoryUser : IRepository<User>
    {
        User GetByUsernameAndPasswor(User user);
        //List<User> Search(Expression<Func<Task, bool>> pred);
    }
}
