﻿using Microsoft.EntityFrameworkCore;
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

            builder.HasOne(c => c.Brand)
                .WithMany()
                .HasForeignKey(c => c.Brand)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.CarColor)
                .WithMany()
                .HasForeignKey(c => c.Brand)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Box)
                .WithMany()
                .HasForeignKey(c => c.Box)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.SteeringWheel)
                .WithMany()
                .HasForeignKey(c => c.Brand)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
