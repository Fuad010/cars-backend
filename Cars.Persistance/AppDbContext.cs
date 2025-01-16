using Microsoft.EntityFrameworkCore;
using Cars.Application.Interfaces;
using Cars.Domain;
using Cars.Domain.Car;
using Cars.Persistance.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistance
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<SteeringWheel> SteeringWheels { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new CarImageConfiguration());
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new CarColorConfiguration());
            builder.ApplyConfiguration(new BodyConfiguration());
            builder.ApplyConfiguration(new BoxConfiguration());
            builder.ApplyConfiguration(new SteeringWheelConfiguration());
        }
    }
}

