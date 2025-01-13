using AutoMapper;
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

namespace Notes.Application.Cars.Queries.GetCarDetails
{
    public class GetCarDetailsQueryHandler
           : IRequestHandler<GetCarDetailsQuery, CarDetailsVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarDetailsQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CarDetailsVm> Handle(GetCarDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cars
                .FirstOrDefaultAsync(car => car.Id == request.Id, cancellationToken);

            //if (entity == null || entity.UserId != request.UserId)
            //{
            //    throw new NotFoundException(nameof(Car), request.Id);
            //}

            var brand = await _dbContext.Brands
                .FirstOrDefaultAsync(b => b.Id == entity.BrandId, cancellationToken);

            var carColor = await _dbContext.CarColors
                .FirstOrDefaultAsync(c => c.Id == entity.CarColorId, cancellationToken);

            var box = await _dbContext.Boxes
                .FirstOrDefaultAsync(b => b.Id == entity.BoxId, cancellationToken);

            var steeringWheel = await _dbContext.SteeringWheels
                .FirstOrDefaultAsync(s => s.Id == entity.SteeringWheelId, cancellationToken);

            var body = await _dbContext.Bodies
                .FirstOrDefaultAsync(b => b.Id == entity.BodyId, cancellationToken);

            return _mapper.Map<CarDetailsVm>(new CarDetailsVm
            {
                Id = entity.Id,
                Name = entity.Name,
                BrandName = brand?.Name, 
                ColorName = carColor?.ColorName,
                BoxName = box?.BoxType,
                SteeringWheelName = steeringWheel?.SteeringWheelType,
                BodyName = body?.BodyType,
                Engine = entity.Engine,
                Mileage = entity.Mileage,
                Year = entity.Year,
                Price = entity.Price
            });
        }
    }
}
