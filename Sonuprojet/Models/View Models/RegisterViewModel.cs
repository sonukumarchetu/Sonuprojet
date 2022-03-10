using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Models.View_Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Mobile { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }
    }
}
