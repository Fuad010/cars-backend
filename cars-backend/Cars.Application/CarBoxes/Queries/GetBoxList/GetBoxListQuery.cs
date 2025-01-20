using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Queries.GetBoxList
{
    public class GetBoxListQuery : IRequest<BoxListVm>
    {
    }
}
