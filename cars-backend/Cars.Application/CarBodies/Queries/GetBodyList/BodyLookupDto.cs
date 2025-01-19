using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBodies.Queries.GetBodyList
{
    public class BodyLookupDto : IMapWith<Body>
    {
        public Guid Id { get; set; }
        public string BodyType { get; set; }
    
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Body, BodyLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(body => body.Id))
                .ForMember(dto => dto.BodyType, opt => opt.MapFrom(body => body.BodyType));
        }
    }
}
