using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBrands.Commands.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;

        public CreateBrandCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brand
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
            };

            await _dbContext.Brands.AddAsync(brand, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return brand.Id;
        }
    }
}
