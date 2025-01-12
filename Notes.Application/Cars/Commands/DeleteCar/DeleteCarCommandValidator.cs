using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Commands.DeleteCar
{
    public class DeleteCarCommandValidator : AbstractValidator<DeleteCarCommand>
    {
        public DeleteCarCommandValidator()
        {
            RuleFor(deleteCarCommand => deleteCarCommand.Id).NotEqual(Guid.Empty);
            //RuleFor(deleteCarCommand =>  deleteCarCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
