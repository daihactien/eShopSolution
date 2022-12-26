using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //AppConfig
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig()
                {
                    Key = "HomeTitle",
                    Value = "This is the home page of eShopSolution"
                },
                new AppConfig()
                {
                    Key = "HomeKeywork",
                    Value = "This is the keyword of eShopSolution"
                },
                new AppConfig()
                {
                    Key = "HomeDescription",
                    Value = "This is the description of eShopSolution"
                });

            //Language
            modelBuilder.Entity<Language>().HasData(
                new Language() { 
                    Id = "vi-VN", 
                    Name= "Tiếng Việt", 
                    IsDefault= true
                },
                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                });

            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category() 
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id= 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                });

            //CategoryTranslation
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id= 1,
                    CategoryId= 1,
                    Name = "Áo Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id= 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },
                new CategoryTranslation()
                {
                    Id= 3,
                    CategoryId= 2,
                    Name = "Áo Nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                },
                new CategoryTranslation()
                {
                    Id= 4,
                    CategoryId= 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                });

            //Product
            modelBuilder.Entity<Product>().HasData(
                new Product() 
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice= 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount= 0,
                });

            //ProductTranslation
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id= 1,
                    ProductId= 1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id= 2,
                    ProductId= 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Description of product",
                    Description = "Viet Tien Men T-Shirt",
                });

            //ProductInCategory
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { 
                    ProductId= 1,
                    CategoryId = 1 
                });

            // any guid
            var roleId = new Guid("0D579B1A-3DA7-4093-AE10-52CC57569BF2");
            var adminId = new Guid("72CDB154-F7BF-4CA2-ADBA-360344F8CB3A");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nguyenquanghien3005@gmail.com",
                NormalizedEmail = "nguyenquanghien3005@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Th@anglun9787"),
                SecurityStamp = string.Empty,
                FirstName = "Nguyen Quang",
                LastName = "Hien",
                Dob = new DateTime(2001, 05, 30)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = roleId,
                    UserId = adminId
                });
        }
    }
}
