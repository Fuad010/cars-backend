using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.CreateBox
{
    public class CreateBoxCommandValidator : AbstractValidator<CreateBoxCommand>
    {
        public CreateBoxCommandValidator()
        {
            RuleFor(x => x.BoxType).NotEmpty();
        }
    }
}
