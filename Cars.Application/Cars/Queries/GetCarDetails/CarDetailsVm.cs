using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.Cars.Queries.GetCarDetails
{
    public class CarDetailsVm : IMapWith<Car>
    {
        public Guid Id { get; set; }
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
        public ICollection<string> Images { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Car, CarDetailsVm>()
                .ForMember(vm => vm.Id, opt => opt.MapFrom(car => car.Id))
                .ForMember(vm => vm.Name, opt => opt.MapFrom(car => car.Name))
                .ForMember(vm => vm.BrandId, opt => opt.MapFrom(car => car.BrandId))
                .ForMember(vm => vm.ColorId, opt => opt.MapFrom(car => car.CarColorId))
                .ForMember(vm => vm.BoxId, opt => opt.MapFrom(car => car.BoxId))
                .ForMember(vm => vm.SteeringWheelId, opt => opt.MapFrom(car => car.SteeringWheelId))
                .ForMember(vm => vm.BodyId, opt => opt.MapFrom(car => car.BodyId))
                .ForMember(vm => vm.Engine, opt => opt.MapFrom(car => car.Engine))
                .ForMember(vm => vm.Mileage, opt => opt.MapFrom(car => car.Mileage))
                .ForMember(vm => vm.Year, opt => opt.MapFrom(car => car.Year))
                .ForMember(vm => vm.Price, opt => opt.MapFrom(car => car.Price))
                .ForMember(dto => dto.Images, opt => opt.MapFrom(car => car.Images.Select(img => img.ImageUrl)))
                .ForMember(vm => vm.CreationDate, opt => opt.MapFrom(car => car.CreationDate))
                .ForMember(vm => vm.EditDate, opt => opt.MapFrom(car => car.EditDate));
        }
    }
}
