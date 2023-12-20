﻿// <auto-generated />
using System;
using CodeAcademySpace;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAcademySpace.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeAcademySpace.booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("BookTime")
                        .HasColumnType("time");

                    b.Property<int>("SpaceID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.HasIndex("SpaceID");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("CodeAcademySpace.Space", b =>
                {
                    b.Property<int>("SpaceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceID"), 1L, 1);

                    b.Property<string>("SpaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.HasKey("SpaceID");

                    b.ToTable("spaces");
                });

            modelBuilder.Entity("CodeAcademySpace.booking", b =>
                {
                    b.HasOne("CodeAcademySpace.Space", "space")
                        .WithMany("Bookings")
                        .HasForeignKey("SpaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("space");
                });

            modelBuilder.Entity("CodeAcademySpace.Space", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
