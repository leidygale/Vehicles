using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class DataContext : DbContext    //La clase hereda de DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)     //ctor y tab tab se crea options es un nombre cualquiera
        {
        }

        public DbSet<VehicleType> VehicleTypes { get; set; } //el nombre de la coleccion se le adiciona s

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();

        }
    }
}
