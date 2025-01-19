using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.EntityTypeConfigurations
{
    public class CarImageConfiguration : IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.ToTable("CarImages");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.ImageUrl)
                   .IsRequired()
                   .HasMaxLength(2048);

            builder.HasOne(ci => ci.Car)
                   .WithMany(c => c.Images)
                   .HasForeignKey(ci => ci.CarId);
        }
    }
}
