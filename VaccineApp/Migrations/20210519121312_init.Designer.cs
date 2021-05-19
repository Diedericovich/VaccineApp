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
    [Migration("20210519121312_init")]
    partial class init
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
                            PasswordHash = new byte[] { 213, 22, 126, 29, 188, 65, 215, 80, 90, 18, 66, 248, 39, 16, 176, 146, 253, 12, 58, 85, 85, 63, 253, 253, 106, 148, 32, 194, 110, 140, 25, 25, 25, 74, 145, 96, 212, 135, 216, 212, 55, 197, 234, 223, 195, 188, 211, 89, 9, 100, 33, 35, 221, 146, 89, 92, 249, 255, 88, 122, 233, 165, 166, 124 },
                            PasswordSalt = new byte[] { 28, 183, 40, 177, 249, 199, 52, 38, 134, 69, 58, 49, 157, 22, 2, 149, 90, 18, 71, 139, 112, 142, 64, 164, 191, 218, 227, 58, 193, 14, 161, 90, 109, 38, 170, 145, 66, 213, 130, 44, 84, 84, 237, 166, 116, 169, 0, 216, 71, 27, 209, 228, 121, 247, 242, 213, 58, 178, 240, 82, 130, 131, 190, 18, 160, 90, 131, 236, 218, 114, 101, 23, 161, 32, 99, 60, 34, 190, 109, 165, 40, 189, 214, 194, 129, 138, 0, 168, 239, 7, 210, 214, 111, 167, 43, 33, 25, 245, 49, 131, 0, 236, 33, 206, 158, 37, 46, 47, 30, 59, 102, 18, 87, 200, 146, 42, 166, 68, 151, 198, 28, 51, 165, 72, 190, 88, 35, 147 }
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
                        },
                        new
                        {
                            Id = 2,
                            BodyPartId = 1,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "EyeVax"
                        },
                        new
                        {
                            Id = 3,
                            BodyPartId = 2,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "NoseVax"
                        },
                        new
                        {
                            Id = 4,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "LeftArmVax"
                        },
                        new
                        {
                            Id = 5,
                            BodyPartId = 5,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "LeftArmVax2"
                        },
                        new
                        {
                            Id = 6,
                            BodyPartId = 7,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "TorsoVax"
                        },
                        new
                        {
                            Id = 7,
                            BodyPartId = 8,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "LegsVax"
                        },
                        new
                        {
                            Id = 8,
                            BodyPartId = 6,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "RightArmVax"
                        },
                        new
                        {
                            Id = 9,
                            BodyPartId = 6,
                            CompanyId = 1,
                            Description = "desctestest",
                            Name = "RightArmVax2"
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