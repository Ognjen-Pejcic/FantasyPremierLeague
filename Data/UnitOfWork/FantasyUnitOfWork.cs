using Data.Implementation;
using Data.Implementation.Interfaces;
using Data.Implementation.Repositories;
using Data.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public class FantasyUnitOfWork : IUnitOfWork, IDisposable
    {
        private FantasyContext context;
        public IRepositoryPlayer Player { get; set ; }
        public IRepositorySquad Squad { get; set; }
        public IRepositoryTeam Team { get ; set ; }
        public IRepositoryUser User { get; set; }

        //public IRepositoryPlayerSquadOption Players { get; set ; }

        public FantasyUnitOfWork(FantasyContext context)
        {
            this.context = context;
            Player = new RepositoryPlayer(context);
            Squad = new RepositorySquad(context);
            Team = new RepositoryTeam(context);
            User = new RepositoryUser(context);
        }
        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
