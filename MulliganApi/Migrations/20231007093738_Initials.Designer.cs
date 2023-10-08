﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MulliganApi.Data;

#nullable disable

namespace MulliganApi.Migrations
{
    [DbContext(typeof(MulliganDbContext))]
    [Migration("20231007093738_Initials")]
    partial class Initials
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
                            Id = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol",
                            Has18Holes = false,
                            Length = 5000,
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
                            Id = new Guid("565d2e9e-d260-42dd-9415-ffa9646ce2c7"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("dca81ed6-4fa2-485b-9595-cc7995ce009e"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("2ff1c903-2a1b-49c2-92a4-382ea5e37c5f"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("64ff62ba-d0c4-4288-8113-e898a8bf4804"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("19c12b33-85ad-40f6-843f-9201d0d1d291"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("33aaca0c-98d6-4a3a-9f25-318e9006b2ac"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("088f5a4a-6ba3-46c5-9e3b-aa2a013633a4"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("631afe8b-bf54-4b62-9bb5-fef79239db27"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("801c6b17-90e9-424d-b1f1-20423acca297"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
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
                            Id = new Guid("cadf5b6e-68f2-4ec3-ac83-a4c17edb38ef"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
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
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            CourseId = new Guid("e78e6a56-838d-40c3-8a2c-eabde52e92ad"),
                            Puts = 18,
                            Strokes = 45,
                            UserId = new Guid("71e44be8-91ef-4b35-8abe-4741fdd80296")
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
                            Id = new Guid("42c3a0eb-19ec-4377-a474-76e6f1cfd463"),
                            HoleNumber = 1,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("d96a177d-af8e-4958-85f8-ddfc75e20ecd"),
                            HoleNumber = 2,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("751befb8-ba6c-4899-928f-a7ff9bc1dedd"),
                            HoleNumber = 3,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("6f5ecd23-166e-4aee-8918-c913bec5c482"),
                            HoleNumber = 4,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("926ac575-7e23-4623-8fd3-8383d80cb12c"),
                            HoleNumber = 5,
                            Puts = 1,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("83c92190-e108-4f2f-82ae-ccf3e4e46be2"),
                            HoleNumber = 6,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("c2cdb27e-ba45-4879-bb0a-64d79bae4f0c"),
                            HoleNumber = 7,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("63ba9c5e-89a7-4f8c-b410-9b807c5d76e3"),
                            HoleNumber = 8,
                            Puts = 2,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("7b8bdd74-0052-4755-89b8-6fca6b94aeee"),
                            HoleNumber = 9,
                            Puts = 3,
                            RoundId = new Guid("097eaf80-8b63-4fad-bf93-2577522a3587"),
                            Score = 4
                        });
                });

            modelBuilder.Entity("MulliganApi.Database.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
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
