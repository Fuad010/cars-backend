using AutoMapper;
using Cars.Application.CarColors.Commands.CreateColor;
using Cars.Application.Cars.Commands.CreaeteCar;
using Cars.Application.Common.Mappings;
using System;

namespace Cars.WebApi.Models.CarColorDto
{
    public class CreateCarColorDto : IMapWith<CreateCarColorDto>
    {
        public Guid Id { get; set; }
        public string ColorName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCarColorDto, CreateCarColorCommand>()
                .ForMember(colorCommand => colorCommand.ColorName,
                opt => opt.MapFrom(colorDto => colorDto.ColorName));
        }
    }
}
