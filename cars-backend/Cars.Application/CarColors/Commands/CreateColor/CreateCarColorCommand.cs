using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Commands.CreateColor
{
    public class CreateCarColorCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string ColorName { get; set; }
    }
}
