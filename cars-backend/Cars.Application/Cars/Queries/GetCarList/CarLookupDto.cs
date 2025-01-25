    using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarList
{
    public class CarLookupDto : IMapWith<Car>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string BoxType { get; set; }
        public string SteeringWheelType { get; set; }
        public string BodyType { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public ICollection<string> Images { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(car => car.Id))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(car => car.Name))
                .ForMember(dto => dto.BrandName, opt => opt.MapFrom(car => car.Brand.Name))
                .ForMember(dto => dto.ColorName, opt => opt.MapFrom(car => car.CarColor.ColorName))
                .ForMember(dto => dto.BoxType, opt => opt.MapFrom(car => car.Box.BoxType))
                .ForMember(dto => dto.SteeringWheelType, opt => opt.MapFrom(car => car.SteeringWheel.SteeringWheelType))
                .ForMember(dto => dto.BodyType, opt => opt.MapFrom(car => car.Body.BodyType))
                .ForMember(dto => dto.Engine, opt => opt.MapFrom(car => car.Engine))
                .ForMember(dto => dto.Mileage, opt => opt.MapFrom(car => car.Mileage))
                .ForMember(dto => dto.Year, opt => opt.MapFrom(car => car.Year))
                .ForMember(dto => dto.Price, opt => opt.MapFrom(car => car.Price))
                .ForMember(dto => dto.Images, opt => opt.MapFrom(car => car.Images.Select(img => img.ImageUrl)))
                .ForMember(dto => dto.CreationDate, opt => opt.MapFrom(car => car.CreationDate))
                .ForMember(dto => dto.EditDate, opt => opt.MapFrom(car => car.EditDate));
        }
    }
}
