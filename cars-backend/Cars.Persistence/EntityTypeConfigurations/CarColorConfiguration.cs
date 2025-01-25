using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistence.EntityTypeConfigurations
{
    public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("CarColors");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.ColorName)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(b => b.Cars)
               .WithOne(c => c.CarColor)
               .HasForeignKey(c => c.CarColorId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
