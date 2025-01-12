using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Queries.GetCarList
{
    public class CarListVm
    {
        public IList<CarLookupDto> Cars { get; set; }
    }
}
