﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240923021852_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierID");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("api.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuggestedComponents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("api.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ComponentID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponentID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("api.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("api.Models.Component", b =>
                {
                    b.HasOne("api.Models.Supplier", "Supplier")
                        .WithMany("Components")
                        .HasForeignKey("SupplierID");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("api.Models.Configuration", b =>
                {
                    b.HasOne("api.Models.Customer", "Customer")
                        .WithMany("Configurations")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.HasOne("api.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("api.Models.OrderDetail", b =>
                {
                    b.HasOne("api.Models.Component", "Component")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ComponentID");

                    b.HasOne("api.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");

                    b.Navigation("Component");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("api.Models.Component", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("api.Models.Customer", b =>
                {
                    b.Navigation("Configurations");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("api.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("api.Models.Supplier", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}