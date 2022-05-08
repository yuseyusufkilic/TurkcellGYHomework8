using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDtos.Responses
{
    public class ProductListResponse
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can not be empty.")]
        [MinLength(3, ErrorMessage = "Lenght must be at least 3 characters.")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double? Discount { get; set; }
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Team Team { get; set; }
        public int? TeamId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
