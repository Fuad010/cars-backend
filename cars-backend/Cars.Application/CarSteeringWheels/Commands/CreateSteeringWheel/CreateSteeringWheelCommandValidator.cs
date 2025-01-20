using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Commands.CreateSteeringWheel
{
    public class CreateSteeringWheelCommandValidator : AbstractValidator<CreateSteeringWheelCommand>
    {
        public CreateSteeringWheelCommandValidator()
        {
            RuleFor(x=>x.SteeringWheelType).NotEmpty();
        }
    }
}
