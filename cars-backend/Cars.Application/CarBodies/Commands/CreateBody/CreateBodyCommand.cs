using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.CreateBody
{
    public class CreateBodyCommand : IRequest<Guid>
    {
        public string BodyType { get; set; }
    }
}
