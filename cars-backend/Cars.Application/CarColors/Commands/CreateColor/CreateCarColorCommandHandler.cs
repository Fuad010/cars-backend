using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Commands.CreateColor
{
    public class CreateCarColorCommandHandler : IRequestHandler<CreateCarColorCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;

        public CreateCarColorCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCarColorCommand request, CancellationToken cancellationToken)
        {
            var carColor = new CarColor
            {
                Id = Guid.NewGuid(),
                ColorName = request.ColorName,
            };

            await _dbContext.CarColors.AddAsync(carColor, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return carColor.Id;
        }
    }
}
