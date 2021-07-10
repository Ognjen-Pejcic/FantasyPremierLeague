using Model.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Player
    {
        public int PlayerId { get; set; }
        [Required(ErrorMessage = "Name is required")] 
        [Validation.Validation(ErrorMessage ="Name must have at least 3 characters")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }
        public Team Team { get; set; }
        public int TeamID { get; set; }
        public List<Squad> Squads { get; set; }
        public double Price { get; set; }

    }
    public enum Position
    {
        GKP=1, DEF=2, MID=3, FWD=4
    }
}
