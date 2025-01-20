using Cars.Domain.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Queries
{
    public class GetSteeringWheelListQuery : IRequest<SteeringWheelListVm>
    {
    }
}
