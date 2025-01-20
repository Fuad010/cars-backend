using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Queries
{
    public class GetSteeringWheelListQueryHandler : IRequestHandler<GetSteeringWheelListQuery, SteeringWheelListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetSteeringWheelListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<SteeringWheelListVm> Handle(GetSteeringWheelListQuery request, CancellationToken cancellationToken)
        {
            var steeringWheelQuery = await _dbContext.SteeringWheels
                .ProjectTo<SteeringWheelLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new SteeringWheelListVm { SteeringWheels = steeringWheelQuery };
        }
    }
}
