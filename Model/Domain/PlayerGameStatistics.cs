using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class PlayerGameStatistics
    {
        [Browsable(false)]
        public Game Game { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }

        public int NumOfGoals { get; set; }
        public int NumOfAssists { get; set; }
        public bool CleanSheet { get; set; }
        public bool YellowCard { get; set; }
        public bool RedCard { get; set; }
        public int MinutsPlayed { get; set; }
        public int GoalsConceded { get; set; }
        public int NumOfOwnGoals { get; set; }
        public int NumOfSaves { get; set; }
        public int PenaltiesMissed { get; set; }
        public int Points { get; set; }
    }
}
