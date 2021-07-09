using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositorySquad : IRepositorySquad
    {
        private FantasyContext context;

        public RepositorySquad(FantasyContext context)
        {
            this.context = context;
        }
        public void Add(Squad entity/* ,List<PlayerSquadOption> playersOptions*/)
        {
            
           for(int i =0;i < entity.Players.Count; i++)
            {
                entity.Players[i] = context.Players.Find(entity.Players[i].PlayerId);
            }

            context.Squads.Add(entity);
           // List<Squad> sq = context.Squads.ToList();

           // = context.Squads.OrderByDescending(x => x.SquadId).Take(1);
       //     Squad s = data.re
            //foreach (PlayerSquadOption p in playersOptions)
            //{
            //    p.Player = context.Players.Find(p.Player.PlayerId);
            //    p.SquadId = sq[sq.Count-1].UserId+1;
            //    p.UserId = entity.UserId;
           //     context.PlayerSquadOptions.Add(p);
           // }
        }

        //public void Add(Squad entity)
        //{
        //    throw new NotImplementedException();
        //}

        public void Delete(Squad s)
        {
            throw new NotImplementedException();
        }

 

        public Squad FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Squad FindByID(int UserId, int SquadId)
        {
            return context.Squads.Find(UserId, SquadId);
           
        }

        public Squad FindWithInclude(Predicate<Squad> condition)
        {
            throw new NotImplementedException();
        }

        public Squad FindWithoutInclude(Predicate<Squad> condition)
        {
            throw new NotImplementedException();
        }

        public List<Squad> GetAll()
        {
            return context.Squads.ToList();
        }

        public List<Squad> GetAllWithUser()
        {
            return context.Squads.Include(s => s.User).ToList();
        }
    }
}
