using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Car
{
    public class Car
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }

        public Guid ColorId { get; set; }
        public CarColor CarColor { get; set; }

        public Guid BoxId { get; set; }
        public Box Box { get; set; }

        public Guid SteeringWheelId { get; set; }
        public SteeringWheel SteeringWheel { get; set; }
        
        public Guid BodyId { get; set; }
        public Body Body { get; set; }

        public ICollection<CarImage> Images { get; set; }

        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
