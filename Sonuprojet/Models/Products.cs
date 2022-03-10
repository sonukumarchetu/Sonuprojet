using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public string Decription { get; set; }
        public Category Category { get; set; }
        public bool Isative { get; set; }

    }
}
