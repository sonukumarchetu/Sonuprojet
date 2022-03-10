using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sonuprojet.Models
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options) :
            base(options) { }
        public DbSet<Users> users { get; set; }
        public DbSet<VaryfiedAccount> varyfiedAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsImages> ProductsImages { get; set; }
    }
}
