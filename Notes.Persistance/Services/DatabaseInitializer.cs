using Notes.Application.Interfaces;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance.Services
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly AppDbContext _dbContext;
        public DatabaseInitializer(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Initialize()
        {
            if (!_dbContext.Brands.Any())
            {
                _dbContext.Brands.AddRange(new List<Brand>
                {
                    new Brand { Id = Guid.NewGuid(), Name = "Toyota" },
                    new Brand { Id = Guid.NewGuid(), Name = "Ford" },
                    new Brand { Id = Guid.NewGuid(), Name = "Kia" },
                    new Brand { Id = Guid.NewGuid(), Name = "Hyundai" },
                    new Brand { Id = Guid.NewGuid(), Name = "Tesla" },
                    new Brand { Id = Guid.NewGuid(), Name = "Mercedes" },
                    new Brand { Id = Guid.NewGuid(), Name = "BMW" },
                    new Brand { Id = Guid.NewGuid(), Name = "Nissan" },
                    new Brand { Id = Guid.NewGuid(), Name = "Land Rover" },
                    new Brand { Id = Guid.NewGuid(), Name = "Audi" },
                    new Brand { Id = Guid.NewGuid(), Name = "Lexud" }
                });
            }

            if (!_dbContext.CarColors.Any())
            {
                _dbContext.CarColors.AddRange(new List<CarColor>
                {
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Black" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "White" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Silver" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Gray" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Green" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Yellow" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Orange" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Purple" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Brown" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Beige" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Pink" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Gold" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Copper" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Turquoise" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Bronze" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Teal" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Charcoal" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Ivory" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Mint" }
                });
            }

            if (!_dbContext.Boxes.Any())
            {
                _dbContext.Boxes.AddRange(new List<Box>
                {
                    new Box { Id = Guid.NewGuid(), BoxType = "CVT" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Semi-Automatic" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Dual-Clutch" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Dual-Clutch Automatic" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Electric" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Tiptronic" },
                    new Box { Id = Guid.NewGuid(), BoxType = "RWD" },
                    new Box { Id = Guid.NewGuid(), BoxType = "AWD" }
                });
            }

            if (!_dbContext.SteeringWheels.Any())
            {
                _dbContext.SteeringWheels.AddRange(new List<SteeringWheel>
                {
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Center" }, 
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Adaptive" }, 
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Fixed" },
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Tilt" },
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Telescopic" },
                });
            }

            if (!_dbContext.Bodies.Any())
            {
                _dbContext.Bodies.AddRange(new List<Body>
                {
                    new Body { Id = Guid.NewGuid(), BodyType = "Hatchback" },
                    new Body { Id = Guid.NewGuid(), BodyType = "Coupe" }, 
                    new Body { Id = Guid.NewGuid(), BodyType = "Convertible" },
                    new Body { Id = Guid.NewGuid(), BodyType = "Wagon" }, 
                    new Body { Id = Guid.NewGuid(), BodyType = "Pickup" },
                    new Body { Id = Guid.NewGuid(), BodyType = "Minivan" }, 
                    new Body { Id = Guid.NewGuid(), BodyType = "Crossover" },
                    new Body { Id = Guid.NewGuid(), BodyType = "Roadster" }, 
                    new Body { Id = Guid.NewGuid(), BodyType = "Microcar" },
                    new Body { Id = Guid.NewGuid(), BodyType = "Limousine" }, 
                });
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
