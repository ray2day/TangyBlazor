using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
    public class SignInRequestDTO
    {
        [Required(ErrorMessage = "UserName is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
