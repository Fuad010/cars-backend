using MediatR;
using Notes.Application.Interfaces;
using Notes.Application.Notes.Commands.CreateNote;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Commands.CreaeteCar
{
    public class CreateCarCommandHandler 
        : IRequestHandler<CreateCarCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;

        public CreateCarCommandHandler(IAppDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = new Car
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                Name = request.Name,
                BrandId = request.BrandId,
                ColorId = request.ColorId,
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

            await _dbContext.Cars.AddAsync(car, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return car.Id;
        }
    }
}
