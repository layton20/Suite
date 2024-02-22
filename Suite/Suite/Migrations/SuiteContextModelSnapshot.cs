﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Suite.Data;

#nullable disable

namespace Suite.Migrations
{
    [DbContext(typeof(SuiteContext))]
    partial class SuiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Suite.Models.ProductModel", b =>
                {
                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AmendedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Uid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Suite.Models.ProductTag", b =>
                {
                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AmendedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductUid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagUid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Uid");

                    b.HasIndex("ProductUid");

                    b.HasIndex("TagUid");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("Suite.Models.TagModel", b =>
                {
                    b.Property<Guid>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AmendedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Suite.Models.ProductTag", b =>
                {
                    b.HasOne("Suite.Models.ProductModel", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductUid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Suite.Models.TagModel", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagUid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Suite.Models.ProductModel", b =>
                {
                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("Suite.Models.TagModel", b =>
                {
                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
