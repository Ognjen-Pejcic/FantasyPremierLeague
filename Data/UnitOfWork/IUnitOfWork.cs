using Data.Implementation.Interfaces;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork :IDisposable
    {
        public IRepositoryPlayer Player { get; set; }
        public IRepositorySquad Squad{ get; set; }
        public IRepositoryTeam Team { get; set; }
        public IRepositoryUser User { get; set; }
        public IRepositoryGame Game { get; set; }
        public IRepositoryStatistics Statistics{ get; set; }
        //public IRepositoryPlayerSquadOption Players { get; set; }
        void Commit();
    }
}
