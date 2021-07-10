using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Squad
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SquadId { get; set; }

        public int GameWeek { get; set; }

        public User User { get; set; }
      
        public int UserId { get; set; }
     
        public List<Player> Players { get; set; }

        public int Captain { get; set; }
        public int ViceCaptain { get; set; }
        public int Benched1 { get; set; }
        public int Benched2 { get; set; }
        public int Benched3 { get; set; }
        public int Benched4 { get; set; }
    }
}
