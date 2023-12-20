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
    [Migration("20231220121210_ChangesToUserTable")]
    partial class ChangesToUserTable
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
                            Id = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol golfklubb",
                            Has18Holes = false,
                            Length = 2606,
                            Par = 36
                        },
                        new
                        {
                            Id = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
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
                            Id = new Guid("3d865835-3fe6-4b16-bf03-e31ca45b4f04"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("ddec1612-c6be-4d7e-bf07-a3cbee52d259"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("c674f9b3-14b0-4de9-b4fc-cd06e31d59a6"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("52d58aca-c60b-405d-a443-a06759180ec0"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("2de2de63-0ffb-4dc5-a9fc-2869fdb18eab"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("ddd51cb8-81c8-4cfe-a956-ffdd011c8349"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("cbf13496-c944-4431-a70d-e5467c23ec00"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("52035625-d1f8-4afa-b5f9-d8d3bf75de9e"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("bdb9ca9f-cdf1-4889-9a55-02945c71df4c"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            HoleNumber = 9,
                            Length = 330,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("5f14b6d3-f553-48fb-88b9-f6d0673c9b15"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 1,
                            Length = 494,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("fedb12c2-14ac-4d91-a303-d7a72c9bb152"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 2,
                            Length = 266,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("a52b8d77-5e5b-4d0b-845a-a1b86720bfec"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 3,
                            Length = 361,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("eedf4b57-2652-438a-848f-c9d67bead932"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 4,
                            Length = 367,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("fbb6d3be-9778-4af7-bbe9-b156a40cdb1d"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 5,
                            Length = 127,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("38cf2d35-257c-4b09-a06c-43c6323a8b1c"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 6,
                            Length = 337,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("abbc8bee-899c-445f-9095-00f718cc94ef"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 7,
                            Length = 412,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("a0d4d5d4-847e-4e6c-9f8b-bf859ae294ad"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
                            HoleNumber = 8,
                            Length = 141,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("8d852778-fac6-499d-ac9b-7a2f0a13c976"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
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
                            Id = new Guid("3a8913a0-5241-4b0a-9d7c-e24497d29f93"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            TeeBox = 52
                        },
                        new
                        {
                            Id = new Guid("a480bc89-8422-4383-a179-1ff1b663677f"),
                            CourseId = new Guid("be634fd7-1542-4625-a0de-e2f1c3b79e73"),
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
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            CourseId = new Guid("1cf24fb5-ddad-4485-ab7c-1090a2a9cbc6"),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Puts = 18,
                            Strokes = 33,
                            UserId = new Guid("38adbc5b-b58a-4b4f-9b71-66ed80b261d7")
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
                            Id = new Guid("12cd8005-ccd4-497a-9896-74f6b24d6aae"),
                            HoleNumber = 1,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("b8dc3cf5-d068-4110-a095-b1cc627009a7"),
                            HoleNumber = 2,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("b20af224-fe21-4187-abd1-2fa9427f2b2a"),
                            HoleNumber = 3,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("0062a0a6-e07e-4e79-ba58-37856d88f50c"),
                            HoleNumber = 4,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("6a09090a-c35e-4223-9b3b-47b67f17bdaf"),
                            HoleNumber = 5,
                            Par = 0,
                            Puts = 1,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("f7a80cfa-8646-43cf-a684-204f44cd3a82"),
                            HoleNumber = 6,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("61a73fff-8cd5-4acf-94d1-a5da5dd9010a"),
                            HoleNumber = 7,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("d373fdf5-e192-4f98-b208-ab4a55821ee9"),
                            HoleNumber = 8,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("c8e79cf0-93fd-403b-b851-e99e98d270c8"),
                            HoleNumber = 9,
                            Par = 0,
                            Puts = 3,
                            RoundId = new Guid("b73a53a8-f9db-427b-be7b-3cc273f6a4ee"),
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
