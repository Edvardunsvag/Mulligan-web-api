﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MulliganApi.Database;

#nullable disable

namespace MulliganApi.Migrations
{
    [DbContext(typeof(MulliganDbContext))]
    [Migration("20231221100736_optionalEmail")]
    partial class optionalEmail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MulliganApi.Database.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Has18Holes")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol golfklubb",
                            Has18Holes = false,
                            Length = 2606,
                            Par = 36
                        },
                        new
                        {
                            Id = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            CourseDescription = "Grønmo golfklubb description",
                            CourseName = "Grønmo golfklubb",
                            Has18Holes = false,
                            Length = 2870,
                            Par = 37
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.CourseHole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HoleNumber")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseHole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2fb65d4e-262c-4598-a081-75b614c5b5e6"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("b028ae8c-fc77-4b2e-89f3-2a4e4c8295de"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("599128da-2e42-458e-9390-51a3ca73bd38"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("7d229392-356d-42de-9231-f13be2d540c7"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("933a29ca-99d1-46d7-97ab-97eb99945915"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("a44ec46d-7ff6-46f2-ac13-4ba568be8f78"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("a85f487f-f9b7-4bee-92a6-39d1fc68a07b"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("1bff6206-eb7b-4ff0-a18c-6c87af0d28d1"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("e6e3d6fe-6a52-43f1-8eae-241011965aba"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            HoleNumber = 9,
                            Length = 330,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("f33c86f9-14dd-4ee9-921e-cac64a645ab1"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 1,
                            Length = 494,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("4480cc3c-df53-4a67-8a30-b6a9e790913f"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 2,
                            Length = 266,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("777a6f11-2ba1-4c28-b3eb-effb62b6aece"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 3,
                            Length = 361,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("2724ae8a-69fe-4e8b-9d4e-513d8a63eb36"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 4,
                            Length = 367,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("32cb58d1-776d-4e39-a46b-1a7ff47949a1"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 5,
                            Length = 127,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("f154f384-c857-42ac-942c-93feef5b6c39"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 6,
                            Length = 337,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("e839273a-f4f8-4d32-9c33-b93bde8321ce"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 7,
                            Length = 412,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("2ca53452-aa7e-4428-b0ad-7e5ff9e3a77d"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 8,
                            Length = 141,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("84c88ad9-b721-445c-a5e2-8643fae0fc87"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            HoleNumber = 9,
                            Length = 365,
                            Par = 4
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.CourseTeeBox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TeeBox")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("TeeBoxes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4e1fe4d8-332a-4987-933e-5a738ddba836"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            TeeBox = 52
                        },
                        new
                        {
                            Id = new Guid("8bb8ee7f-6f22-442f-82ce-372a8f8a90fd"),
                            CourseId = new Guid("07661537-e5d7-4b4a-92ff-d1bf6196ae6a"),
                            TeeBox = 57
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HoleId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.Round", b =>
                {
                    b.Property<Guid>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Puts")
                        .HasColumnType("int");

                    b.Property<int>("Strokes")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoundId");

                    b.ToTable("Round");

                    b.HasData(
                        new
                        {
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            CourseId = new Guid("b4a4bffe-cfa0-47c2-b11a-969cb1b997f7"),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Puts = 18,
                            Strokes = 33,
                            UserId = new Guid("87f32ca7-d592-44b9-8026-80ce3c5c7ca1")
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.RoundHole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HoleNumber")
                        .HasColumnType("int");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.Property<int>("Puts")
                        .HasColumnType("int");

                    b.Property<Guid>("RoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.ToTable("RoundHole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7382f2bf-f190-4ef8-ac08-e532535b13a4"),
                            HoleNumber = 1,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("837d0f7d-39e1-45e6-9dba-1ea8f2e71047"),
                            HoleNumber = 2,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("ea49f85f-d245-469e-a40c-698ab952e332"),
                            HoleNumber = 3,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("88e3a56c-7c1e-4048-a267-f787f84f8851"),
                            HoleNumber = 4,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("30bb31ea-ad39-499a-9749-0fea53fcd1ee"),
                            HoleNumber = 5,
                            Par = 0,
                            Puts = 1,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("2902bf14-3307-4e6e-8a70-deaeeac1132b"),
                            HoleNumber = 6,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("a17978c6-f0ab-429a-a70b-a5045c2fbadb"),
                            HoleNumber = 7,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("2bf3092f-1f05-432d-afb3-47773d41c474"),
                            HoleNumber = 8,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("6054dc2b-4708-4da2-af6a-9d069fd3d339"),
                            HoleNumber = 9,
                            Par = 0,
                            Puts = 3,
                            RoundId = new Guid("244f8f51-9394-4374-b074-350ab2841f86"),
                            Score = 4
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.CourseHole", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.Course", null)
                        .WithMany("CourseHoles")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MulliganApi.Database.Models.CourseTeeBox", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.Course", null)
                        .WithMany("TeeBoxes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MulliganApi.Database.Models.Note", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.CourseHole", "CourseHole")
                        .WithMany("Notes")
                        .HasForeignKey("HoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseHole");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.RoundHole", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.Round", null)
                        .WithMany("Holes")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MulliganApi.Database.Models.Course", b =>
                {
                    b.Navigation("CourseHoles");

                    b.Navigation("TeeBoxes");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.CourseHole", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.Round", b =>
                {
                    b.Navigation("Holes");
                });
#pragma warning restore 612, 618
        }
    }
}