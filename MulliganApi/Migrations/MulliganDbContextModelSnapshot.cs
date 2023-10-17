﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MulliganApi.Database;

#nullable disable

namespace MulliganApi.Migrations
{
    [DbContext(typeof(MulliganDbContext))]
    partial class MulliganDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol golfklubb",
                            Has18Holes = false,
                            Length = 2606,
                            Par = 0
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
                            Id = new Guid("4315bd89-86ab-434e-af38-021068d0c3fa"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("4b734475-89c5-4942-b82b-ca32587dd092"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("cc68bd7f-3179-433e-a089-0276931e4c9c"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("61bf2f78-d0ba-4e54-8742-64dc730e4ac4"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("b36aa4d7-417b-44a9-8796-92d205f05169"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("8684c5d0-4e0a-4259-bea4-465feeb5ef24"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("acedd4c6-f340-4030-a5ec-6d80b7bd34c1"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("0feb56a8-8da9-4049-a112-6f3c8a270f58"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("a7b18268-5dc1-422c-a30f-784cc541df7e"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            HoleNumber = 9,
                            Length = 330,
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
                            Id = new Guid("f1dc6a8c-1b3f-4af8-8c27-5ffca36634af"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            TeeBox = 52
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
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            CourseId = new Guid("4ba95173-1e9d-4874-84c5-43462f6f2647"),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Puts = 18,
                            Strokes = 33,
                            UserId = new Guid("814077ba-4ccc-4329-a84b-dc8264d7e1ff")
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.RoundHole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HoleNumber")
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
                            Id = new Guid("668bf063-51c0-42ad-bf82-60af8ad75b82"),
                            HoleNumber = 1,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("c8225fb7-6d51-4cf1-a8cb-3bb04abb8a5c"),
                            HoleNumber = 2,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("af65d9c7-579a-4d26-bec7-3f6ee0060141"),
                            HoleNumber = 3,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("0a78eb49-f22f-4c42-9030-88ff392f8161"),
                            HoleNumber = 4,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("24fa0d90-2f63-4857-9fcb-c89ef4f71c8f"),
                            HoleNumber = 5,
                            Puts = 1,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("2ee30590-624c-4d2b-bb8e-755fae575561"),
                            HoleNumber = 6,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("cc91d836-5029-479f-95d2-a3502ae5b028"),
                            HoleNumber = 7,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("bf44472a-d9aa-495f-9e7e-30de1452adc1"),
                            HoleNumber = 8,
                            Puts = 2,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("bebf8ba0-8082-4a24-935b-c96f667a79a8"),
                            HoleNumber = 9,
                            Puts = 3,
                            RoundId = new Guid("0bb628fd-7525-4d27-81f7-9b3c736a3e58"),
                            Score = 4
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
