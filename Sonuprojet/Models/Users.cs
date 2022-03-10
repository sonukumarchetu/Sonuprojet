using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public bool Isveryfied { get; set; }
        public bool Isative { get; set; }
    }
}
