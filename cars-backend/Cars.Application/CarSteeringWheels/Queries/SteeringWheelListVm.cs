using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Queries
{
    public class SteeringWheelListVm 
    {
        public IList<SteeringWheelLookupDto> SteeringWheels { get; set; }
    }
}
