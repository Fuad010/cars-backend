using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Notes.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance.EntityTypeConfigurations
{
    public class SteeringWheelConfiguration : IEntityTypeConfiguration<SteeringWheel>
    {
        public void Configure(EntityTypeBuilder<SteeringWheel> builder)
        {
            builder.ToTable("SteeringWheels");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.SteeringWheelType)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
