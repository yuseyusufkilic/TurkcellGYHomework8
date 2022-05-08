using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtEntities
{
    public class Team:IEntity
    {
        public int TeamId { get; set; }
        [Required(ErrorMessage = "Team name can not be empty.")]
        [MinLength(2, ErrorMessage = "Lenght must be at least 2 characters.")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public List<CategoryTeam> CategoryTeams { get; set; } = new List<CategoryTeam>();
    }
}