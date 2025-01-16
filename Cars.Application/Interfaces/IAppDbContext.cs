using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Cars.Domain;
using Cars.Domain.Car;

namespace Cars.Application.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Car> Cars { get; set; }               
        DbSet<Brand> Brands { get; set; }           
        DbSet<Box> Boxes { get; set; }           
        DbSet<CarColor> CarColors { get; set; }      
        DbSet<SteeringWheel> SteeringWheels { get; set; }
        DbSet<Body> Bodies { get; set; }
        DbSet<CarImage> CarImages { get; set; }       
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
