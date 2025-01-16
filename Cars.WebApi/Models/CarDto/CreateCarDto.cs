using AutoMapper;
using Microsoft.AspNetCore.Http;
using Cars.Application.Cars.Commands.CreaeteCar;
using Cars.Application.Common.Mappings;
using System.Collections.Generic;
using System;

namespace Cars.WebApi.Models.CarDto
{
    public class CreateCarDto : IMapWith<CreateCarCommand>
    {
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public Guid ColorId { get; set; }
        public Guid BoxId { get; set; }
        public Guid SteeringWheelId { get; set; }
        public Guid BodyId { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public List<IFormFile> Images { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCarDto, CreateCarCommand>()
                .ForMember(carCommand => carCommand.Name,
                    opt => opt.MapFrom(carDto => carDto.Name))
                .ForMember(carCommand => carCommand.BrandId,
                    opt => opt.MapFrom(carDto => carDto.BrandId))
                .ForMember(carCommand => carCommand.ColorId,
                    opt => opt.MapFrom(carDto => carDto.ColorId))
                .ForMember(carCommand => carCommand.BoxId,
                    opt => opt.MapFrom(carDto => carDto.BoxId))
                .ForMember(carCommand => carCommand.SteeringWheelId,
                    opt => opt.MapFrom(carDto => carDto.SteeringWheelId))
                .ForMember(carCommand => carCommand.BodyId,
                    opt => opt.MapFrom(carDto => carDto.BodyId))
                .ForMember(carCommand => carCommand.Engine,
                    opt => opt.MapFrom(carDto => carDto.Engine))
                .ForMember(carCommand => carCommand.Mileage,
                    opt => opt.MapFrom(carDto => carDto.Mileage))
                .ForMember(carCommand => carCommand.Year,
                    opt => opt.MapFrom(carDto => carDto.Year))
                .ForMember(carCommand => carCommand.Price,
                    opt => opt.MapFrom(carDto => carDto.Price))
                .ForMember(carCommand => carCommand.Images,
                    opt => opt.MapFrom(carDto => carDto.Images));
        }
    }
}
