using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Cars.Application.Cars.Commands.CreaeteCar
{
        public class CreateCarCommand : IRequest<Guid>
        {
            public Guid UserId { get; set; }
            public string Name { get; set; }

            public Guid BrandId { get; set; }
            public Guid ColorId { get; set; }
            public Guid BoxId { get; set; }
            public Guid SteeringWheelId { get; set; }
            public Guid BodyId { get; set; }

            public List<IFormFile> Images { get; set; }

            public string Engine { get; set; }
            public int Mileage { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }
        }
}
