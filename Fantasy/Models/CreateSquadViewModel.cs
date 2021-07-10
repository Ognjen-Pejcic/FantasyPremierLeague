using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Models
{
    public class CreateSquadViewModel
        
    {
        public Squad Squad { get; set; }
        public int SquadId { get; set; }

        public int GameWeek { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public List<SelectListItem> Players { get; set; }
        public List<SelectListItem> PlayersGKP { get; set; }
        public List<SelectListItem> PlayersDEF { get; set; }
        public List<SelectListItem> PlayersMID { get; set; }
        public List<SelectListItem> PlayersFWD { get; set; }


        public List<Player> P { get; set; }
        public int A { get; set; }
        //public List<PlayerSquadOption> Players{ get; set; }

    }
}
