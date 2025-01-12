using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Queries.GetCarDetails
{
    public class GetCarDetailsQueryValidator : AbstractValidator<GetCarDetailsQuery>
    {
        public GetCarDetailsQueryValidator()
        {

            RuleFor(note => note.Id).NotEqual(Guid.Empty);
            //RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
    }
}
