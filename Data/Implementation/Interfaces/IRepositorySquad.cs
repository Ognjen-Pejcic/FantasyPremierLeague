using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepositorySquad :IRepository<Squad>
    {
        List<Squad> GetAllWithUser();
      //  void Add(Squad entity, List<PlayerSquadOption> players);
       
        Squad FindByID(int UserId,int SquadId);
        void Update(Squad squad);
        Squad GetSquadForUser(int v, int gw);

        List<Squad> GetSquadByGW( int gw);
    }
}
