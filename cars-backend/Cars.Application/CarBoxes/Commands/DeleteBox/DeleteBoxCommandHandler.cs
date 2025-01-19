using Cars.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.DeleteBox
{
    public class DeleteBoxCommandHandler : IRequestHandler<DeleteBoxCommand>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteBoxCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBoxCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Boxes
                .FirstOrDefaultAsync(box => box.Id == request.Id, cancellationToken);

            _dbContext.Boxes.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
