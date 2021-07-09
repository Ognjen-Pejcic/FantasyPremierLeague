using Data.Implementation.Interfaces;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Repositories
{
    public class RepositoryTeam : IRepositoryTeam
    {
        private FantasyContext context;

        public RepositoryTeam(FantasyContext context)
        {
            this.context = context;
        }
        public void Add(Team entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Team s)
        {
            throw new NotImplementedException();
        }

        public Team FindById(int id)
        {
            return context.Teams.Find(id);
        }

        public Team FindWithInclude(Predicate<Team> condition)
        {
            throw new NotImplementedException();
        }

        public Team FindWithoutInclude(Predicate<Team> condition)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAll()
        {
           return context.Teams.ToList();
        }
    }
}
