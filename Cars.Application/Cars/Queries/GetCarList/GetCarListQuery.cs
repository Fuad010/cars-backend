using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarList
{
    public class GetCarListQuery : IRequest<CarListVm>
    {
            public Guid UserId { get; set; }
    }
}
