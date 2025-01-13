using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Domain.Car;
using Notes.Persistance.EntityTypeConfigurations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Note> Notes { get; set; }
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
            builder.ApplyConfiguration(new NoteConfiguration());
        }
    }
}

