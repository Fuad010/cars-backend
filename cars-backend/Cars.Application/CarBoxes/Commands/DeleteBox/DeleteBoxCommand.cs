using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.DeleteBox
{
    public class DeleteBoxCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
