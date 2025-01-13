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
                    new Brand { Id = Guid.NewGuid(), Name = "Ford" }
                });
            }

            if (!_dbContext.CarColors.Any())
            {
                _dbContext.CarColors.AddRange(new List<CarColor>
                {
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Red" },
                    new CarColor { Id = Guid.NewGuid(), ColorName = "Blue" }
                });
            }

            if (!_dbContext.Boxes.Any())
            {
                _dbContext.Boxes.AddRange(new List<Box>
                {
                    new Box { Id = Guid.NewGuid(), BoxType = "Automatic" },
                    new Box { Id = Guid.NewGuid(), BoxType = "Manual" }
                });
            }

            if (!_dbContext.SteeringWheels.Any())
            {
                _dbContext.SteeringWheels.AddRange(new List<SteeringWheel>
                {
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Left" },
                    new SteeringWheel { Id = Guid.NewGuid(), SteeringWheelType = "Right" }
                });
            }

            if (!_dbContext.Bodies.Any())
            {
                _dbContext.Bodies.AddRange(new List<Body>
                {
                    new Body { Id = Guid.NewGuid(), BodyType = "Sedan" },
                    new Body { Id = Guid.NewGuid(), BodyType = "SUV" }
                });
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
