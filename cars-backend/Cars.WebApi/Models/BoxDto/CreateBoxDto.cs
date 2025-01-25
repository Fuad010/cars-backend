using AutoMapper;
using Cars.Application.CarBoxes.Commands.CreateBox;
using Cars.Application.Common.Mappings;
using System;

namespace Cars.WebApi.Models.BoxDto
{
    public class CreateBoxDto : IMapWith<CreateBoxDto>
    {
        public string BoxType { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<CreateBoxDto, CreateBoxCommand>()
                .ForMember(boxCommand => boxCommand.BoxType,
                opt => opt.MapFrom(boxDto =>  boxDto.BoxType));
        }
    }
}
