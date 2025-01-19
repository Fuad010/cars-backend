using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.DeleteBody
{
    public class DeleteBodyValidator : AbstractValidator<DeleteBodyCommand>
    {
        public DeleteBodyValidator()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
        }
    }
}
