﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dnpexprep.VolumeWebService.VolumeCalculator;

namespace dnpexprep.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201222195352_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("dnpexprep.VolumeWebService.VolumeCalculator.VolumeResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Height")
                        .HasColumnType("REAL");

                    b.Property<double>("Radius")
                        .HasColumnType("REAL");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("volumes");
                });
#pragma warning restore 612, 618
        }
    }
}
