using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Domain.Car
{
    public class Car
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Guid CarColorId { get; set; }
        public Guid BoxId { get; set; }
        public Guid SteeringWheelId { get; set; }
        public Guid BodyId { get; set; }
        public ICollection<CarImage> Images { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
