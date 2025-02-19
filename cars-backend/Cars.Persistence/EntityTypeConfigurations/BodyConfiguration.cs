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
    public class BodyConfiguration : IEntityTypeConfiguration<Body>
    {
        public void Configure(EntityTypeBuilder<Body> builder)
        {
            builder.ToTable("Bodies");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.BodyType)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(b => b.Cars)
               .WithOne(c => c.Body)
               .HasForeignKey(c => c.BodyId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
