using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarList
{
    public class CarListVm
    {
        public IList<CarLookupDto> Cars { get; set; }
    }
}
