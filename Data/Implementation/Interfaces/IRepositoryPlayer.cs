using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepositoryPlayer : IRepository<Player>
    {
        List<Player> Search(Expression<Func<Player, bool>>p);
        List<Player> GetAllByTeam(Team team);
    }
}
