using Microsoft.EntityFrameworkCore;
using NWEB.Pratice.T05.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWEB.Pratice.T05.Core.Model
{
    public class FlowerContext : DbContext
    {
        public FlowerContext(DbContextOptions<FlowerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Flower> Flowers { get; set; }
    }
}
