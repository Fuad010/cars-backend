using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarSteeringWheels.Queries
{
    public class SteeringWheelLookupDto : IMapWith<SteeringWheel>
    {
        public Guid Id { get; set; }
        public string SteeringWheel { get; set; }

        public void Mappnig(Profile profile)
        {
            profile.CreateMap<SteeringWheel, SteeringWheelLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(wheel => wheel.Id))
                .ForMember(dto => dto.SteeringWheel, opt => opt.MapFrom(wheel => wheel.SteeringWheelType));
        }
    }
}
