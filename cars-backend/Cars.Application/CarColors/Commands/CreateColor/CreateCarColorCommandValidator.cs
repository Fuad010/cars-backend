using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Commands.CreateColor
{
    public class CreateCarColorCommandValidator : AbstractValidator<CreateCarColorCommand>
    {
        public CreateCarColorCommandValidator()
        {
            RuleFor(x=>x.ColorName).NotEmpty();
        }
    }
}
