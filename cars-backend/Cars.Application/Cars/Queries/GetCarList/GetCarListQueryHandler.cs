using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Cars.Application.Interfaces;
using Cars.Application.Cars.Queries.GetCarList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarList
{
    public class GetCarListQueryHandler
        : IRequestHandler<GetCarListQuery, CarListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CarListVm> Handle(GetCarListQuery request,
            CancellationToken cancellationToken)
        {
            var carsQuery = await _dbContext.Cars
                .Include(car => car.Images)
                .ProjectTo<CarLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new CarListVm { Cars = carsQuery };
        }
    }
}
