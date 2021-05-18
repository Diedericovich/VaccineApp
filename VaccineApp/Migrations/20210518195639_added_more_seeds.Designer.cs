﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaccineApp;

namespace VaccineApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210518195639_added_more_seeds")]
    partial class added_more_seeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VaccineApp.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VaccinationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.HasIndex("VaccinationId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StatusId = 1,
                            UserId = 1,
                            VaccinationId = 1
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.AppointmentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Canceled"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Administered"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.BodyPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("BodyParts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eyes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nose"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mouth"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ears"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Left Arm"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Right Arm"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Torso"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Legs"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test",
                            PasswordHash = new byte[] { 246, 24, 224, 205, 163, 187, 102, 109, 172, 154, 84, 221, 153, 89, 100, 102, 134, 86, 202, 216, 113, 212, 40, 3, 219, 100, 80, 238, 131, 145, 235, 242, 16, 147, 123, 166, 156, 7, 211, 55, 125, 136, 9, 247, 135, 6, 37, 91, 72, 40, 9, 188, 162, 133, 47, 127, 241, 100, 238, 180, 175, 26, 64, 3 },
                            PasswordSalt = new byte[] { 29, 120, 11, 5, 91, 104, 171, 209, 56, 79, 69, 227, 126, 131, 2, 244, 186, 140, 81, 144, 183, 96, 20, 10, 116, 192, 139, 89, 138, 201, 20, 63, 133, 208, 52, 37, 132, 253, 11, 53, 6, 221, 221, 88, 124, 161, 140, 233, 245, 24, 41, 74, 200, 74, 13, 47, 135, 13, 242, 189, 138, 250, 47, 213, 73, 24, 102, 164, 109, 150, 58, 11, 29, 136, 41, 90, 183, 160, 169, 180, 196, 233, 132, 244, 85, 63, 51, 57, 0, 235, 44, 226, 33, 245, 227, 221, 68, 169, 175, 148, 84, 176, 226, 57, 14, 231, 160, 128, 180, 45, 52, 15, 79, 215, 251, 193, 109, 15, 63, 27, 104, 123, 53, 100, 95, 13, 53, 236 }
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "test",
                            BirthDate = new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "test",
                            LoginId = 1,
                            Surname = "test"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.VaccinationCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VaccinationCenters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "location",
                            Name = "testCentre"
                        },
                        new
                        {
                            Id = 2,
                            Location = "location",
                            Name = "VaxxCenter"
                        },
                        new
                        {
                            Id = 3,
                            Location = "location",
                            Name = "PokeCenter"
                        },
                        new
                        {
                            Id = 4,
                            Location = "location",
                            Name = "Cent er"
                        },
                        new
                        {
                            Id = 5,
                            Location = "location",
                            Name = "Help"
                        },
                        new
                        {
                            Id = 6,
                            Location = "location",
                            Name = "IkKanGeenLeukeNaamMeerVinden"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BodyPartId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BodyPartId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyPartId = 3,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "TestVaxx"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.VaccineCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsEmaApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VaccineCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Russia",
                            IsEmaApproved = false,
                            Name = "BigEvilCo"
                        },
                        new
                        {
                            Id = 2,
                            Country = "test",
                            IsEmaApproved = false,
                            Name = "test"
                        });
                });

            modelBuilder.Entity("VaccineApp.Entities.Appointment", b =>
                {
                    b.HasOne("VaccineApp.Entities.VaccinationCenter", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.AppointmentStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.User", null)
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.Vaccine", "Vaccination")
                        .WithMany()
                        .HasForeignKey("VaccinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Status");

                    b.Navigation("Vaccination");
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.HasOne("VaccineApp.Entities.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("VaccineApp.Entities.Vaccine", b =>
                {
                    b.HasOne("VaccineApp.Entities.BodyPart", "BodyPart")
                        .WithMany()
                        .HasForeignKey("BodyPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VaccineApp.Entities.VaccineCompany", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyPart");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("VaccineApp.Entities.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
