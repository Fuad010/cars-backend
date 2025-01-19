using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.CreateBody
{
    public class CreateBodyCommandValidator : AbstractValidator<CreateBodyCommand>
    {
        public CreateBodyCommandValidator()
        {
            RuleFor(x => x.BodyType).NotEmpty();
        }
    }
}
