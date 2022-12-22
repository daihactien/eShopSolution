using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.Id); //PK
            builder.Property(x => x.Id).UseIdentityColumn();

            //FK
            builder.HasOne(reftable => reftable.Product) //reference table
                .WithMany(table => table.Carts) //fk table
                .HasForeignKey(x => x.ProductId); //set fk for fk table
        }
    }
}
