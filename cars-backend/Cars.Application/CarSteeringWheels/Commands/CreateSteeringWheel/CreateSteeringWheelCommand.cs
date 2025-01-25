using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Commands.CreateSteeringWheel
{
    public class CreateSteeringWheelCommand : IRequest<Guid>
    {
        public string SteeringWheelType { get; set; }
    }
}
