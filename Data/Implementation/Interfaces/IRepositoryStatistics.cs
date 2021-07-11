using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Interfaces
{
    public interface IRepositoryStatistics : IRepository<PlayerGameStatistics>
    {
        PlayerGameStatistics GetbygwID(int gameweek, int playerId);
    }
}
