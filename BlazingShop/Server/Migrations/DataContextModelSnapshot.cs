﻿// <auto-generated />
using System;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Arena Of Valor",
                            Url = "aov"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "aperture",
                            Name = "Leagua Of Legends",
                            Url = "lol"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 593, DateTimeKind.Local).AddTicks(9827),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Murad...",
                            Image = "https://lienquan.garena.vn/files/skin/090d96a5955687155dc3e4c46d0e383f5b86850280f19.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 5m,
                            Title = "Lien Quan Mobile - Murad Play Guide"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2779),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Xeniel...",
                            Image = "https://lienquan.garena.vn/files/skin/bd2414ce5bb59066b6815a233837857a5c2c715549ce3.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 7m,
                            Title = "Lien Quan Mobile - Xeniel Play Guide"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2832),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Nakroth...",
                            Image = "https://lienquan.garena.vn/files/skin/b2dbfc69db9688c3295ec4f9880187125f0d1e4e449a7.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 9m,
                            Title = "Lien Quan Mobile - Nakroth Play Guide"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2835),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro TRIỆU VÂN...",
                            Image = "https://lienquan.garena.vn/files/skin/d7342b00ec05faf09f815c74ce8306eb59d1ad95a449a.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 13m,
                            Title = "Lien Quan Mobile - TRIỆU VÂN Play Guide"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2837),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Taara...",
                            Image = "https://lienquan.garena.vn/files/skin/a25530a02bf4bc8f5b230b2a146928ae5ec912acedcc5.png",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 9m,
                            Title = "Lien Quan Mobile - Taara Play Guide"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2839),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Ahri...",
                            Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/ahri_2.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 45m,
                            Title = "Lien Minh Huyen Thoai - Ahri Play Guide"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2841),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Caitlyn...",
                            Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/caitlyn_11.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 55m,
                            Title = "Lien Minh Huyen Thoai - Caitlyn Play Guide"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2926),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Fiora...",
                            Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/fiora_4.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 65m,
                            Title = "Lien Minh Huyen Thoai - Fiora Play Guide"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2931),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Irelia...",
                            Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/irelia_26.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 65m,
                            Title = "Lien Minh Huyen Thoai - Irelia Play Guide"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 8, 27, 14, 54, 0, 595, DateTimeKind.Local).AddTicks(2933),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to play pro Vi...",
                            Image = "https://cdngarenanow-a.akamaihd.net/webmain/static/pss/lol/items_splash/vi_5.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.0m,
                            Price = 65m,
                            Title = "Lien Minh Huyen Thoai - Vi Play Guide"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.HasOne("BlazingShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
