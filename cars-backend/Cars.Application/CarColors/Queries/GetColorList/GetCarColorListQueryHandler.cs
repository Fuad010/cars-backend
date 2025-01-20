using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cars.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Queries.GetColorList
{
    public class GetCarColorListQueryHandler 
        : IRequestHandler<GetCarColorListQuery, CarColorListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarColorListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CarColorListVm> Handle(GetCarColorListQuery request, CancellationToken cancellationToken)
        {
            var carColorQuery = await _dbContext.CarColors
                .ProjectTo<CarColorLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        
            return new CarColorListVm { CarColors = carColorQuery };
        }
    }
}
