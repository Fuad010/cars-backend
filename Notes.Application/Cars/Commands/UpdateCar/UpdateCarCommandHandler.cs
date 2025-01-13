using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exceptions;
using Notes.Application.Common.Interfaces;
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
        private readonly IFileService _fileService;
        public UpdateCarCommandHandler(IAppDbContext dbContext, IFileService fileService) 
        {
            _dbContext = dbContext;
            _fileService = fileService;
        
        }
        public async Task<Unit> Handle(UpdateCarCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cars.FirstOrDefaultAsync(car =>
            car.Id == request.Id, cancellationToken);

            //if (entity == null || entity.UserId != request.UserId)
            //{
            //    throw new NotFoundException(nameof(Car), request.Id);
            //}

            entity.Name = request.Name;
            entity.BrandId = request.BrandId;
            entity.CarColorId = request.ColorId;
            entity.SteeringWheelId = request.SteeringWheelId;
            entity.BodyId = request.BodyId;
            entity.Engine = request.Engine;
            entity.Mileage = request.Mileage;
            entity.Year = request.Year;
            entity.Price = request.Price;

            if (request.Images != null && request.Images.Any())
            {
                var oldImages = await _dbContext.CarImages
                    .Where(img=>img.CarId == entity.Id)
                    .ToListAsync(cancellationToken);

                foreach(var oldImage in oldImages)
                {
                    await _fileService.DeleteFileAsync(oldImage.ImageUrl);
                    _dbContext.CarImages.Remove(oldImage);
                }
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
