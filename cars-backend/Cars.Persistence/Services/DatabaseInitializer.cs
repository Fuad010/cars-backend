using Cars.Application.Interfaces;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.Services
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
                    new Brand { Id = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"), Name = "Toyota" },
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
                    new CarColor { Id = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"), ColorName = "Black" },
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
                    new Box { Id = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"), BoxType = "CVT" },
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
                    new SteeringWheel { Id = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"), SteeringWheelType = "Center" },
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
                    new Body { Id = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"), BodyType = "Hatchback" },
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

            if (!_dbContext.Cars.Any())
            {
                _dbContext.Cars.Add(new Car
                {
                    Id = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acb"),
                    Name = "Prius",
                    BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                    CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                    BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                    SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                    BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                    Engine = "1.8L I4",
                    Mileage = 10000,
                    Year = 2021,
                    Price = 20000,
                    Images = new List<CarImage>
                    {
                        new ()
                        {
                            Id = Guid.NewGuid(),
                            CarId = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acb"),
                            ImageUrl = @"wwwroot\images\953bf1a4-ad84-4d46-be0f-e7da19e96ddf.jpg"
                        },
                        new ()
                        {
                            Id = Guid.NewGuid(),
                            CarId = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acb"),
                            ImageUrl = @"wwwroot\images\959c4ec5-624c-48d5-b88a-c2c5258dc8d2.jpg"
                        },
                    },
                    CreationDate = DateTime.Now,
                    EditDate = null,
                });

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
