using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration
        : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");

            //create PK for detailed table
            builder.HasKey(x =>
            new {
                x.ProductId,
                x.CategoryId
            });

            //create FK
            /*ProductId*/
            builder.HasOne(reftable => reftable.Product) //reference table
                .WithMany(table => table.ProductInCategories) //fk table 
                .HasForeignKey(fk => fk.ProductId); //set fk for fk table
            /*CategoryId*/
            builder.HasOne(reftable => reftable.Category)
                .WithMany(table => table.ProductInCategories)
                .HasForeignKey(fk => fk.CategoryId);
        }
    }
}
