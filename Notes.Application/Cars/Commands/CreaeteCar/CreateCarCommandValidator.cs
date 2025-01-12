using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Commands.CreaeteCar
{
    public class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommandValidator()
        {
            /*if we need auth*/
            //RuleFor(x => x.UserId).NotEmpty();

            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);

            RuleFor(x => x.BrandId).NotEmpty();

            RuleFor(x => x.ColorId).NotEmpty();

            RuleFor(x => x.BoxId).NotEmpty();

            RuleFor(x => x.SteeringWheelId).NotEmpty();

            RuleFor(x => x.BodyId).NotEmpty();

            RuleFor(x => x.Engine).NotEmpty();

            RuleFor(x => x.Mileage).GreaterThanOrEqualTo(0);

            RuleFor(x => x.Price).GreaterThan(0);
        }
    }
}
