using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Cars.Domain.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Persistance.EntityTypeConfigurations
{
    public class BoxConfiguration : IEntityTypeConfiguration<Box>
    {
        public void Configure(EntityTypeBuilder<Box> builder)
        {
            builder.ToTable("Boxes");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.BoxType)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
