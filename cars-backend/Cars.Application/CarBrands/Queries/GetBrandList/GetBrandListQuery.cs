using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBrands.Queries.GetBrandList
{
    public class GetBrandListQuery : IRequest<BrandListVm>
    {
    }
}
