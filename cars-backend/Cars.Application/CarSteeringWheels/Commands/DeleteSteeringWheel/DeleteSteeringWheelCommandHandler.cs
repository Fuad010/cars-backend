using Cars.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Commands.DeleteSteeringWheel
{
    public class DeleteSteeringWheelCommandHandler : IRequestHandler<DeleteSteeringWheelCommand>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteSteeringWheelCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSteeringWheelCommand request, CancellationToken cancellation)
        {
            var entity = await _dbContext.SteeringWheels
                .FirstOrDefaultAsync(wheel=>wheel.Id == request.Id, cancellation);

            _dbContext.SteeringWheels.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellation);

            return Unit.Value;
        }
    }
}
