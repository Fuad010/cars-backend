using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Cars.Application.Common.Exceptions;
using Cars.Application.Interfaces;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarDetails
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
                .Include(car => car.Images)
                .Include(car => car.Body)
                .Include(car => car.Brand)
                .Include(car => car.Box)
                .Include(car => car.SteeringWheel)
                .Include(car => car.CarColor)
                .AsNoTracking()
                .FirstOrDefaultAsync(car => car.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Car), request.Id);
            }

            return _mapper.Map<CarDetailsVm>(entity);
        }
    }
}
