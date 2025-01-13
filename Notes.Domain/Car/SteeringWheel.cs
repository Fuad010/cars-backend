using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Car
{
    public class SteeringWheel
    {
        public Guid Id { get; set; }
        public string SteeringWheelType { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
