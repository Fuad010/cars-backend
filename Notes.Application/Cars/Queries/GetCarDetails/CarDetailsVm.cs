using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Cars.Queries.GetCarDetails
{
    public class CarDetailsVm : IMapWith<Car>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
        public Guid ColorId { get; set; }
        public string ColorName { get; set; }
        public Guid BoxId { get; set; }
        public string BoxName { get; set; }
        public Guid SteeringWheelId { get; set; }
        public string SteeringWheelName { get; set; }
        public Guid BodyId { get; set; }
        public string BodyName { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
        public ICollection<CarImage> Images { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDetailsVm>()
                .ForMember(carVm => carVm.Id,
                    opt => opt.MapFrom(car => car.Id))
                .ForMember(carVm => carVm.UserId,
                    opt => opt.MapFrom(car => car.UserId))
                .ForMember(carVm => carVm.Name,
                    opt => opt.MapFrom(car => car.Name))
                .ForMember(carVm => carVm.BrandId,
                    opt => opt.MapFrom(car => car.BrandId))
                .ForMember(carVm => carVm.BrandName,
                    opt => opt.MapFrom(car => car.Brand.Name))
                .ForMember(carVm => carVm.ColorId,
                    opt => opt.MapFrom(car => car.ColorId))
                .ForMember(carVm => carVm.ColorName,
                    opt => opt.MapFrom(car => car.CarColor.Name))
                .ForMember(carVm => carVm.BoxId,
                    opt => opt.MapFrom(car => car.BoxId))
                .ForMember(carVm => carVm.BoxName,
                    opt => opt.MapFrom(car => car.Box.Name))
                .ForMember(carVm => carVm.SteeringWheelId,
                    opt => opt.MapFrom(car => car.SteeringWheelId))
                .ForMember(carVm => carVm.SteeringWheelName,
                    opt => opt.MapFrom(car => car.SteeringWheel.Name))
                .ForMember(carVm => carVm.BodyId,
                    opt => opt.MapFrom(car => car.BodyId))
                .ForMember(carVm => carVm.BodyName,
                    opt => opt.MapFrom(car => car.Body.Name))
                .ForMember(carVm => carVm.Engine,
                    opt => opt.MapFrom(car => car.Engine))
                .ForMember(carVm => carVm.Mileage,
                    opt => opt.MapFrom(car => car.Mileage))
                .ForMember(carVm => carVm.Year,
                    opt => opt.MapFrom(car => car.Year))
                .ForMember(carVm => carVm.Price,
                    opt => opt.MapFrom(car => car.Price))
                .ForMember(carVm => carVm.CreationDate,
                    opt => opt.MapFrom(car => car.CreationDate))
                .ForMember(carVm => carVm.EditDate,
                    opt => opt.MapFrom(car => car.EditDate))
                .ForMember(carVm => carVm.Images,
                    opt => opt.MapFrom(car => car.Images));
        }
    }
}
