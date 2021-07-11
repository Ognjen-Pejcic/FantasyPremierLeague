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
    public class RepositoryGame : IRepositoryGame
    {
        private FantasyContext context;

        public RepositoryGame(FantasyContext context)
        {
            this.context = context;
        }
        public void Add(Game entity)
        {
            entity.Home = context.Teams.Find(entity.Home.ID);
            entity.Away = context.Teams.Find(entity.Away.ID);

            context.Games.Add(entity);
        }

        public void Delete(Game s)
        {
            throw new NotImplementedException();
        }

        public Game FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Game FindWithInclude(Predicate<Game> condition)
        {
            throw new NotImplementedException();
        }

        public Game FindWithoutInclude(Predicate<Game> condition)
        {
            throw new NotImplementedException();
        }

        public List<Game> GetAll()
        {
            return context.Games.ToList();
        }

        public List<Game> Search(Expression<Func<Game, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
