using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exceptions;
using Notes.Application.Interfaces;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Commands.UpdateCar
{
    public class UpdateCarCommandHandler
        : IRequestHandler<UpdateCarCommand>
    {
        private readonly IAppDbContext _dbContext;
        public UpdateCarCommandHandler(IAppDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(UpdateCarCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cars.FirstOrDefaultAsync(car =>
            car.Id == request.Id, cancellationToken);

            if (entity == null || entity.UserId != request.UserId)
            {
                throw new NotFoundException(nameof(Car), request.Id);
            }

            entity.Name = request.Name;
            entity.BrandId = request.BrandId;
            entity.ColorId = request.ColorId;
            entity.SteeringWheelId = request.SteeringWheelId;
            entity.BodyId = request.BodyId;
            entity.Engine = request.Engine;
            entity.Mileage = request.Mileage;
            entity.Year = request.Year;
            entity.Price = request.Price;

            if (request.Images != null)
            {
                entity.Images = request.Images;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
