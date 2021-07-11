using Data.Implementation.Interfaces;
using Microsoft.EntityFrameworkCore;
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
    public class RepositoryStatistics : IRepositoryStatistics
    {
        private FantasyContext context;

        public RepositoryStatistics(FantasyContext context)
        {
            this.context = context;
        }
        public void Add(PlayerGameStatistics entity)
        {
            entity.Points += entity.NumOfGoals * 5 + entity.NumOfAssists * 3 - entity.PenaltiesMissed * 2;
            if (entity.MinutsPlayed < 60) entity.Points += 1;
            else entity.Points += 2;
            if(entity.YellowCard) entity.Points -= 1;
            if (entity.RedCard) entity.Points -= 2;
            if (entity.CleanSheet) entity.Points +=4;
            context.PlayerGameStatistics.Add(entity);
        }

        public void Delete(PlayerGameStatistics s)
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics FindById(int id)
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics FindWithInclude(Predicate<PlayerGameStatistics> condition)
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics FindWithoutInclude(Predicate<PlayerGameStatistics> condition)
        {
            throw new NotImplementedException();
        }

        public List<PlayerGameStatistics> GetAll()
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics GetbygwID(int gameweek, int playerId)
        {
            List<Game> games = context.Games.Include(p => p.Home).Include(p => p.Away).Where(g => g.GameWeek == gameweek).ToList();

            Player player = context.Players.Include(p => p.Team).Where(p => p.PlayerId == playerId).First();

            try
            {
                int gameId = games.Where(p => p.Home.ID == player.Team.ID || p.Away.ID == player.Team.ID).First().GameId;
                return context.PlayerGameStatistics.FirstOrDefault(s => s.PlayerId == playerId && s.GameId == gameId);
            }
            catch
            {
                return new PlayerGameStatistics();
            }
            

            
        }

        public List<PlayerGameStatistics> Search(Expression<Func<PlayerGameStatistics, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
