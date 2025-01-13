using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Queries.GetCarList
{
    public class CarLookupDto : IMapWith<Car>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Box { get; set; }
        public string SteeringWheel { get; set; }
        public string Body { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(car => car.Id))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(car => car.Name))
                .ForMember(dto => dto.Brand, opt => opt.MapFrom(car => car.Brand.Name))
                .ForMember(dto => dto.Color, opt => opt.MapFrom(car => car.CarColor.ColorName))
                .ForMember(dto => dto.Box, opt => opt.MapFrom(car => car.Box.BoxType))
                .ForMember(dto => dto.SteeringWheel, opt => opt.MapFrom(car => car.SteeringWheel.SteeringWheelType))
                .ForMember(dto => dto.Body, opt => opt.MapFrom(car => car.Body.BodyType))
                .ForMember(dto => dto.Engine, opt => opt.MapFrom(car => car.Engine))
                .ForMember(dto => dto.Mileage, opt => opt.MapFrom(car => car.Mileage))
                .ForMember(dto => dto.Year, opt => opt.MapFrom(car => car.Year))
                .ForMember(dto => dto.Price, opt => opt.MapFrom(car => car.Price));
        }
    }
}
