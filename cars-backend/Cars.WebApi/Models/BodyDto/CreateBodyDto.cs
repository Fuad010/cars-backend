using AutoMapper;
using Cars.Application.CarBodies.Commands.CreateBody;
using Cars.Application.Common.Mappings;
using System;

namespace Cars.WebApi.Models.BodyDto
{
    public class CreateBodyDto : IMapWith<CreateBodyCommand>
    {
        public Guid Id { get; set; }
        public string BodyType { get; set; }
    
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBodyDto, CreateBodyDto>()
                .ForMember(bodyCommand => bodyCommand.BodyType,
                    opt => opt.MapFrom(bodyDto=>bodyDto.BodyType));
        }
    }
}
