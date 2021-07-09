using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Models
{
    public class PlayerViewModel
    {
        public int Num { get; set; }
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public Position Position { get; set; }
        public Team Team { get; set; }

        public bool Benched { get; set; }
        public bool Captain { get; set; }
        public bool vice { get; set; }
    }
}
