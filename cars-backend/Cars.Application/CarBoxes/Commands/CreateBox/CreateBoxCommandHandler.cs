using Cars.Application.Interfaces;
using Cars.Domain.Car;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.CreateBox
{
    public class CreateBoxCommandHandler 
        : IRequestHandler<CreateBoxCommand, Guid>
    {
        private readonly IAppDbContext _dbContext;
        public CreateBoxCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateBoxCommand request, CancellationToken cancellationToken)
        {
            var box = new Box
            {
                Id = Guid.NewGuid(),
                BoxType = request.BoxType,
            };

            await _dbContext.Boxes.AddAsync(box, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return box.Id;
        }

    }
}
