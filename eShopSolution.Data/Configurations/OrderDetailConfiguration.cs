using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration
        : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            //PK
            builder.HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            }); 
            
            //FK
            builder.HasOne(reftable => reftable.Order) //reference table
                .WithMany(table => table.OrderDetails) //fk table
                .HasForeignKey(fk => fk.OrderId); //set fk for fk table
            builder.HasOne(reftable => reftable.Product)
                .WithMany(table => table.OrderDetails)
                .HasForeignKey(fk => fk.ProductId);
        }
    }
}
