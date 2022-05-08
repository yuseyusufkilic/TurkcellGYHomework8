using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtEntities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This place can not be empty.")]
        [MinLength(4,ErrorMessage ="Fullname contains at least for 4 charachters.")]
        public string Fullname { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage ="This place can not be empty.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This place can not be empty.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }
      
    }
}
