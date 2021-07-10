using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Models
{
    public class SquadViewModel
    {
        public Player Goalkeeper { get; set; }
        public List<Player> DefenderLine { get; set; }
        public List<Player> MidfielderLine { get; set; }
        public List<Player> AttackLine { get; set; }
        public List<Player> Bench { get; set; }
        public List<Player> StartLine { get; set; }
        public int activePlayer { get; set; }
        public int benchedPlayer { get; set; }
    }
}
