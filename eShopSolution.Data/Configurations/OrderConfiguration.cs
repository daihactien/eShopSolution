using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id); //PK
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.ShipEmail)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(50);
            builder.Property(x => x.ShipAddress)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.ShipName)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.ShipPhoneNumber)
                .IsRequired()
                .HasMaxLength(200);

            //FK
            builder.HasOne(reftable => reftable.AppUser) //reference table
                .WithMany(table => table.Orders) //fk table
                .HasForeignKey(fk => fk.UserId); //set fk for fk table
        }
    }
}
