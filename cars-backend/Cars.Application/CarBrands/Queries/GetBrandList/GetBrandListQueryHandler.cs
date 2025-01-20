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

namespace Cars.Application.CarBrands.Queries.GetBrandList
{
    public class GetCarColorListQueryHandler 
        : IRequestHandler<GetBrandListQuery, BrandListVm>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCarColorListQueryHandler(IAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BrandListVm> Handle(GetBrandListQuery request, CancellationToken cancellationToken)
        {
            var brandQuery = await _dbContext.Brands
                .ProjectTo<BrandLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        
            return new BrandListVm { Brands = brandQuery };
        }
    }
}
