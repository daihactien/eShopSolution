using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductImageConfiguration
        : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(); //PK

            builder.Property(x => x.ImagePath)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Caption)
                .HasMaxLength(200);

            builder.HasOne(reftable => reftable.Product) //reference table
                .WithMany(table => table.ProductImages) //fk table
                .HasForeignKey(fk => fk.ProductId); //set fk for fk table
        }
    }
}
