using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Car
{
    public class Box
    {
        public Guid Id { get; set; }
        public string BoxType { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
