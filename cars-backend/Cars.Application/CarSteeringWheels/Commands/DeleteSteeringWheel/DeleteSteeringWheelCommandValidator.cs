using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Commands.DeleteSteeringWheel
{
    public class DeleteSteeringWheelCommandValidator : AbstractValidator<DeleteSteeringWheelCommand>
    {
        public DeleteSteeringWheelCommandValidator()
        {
            RuleFor(x=>x.Id).NotEqual(Guid.Empty);
        }
    }
}
