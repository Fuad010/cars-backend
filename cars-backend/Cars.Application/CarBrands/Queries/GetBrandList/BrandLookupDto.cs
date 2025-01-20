using AutoMapper;
using Cars.Application.Common.Mappings;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.CarBrands.Queries.GetBrandList
{
    public class BrandLookupDto : IMapWith<Brand>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Brand, BrandLookupDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(brand => brand.Id))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(brand => brand.Name));
        }
    }
}
