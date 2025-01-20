using Cars.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Commands.DeleteColor
{
    public class DeleteCarColorCommandHandler : IRequestHandler<DeleteCarColorCommand>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteCarColorCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCarColorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.CarColors
                .FirstOrDefaultAsync(color => color.Id == request.Id, cancellationToken);

            _dbContext.CarColors .Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
