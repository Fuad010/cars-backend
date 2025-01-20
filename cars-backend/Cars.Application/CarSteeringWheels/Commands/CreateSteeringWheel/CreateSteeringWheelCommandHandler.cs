using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Commands.CreateSteeringWheel
{
    public class CreateSteeringWheelCommandHandler : IRequestHandler<CreateSteeringWheelCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;

        public CreateSteeringWheelCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSteeringWheelCommand request, CancellationToken cancellationToken)
        {
            var entity = new SteeringWheel
            {
                Id = Guid.NewGuid(),
                SteeringWheelType = request.SteeringWheelType,
            };

            await _dbContext.SteeringWheels.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return entity.Id;
        }
    }
}
