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

namespace Cars.Application.CarBodies.Queries.GetBodyList
{
    public class GetBodyListQueryHandler
        : IRequestHandler<GetBodyListQuery, BodyListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBodyListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BodyListVm> Handle(GetBodyListQuery request, CancellationToken cancellationToken)
        {
            var bodyQuery = await _dbContext.Bodies
                .ProjectTo<BodyLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BodyListVm { Bodies = bodyQuery };
        }
    }
}
