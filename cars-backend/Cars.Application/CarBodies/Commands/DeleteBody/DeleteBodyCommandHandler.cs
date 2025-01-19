using Cars.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.DeleteBody
{
    public class DeleteBodyCommandHandler 
        : IRequestHandler<DeleteBodyCommand>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteBodyCommandHandler(IAppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public async Task<Unit> Handle(DeleteBodyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Bodies
                .FindAsync(new object[] { request.Id }, cancellationToken);
            //  .FirstOrDefaultAsync(body => body.Id == request.Id, cancellationToken);

            _dbContext.Bodies.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
