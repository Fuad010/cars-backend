using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBrands.Commands.CreateBrand
{
    public class CreateBrandCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
