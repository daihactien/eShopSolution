using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductTranslationConfiguration
        : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslations");

            //PK
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.Details)
                .HasMaxLength(500);

            builder.Property(x => x.LanguageId)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(5);

            //FK
            builder.HasOne(reftable => reftable.Language) //reference table
                .WithMany(table => table.ProductTranslations) //fk table
                .HasForeignKey(fk => fk.LanguageId); //set fk for fk table
            builder.HasOne(reftable => reftable.Product)
                .WithMany(table => table.ProductTranslations)
                .HasForeignKey(fk => fk.ProductId);
        }
    }
}
