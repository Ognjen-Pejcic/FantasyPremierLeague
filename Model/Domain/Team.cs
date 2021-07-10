using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

    }
}
