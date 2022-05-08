using RetroShirtEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDtos.Requests
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı boş bırakılamaz.")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public double? Discount { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }     
        public int? TeamId { get; set; }     
        public int CategoryId { get; set; }
       
    }
}
