using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryPlayer : IRepositoryPlayer
    {
        private FantasyContext context;

        public RepositoryPlayer(FantasyContext context)
        {
            this.context = context;
        }
        public void Add(Player entity)
        {
            Team t = context.Teams.Find(entity.Team.ID);
            context.Players.Add(new Player
            {
                Name = entity.Name,
                Surname = entity.Surname,
                Position = entity.Position,
                Team =t
            });

           // context.Players.Add(entity);

        }

        public void Delete(Player s)
        {
            context.Players.Remove(s);
        }


        public Player FindById(int id)
        {
            return context.Players.Include(p => p.Team).First(p=>p.PlayerId==id);
        }

        public Player FindWithInclude(Predicate<Player> condition)
        {
            throw new NotImplementedException();
        }

        public Player FindWithoutInclude(Predicate<Player> condition)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetAll()
        {
            return context.Players.Include(p=>p.Team).ToList();
        }

        public List<Player> GetAllByTeam(Team team)
        {
            return context.Players.Include(p => p.Team).Where(p => p.TeamID == team.ID).ToList();
        }

        public List<Player> Search(Expression<Func<Player, bool>> p)
        {
            return context.Players.Where(p).ToList();
        }
    }
}
