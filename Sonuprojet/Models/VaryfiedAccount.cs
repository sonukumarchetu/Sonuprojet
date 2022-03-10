using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Models
{
    public class VaryfiedAccount
    {
        [Key]
        public int Id { get; set; }
        public string Otp { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
    }
}
