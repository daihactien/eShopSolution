using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoryTranslationConfiguration :
        IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");

            //PK
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.SeoAlias)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.SeoDescription)
                .HasMaxLength(500);
            builder.Property(x => x.SeoTitle)
                .HasMaxLength(200);

            builder.Property(x => x.LanguageId)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(5);

            //FK
            builder.HasOne(reftable => reftable.Language) //reference people
                .WithMany(table => table.CategoryTranslations) //fk table
                .HasForeignKey(fk => fk.LanguageId); // set fk for fk table
            builder.HasOne(reftable => reftable.Category)
                .WithMany(table => table.CategoryTranslations)
                .HasForeignKey(fk => fk.CategoryId);

        }
    }
}
