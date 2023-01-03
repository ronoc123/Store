using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=storedb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Product> Products  { get; set; }

    }
}