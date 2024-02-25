﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WeatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.WeatherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AtmosphericPressure")
                        .HasColumnType("integer");

                    b.Property<int?>("Cloudboundary")
                        .HasColumnType("integer");

                    b.Property<int?>("Cloudiness")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Dewpoint")
                        .HasColumnType("double precision");

                    b.Property<string>("HorizontalVisibility")
                        .HasColumnType("text");

                    b.Property<double>("RelativeHumidity")
                        .HasColumnType("double precision");

                    b.Property<double>("Temperature")
                        .HasColumnType("double precision");

                    b.Property<string>("WeatherPhenomena")
                        .HasColumnType("text");

                    b.Property<string>("WindDirection")
                        .HasColumnType("text");

                    b.Property<int?>("WindSpeed")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("WeatherEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
