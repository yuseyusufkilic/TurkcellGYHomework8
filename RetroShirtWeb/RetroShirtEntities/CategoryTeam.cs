using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtEntities
{
    public class CategoryTeam:IEntity
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }    
        public int TeamId { get; set; }    
        public Team Team { get; set; }
        
    }
}
