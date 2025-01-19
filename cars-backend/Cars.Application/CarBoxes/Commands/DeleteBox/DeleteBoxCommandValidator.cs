using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.DeleteBox
{
    public class DeleteBoxCommandValidator : AbstractValidator<DeleteBoxCommand>
    {
        public DeleteBoxCommandValidator() 
        {
            RuleFor(x=>x.Id).NotEqual(Guid.Empty);
        }
    }
}
