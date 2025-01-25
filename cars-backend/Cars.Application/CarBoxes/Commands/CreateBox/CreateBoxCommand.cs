using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Commands.CreateBox
{
    public class CreateBoxCommand : IRequest<Guid>
    {
        public string BoxType { get; set; }
    }
}
