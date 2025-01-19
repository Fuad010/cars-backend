using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Commands.DeleteBody
{
    public class DeleteBodyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
