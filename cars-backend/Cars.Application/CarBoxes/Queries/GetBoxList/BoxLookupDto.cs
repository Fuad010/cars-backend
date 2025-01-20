using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBoxes.Queries.GetBoxList
{
    public class BoxLookupDto : IMapWith<Box>
    {
        public Guid Id { get; set; }
        public string BoxType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Box, BoxLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(box => box.Id))
                .ForMember(dto => dto.BoxType, opt => opt.MapFrom(box => box.BoxType));
        }
    }
}
