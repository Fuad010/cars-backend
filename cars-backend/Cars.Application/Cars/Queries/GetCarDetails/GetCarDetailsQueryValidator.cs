using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarDetails
{
    public class GetCarDetailsQueryValidator : AbstractValidator<GetCarDetailsQuery>
    {
        public GetCarDetailsQueryValidator()
        {

            RuleFor(car => car.Id).NotEqual(Guid.Empty);
            //RuleFor(car => car.UserId).NotEqual(Guid.Empty);
        }
    }
}
