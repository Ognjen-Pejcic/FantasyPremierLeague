using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Models
{
    public class SquadViewModel
    {
        public Squad Squad { get; set; }
        public Player Goalkeeper { get; set; }
        public List<Player> DefenderLine { get; set; }
        public List<Player> MidfielderLine { get; set; }
        public List<Player> AttackLine { get; set; }
        public List<Player> Bench { get; set; }
        public List<Player> StartLine { get; set; }

        public List<PlayerGameStatistics> stats { get; set; }
        public int activePlayer { get; set; }
        public int benchedPlayer { get; set; }
        public string TeamName { get; set; }
        public int Gameweek { get; set; }
        public int MaxGameWeek { get; set; }

        public int GWPoints { get; set; }
    }
}
