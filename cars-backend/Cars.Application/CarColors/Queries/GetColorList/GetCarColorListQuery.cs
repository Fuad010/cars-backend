using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Queries.GetColorList
{
    public class GetCarColorListQuery : IRequest<CarColorListVm>
    {
    }
}
