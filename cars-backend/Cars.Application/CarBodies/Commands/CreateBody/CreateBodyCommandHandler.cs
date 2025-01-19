using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.CreateBody
{
    public class CreateBodyCommandHandler
        : IRequestHandler<CreateBodyCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;

        public CreateBodyCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateBodyCommand request, CancellationToken cancellationToken)
        {
            var body = new Body
            {
                Id = Guid.NewGuid(),
                BodyType = request.BodyType
            };

            await _dbContext.Bodies.AddAsync(body, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return body.Id;
        }
    }
}
