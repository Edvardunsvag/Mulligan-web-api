﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MulliganApi.Data;

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
                            Id = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
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
                            Id = new Guid("3bc55b1d-05c3-4b68-b09a-7bd6fe1af667"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("6bcd4947-4bb6-432b-ae67-36656fe76e32"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("cdef83d0-6d57-4e29-8191-8af94c76e5bb"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("1711bf0b-6a33-421b-a81b-f0372394da7f"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("028cd1c8-c7f8-4baf-bb42-8aad0b600775"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("bcd56576-1e57-455d-b482-7940e229ff7d"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("e6d89905-d617-469f-ae3a-983d77bc459a"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("3b25981d-d5a5-4908-87f9-dd958d3a7a2b"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("de28f3fe-9229-40c5-a5db-50e7e3c4931f"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
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
                            Id = new Guid("6614dfa8-1cd3-4195-a08b-52e891455b36"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
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
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            CourseId = new Guid("9f73001c-5cce-4682-ba74-6252a7394089"),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Puts = 18,
                            Strokes = 33,
                            UserId = new Guid("4d6ff1f3-9c7e-4b5b-b42c-632b0b3d8acb")
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
                            Id = new Guid("19cf368f-5b98-4e95-9c43-b942f7392fa0"),
                            HoleNumber = 1,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("c398e7b9-2ec4-4147-96ef-19fb7999a5c5"),
                            HoleNumber = 2,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("f2f44f0b-bc7f-4ae3-b308-057cd0333a64"),
                            HoleNumber = 3,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("dbec5194-1a67-4c42-85d8-8648f69dd289"),
                            HoleNumber = 4,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("7568a465-ca43-4ef8-92a5-890811aa3926"),
                            HoleNumber = 5,
                            Puts = 1,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("5d22101a-00e9-47c5-b2b6-9955d45a37f0"),
                            HoleNumber = 6,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("33d24984-81b9-4155-a3df-7d8cb3315ff3"),
                            HoleNumber = 7,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("6f1a479f-afe7-4d96-ae4e-ae65e4906112"),
                            HoleNumber = 8,
                            Puts = 2,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("005b2304-5cfa-4e9f-bd07-38df848af026"),
                            HoleNumber = 9,
                            Puts = 3,
                            RoundId = new Guid("e8f50966-e2fe-4ff1-88ed-8bb6964de06e"),
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
