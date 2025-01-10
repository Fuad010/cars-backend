using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Car
{
    public class CarImage
    {
        public Guid CarId { get; set; }
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public Car Car { get; set; }
    }
}
