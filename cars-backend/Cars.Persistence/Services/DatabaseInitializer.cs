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
                _dbContext.Cars.AddRange(new List<Car> {
                    new Car
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
                    },
                    new Car
                    {
                        Id = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acc"),
                        Name = "Prius Camaro",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "4.8L I5",
                        Mileage = 15000,
                        Year = 2011,
                        Price = 30000,
                        Images = new List<CarImage>
                        {
                            new ()
                            {
                                Id = Guid.NewGuid(),
                                CarId = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acc"),
                                ImageUrl = @"wwwroot\images\953bf1a4-ad84-4d46-be0f-e7da19e96ddf.jpg"
                            },
                            new ()
                            {
                                Id = Guid.NewGuid(),
                                CarId = Guid.Parse("c1c4645c-6881-4be4-9a93-c354a34a9acc"),
                                ImageUrl = @"wwwroot\images\959c4ec5-624c-48d5-b88a-c2c5258dc8d2.jpg"
                            },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null,
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "530",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"), 
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "2.0L I4",
                        Mileage = 22000,
                        Year = 2022,
                        Price = 45000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\22e9c230-ac18-4ab8-b434-47a0f4494ae8.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "X5",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"), 
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"), 
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"), 
                        Engine = "3.0L I6",
                        Mileage = 18000,
                        Year = 2020,
                        Price = 65000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\6636e71f-57de-4d5d-bc35-a81299639e24.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Uni-V iDD",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "1.5L Turbo",
                        Mileage = 12000,
                        Year = 2023,
                        Price = 23000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\f14524c4-49e5-40e5-a53a-0cd3489cc9b7.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Fusion",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"), 
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"), 
                        Engine = "2.5L I4",
                        Mileage = 40000,
                        Year = 2018,
                        Price = 18000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\5c01655c-adc3-4be9-8987-4e07d76741e4.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "(VAZ) Niva",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "1.7L I4",
                        Mileage = 80000,
                        Year = 2015,
                        Price = 5000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\0c438680-d72b-4ffb-8733-4ae009e41742.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "LADA (VAZ) 1 Niva",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "1.7L I4",
                        Mileage = 85000,
                        Year = 2013,
                        Price = 5200,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\b79736e0-92a1-4fc2-aca4-ec3af031d3d6.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lada",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "1.6L I4",
                        Mileage = 45000,
                        Year = 2017,
                        Price = 7000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\f0d56cff-51f8-4759-87ef-117de742516f.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Aventador",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "6.5L V12",
                        Mileage = 5000,
                        Year = 2021,
                        Price = 300000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\499053cf-691d-4bdc-bf92-0f0ebf213fdb.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "L7",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "Electric",
                        Mileage = 10000,
                        Year = 2022,
                        Price = 70000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\0246e77c-d21e-4e0d-955e-7bf8eadccf11.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pathfinder",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "3.5L V6",
                        Mileage = 20000,
                        Year = 2021,
                        Price = 45000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\651d359e-6a2e-4b00-a48d-05a9dbfa6351.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "Highlander",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "3.5L V6",
                        Mileage = 15000,
                        Year = 2020,
                        Price = 42000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\ToyotaHighlander.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    },
                    new Car
                    {
                        Id = Guid.NewGuid(),
                        Name = "RAV4",
                        BrandId = Guid.Parse("d2fdcf17-7301-491e-a549-7885ebd99ad4"),
                        CarColorId = Guid.Parse("0ec4b2f6-2a9a-4647-9b13-a390c23e35da"),
                        BoxId = Guid.Parse("a8c6600c-dc32-45a0-8a3f-280b907bbc21"),
                        SteeringWheelId = Guid.Parse("50c97d1e-0445-46eb-b9d9-80b6af93f147"),
                        BodyId = Guid.Parse("256f454b-5762-4d96-81c3-c0d26350a09e"),
                        Engine = "2.5L I4",
                        Mileage = 12000,
                        Year = 2022,
                        Price = 30000,
                        Images = new List<CarImage>
                        {
                            new CarImage { Id = Guid.NewGuid(), CarId = Guid.NewGuid(), ImageUrl = @"wwwroot\images\70443509-de8c-4f22-9e63-f91c908cc11b.jpg" },
                        },
                        CreationDate = DateTime.Now,
                        EditDate = null
                    }
                });

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
