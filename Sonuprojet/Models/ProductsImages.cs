using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sonuprojet.Models
{
    public class ProductsImages
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public int Type { get; set; }
        public Products Products { get; set; }
        public bool Isative { get; set; }
    }
}
