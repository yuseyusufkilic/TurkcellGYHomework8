using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDtos.Requests
{
    public class ProductAddingRequest
    {
        [Required(ErrorMessage = "Ürün adı boş bırakılamaz.")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double? Discount { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public Team Team { get; set; }
        public int? TeamId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<CategoryTeam> CategoryTeams { get; set; } = new List<CategoryTeam>();


    }
}
