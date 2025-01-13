using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Notes.Domain.Car;
namespace Notes.Persistance.EntityTypeConfigurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Mileage)
                .IsRequired();

            builder.Property(c => c.Engine)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Year)
                .IsRequired();

            builder.Property(c => c.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired(true);

            builder.Property(c => c.CreationDate)
                .IsRequired();

            builder.Property(c => c.EditDate)
                .IsRequired(false);

            builder.HasOne<Brand>()
            .WithMany()
            .HasForeignKey(c => c.BrandId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CarColor>()
            .WithMany()
            .HasForeignKey(c => c.CarColorId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Box>()
                .WithMany()
                .HasForeignKey(c => c.BoxId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SteeringWheel>()
                .WithMany()
                .HasForeignKey(c => c.SteeringWheelId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
