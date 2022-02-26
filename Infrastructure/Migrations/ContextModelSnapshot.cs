﻿// <auto-generated />
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Infrastructure.Context.Size", b =>
                {
                    b.Property<int>("Size_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Size_size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Size_Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Infrastructure.Entities.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_ParentId")
                        .HasColumnType("int");

                    b.Property<bool>("Category_Status")
                        .HasColumnType("bit");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Infrastructure.Entities.Color", b =>
                {
                    b.Property<int>("Color_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Color_Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Infrastructure.Entities.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<int>("Color_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Count")
                        .HasColumnType("int");

                    b.Property<string>("Product_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Product_Price")
                        .HasColumnType("float");

                    b.Property<bool>("Product_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Product_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Product_discount")
                        .HasColumnType("int");

                    b.Property<int>("Size_Id")
                        .HasColumnType("int");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
