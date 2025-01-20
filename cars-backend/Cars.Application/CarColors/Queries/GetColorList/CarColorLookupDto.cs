using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarColors.Queries.GetColorList
{
    public class CarColorLookupDto : IMapWith<CarColor>
    {
        public Guid Id { get; set; }
        public string ColorName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CarColor, CarColorLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(color => color.Id))
                .ForMember(dto => dto.ColorName, opt => opt.MapFrom(color => color.ColorName));
        }
    }
}
