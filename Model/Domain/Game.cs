using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Game
    {
        public int GameId { get; set; }
        public int GameWeek { get; set; }
        public Team Home{ get; set; }
        public Team Away { get; set; }
        public int GoalsHomeTeam { get; set; }
        public int GoalsAwayTeam { get; set; }
    }
}
