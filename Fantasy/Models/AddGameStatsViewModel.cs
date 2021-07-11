using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Models
{
    public class AddGameStatsViewModel
    {
        public Game Game { get; set; }
        public Team Home { get; set; }
        public int HomeID { get; set; }

        public Team Away { get; set; }
        public int AwayID { get; set; }

        public string pls { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public List<Player> Players { get; set; }
        public List<PlayerGameStatistics> Stats { get; set; }
    }
}
