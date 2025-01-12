using MediatR;
using Notes.Application.Common.Exceptions;
using Notes.Application.Interfaces;
using Notes.Application.Notes.Commands.DeleteNote;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Commands.DeleteCar
{
    public class DeleteCarCommandHandler
        : IRequestHandler<DeleteCarCommand>
    {
        private readonly IAppDbContext _dbContext;
        public DeleteCarCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(DeleteCarCommand request,
        CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Cars
                .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null || entity.UserId != request.UserId) 
            {
                throw new NotFoundException(nameof(Car), request.Id);
            }

            _dbContext.Cars.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
}
