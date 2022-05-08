using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroShirtDtos.Responses
{
    public class UserResponse
    {
        public string Username { get; set; }
        [Required(ErrorMessage = "This place can not be empty.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This place can not be empty.")]
        [DataType(DataType.Password)]     
        public string Role { get; set; }
    }
}
