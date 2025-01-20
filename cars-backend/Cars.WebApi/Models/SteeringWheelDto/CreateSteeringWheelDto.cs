using AutoMapper;
using Cars.Application.CarSteeringWheels.Commands.CreateSteeringWheel;
using Cars.Application.Common.Mappings;
using System;

namespace Cars.WebApi.Models.SteeringWheelDto
{
    public class CreateSteeringWheelDto : IMapWith<CreateSteeringWheelDto>
    {
        public Guid Id { get; set; }
        public string SteeringWheelType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateSteeringWheelDto, CreateSteeringWheelCommand>()
                .ForMember(wheelCommand => wheelCommand.SteeringWheelType,
                opt => opt.MapFrom(wheelDto=>wheelDto.SteeringWheelType));
        }
    }
}
