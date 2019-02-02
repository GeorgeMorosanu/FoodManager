﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nesti.Data;

namespace Nesti.Migrations
{
    [DbContext(typeof(NsContext))]
    [Migration("20190202210801_AdditionalTables")]
    partial class AdditionalTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nesti.Data.Entities.GenericProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("MeasurementId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MeasurementId");

                    b.ToTable("GenericProducts");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<Guid?>("GenericProductId");

                    b.Property<Guid?>("MealId");

                    b.HasKey("Id");

                    b.HasIndex("GenericProductId");

                    b.HasIndex("MealId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Meal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Instructions");

                    b.Property<string>("Name");

                    b.Property<int>("PreparationTime");

                    b.Property<Guid?>("WeekId");

                    b.Property<Guid?>("WeekId1");

                    b.Property<Guid?>("WeekId2");

                    b.Property<Guid?>("WeekId3");

                    b.Property<Guid?>("WeekId4");

                    b.Property<Guid?>("WeekId5");

                    b.Property<Guid?>("WeekId6");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.HasIndex("WeekId1");

                    b.HasIndex("WeekId2");

                    b.HasIndex("WeekId3");

                    b.HasIndex("WeekId4");

                    b.HasIndex("WeekId5");

                    b.HasIndex("WeekId6");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Measurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("Measurement");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Barcode");

                    b.Property<Guid?>("GenericProductId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("GenericProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Week", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("Nesti.Data.Entities.GenericProduct", b =>
                {
                    b.HasOne("Nesti.Data.Entities.Measurement", "Measurement")
                        .WithMany()
                        .HasForeignKey("MeasurementId");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Ingredient", b =>
                {
                    b.HasOne("Nesti.Data.Entities.GenericProduct", "GenericProduct")
                        .WithMany()
                        .HasForeignKey("GenericProductId");

                    b.HasOne("Nesti.Data.Entities.Meal")
                        .WithMany("Ingredients")
                        .HasForeignKey("MealId");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Meal", b =>
                {
                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsFriday")
                        .HasForeignKey("WeekId");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsMonday")
                        .HasForeignKey("WeekId1");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsSaturday")
                        .HasForeignKey("WeekId2");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsSunday")
                        .HasForeignKey("WeekId3");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsThursday")
                        .HasForeignKey("WeekId4");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsTuesday")
                        .HasForeignKey("WeekId5");

                    b.HasOne("Nesti.Data.Entities.Week")
                        .WithMany("MealsWednesday")
                        .HasForeignKey("WeekId6");
                });

            modelBuilder.Entity("Nesti.Data.Entities.Product", b =>
                {
                    b.HasOne("Nesti.Data.Entities.GenericProduct", "GenericProduct")
                        .WithMany()
                        .HasForeignKey("GenericProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
