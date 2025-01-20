using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cars.Application.CarBodies.Queries.GetBodyList;
using Cars.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Queries.GetBoxList
{
    public class GetBoxListQueryHandler 
        : IRequestHandler<GetBoxListQuery, BoxListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBoxListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BoxListVm> Handle(GetBoxListQuery request, CancellationToken cancellationToken)
        {
            var boxQuery = await _dbContext.Boxes
                .ProjectTo<BoxLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BoxListVm { Boxes = boxQuery };
        }
    }
}
