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
        public Guid BrandId { get; set; }
        public Guid CarColorId { get; set; }
        public Guid BoxId { get; set; }
        public Guid SteeringWheelId { get; set; }
        public Guid BodyId { get; set; }
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
                .ForMember(dto => dto.BrandId, opt => opt.MapFrom(car => car.BrandId))
                .ForMember(dto => dto.CarColorId, opt => opt.MapFrom(car => car.CarColorId))
                .ForMember(dto => dto.BoxId, opt => opt.MapFrom(car => car.BoxId))
                .ForMember(dto => dto.SteeringWheelId, opt => opt.MapFrom(car => car.SteeringWheelId))
                .ForMember(dto => dto.BodyId, opt => opt.MapFrom(car => car.BodyId))
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
