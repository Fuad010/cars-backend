using MediatR;
using Cars.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cars.Domain.Car;

namespace Cars.Application.Cars.Commands.CreaeteCar
{
    public class CreateCarCommandHandler 
        : IRequestHandler<CreateCarCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IFileService _fileService;

        public CreateCarCommandHandler(IAppDbContext dbContext, IFileService fileService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
        }
        public async Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                UserId = null,
                Name = request.Name,
                BrandId = request.BrandId,
                CarColorId = request.ColorId,
                BoxId = request.BoxId,
                SteeringWheelId = request.SteeringWheelId,
                BodyId = request.BodyId,
                Engine = request.Engine,
                Mileage = request.Mileage,
                Year = request.Year,
                Price = request.Price,
                CreationDate = DateTime.Now,
                Images = new List<CarImage>(),
                EditDate = null
            };

            if (request.Images != null && request.Images.Any()) 
            {
                foreach (var image in request.Images)
                {
                    var imagePath = await _fileService.SaveFileAsync(image);
                    
                    car.Images.Add(new CarImage 
                        { 
                            ImageUrl = imagePath 
                        }
                    );
                }
            }

            await _dbContext.Cars.AddAsync(car, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            //try
            //{
            //    await _dbContext.SaveChangesAsync(cancellationToken);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    throw;
            //}

            return car.Id;
        }
    }
}
