using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class context:DbContext
    {

        public context()
        {
            
        }
        public context(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=YyEtic; Integrated Security=True; TrustServerCertificate=True");
        }

        DbSet<AppUser> AppUsers {  get; set; }
        DbSet<Basket> Basket {  get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
