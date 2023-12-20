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
    [Migration("20231220094234_Initials")]
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
                            Id = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol golfklubb",
                            Has18Holes = false,
                            Length = 2606,
                            Par = 36
                        },
                        new
                        {
                            Id = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
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
                            Id = new Guid("45432af8-4b49-4fce-98e0-1b9464e17d1a"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("2951fb31-b357-4c64-8123-31c0870cdf46"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("cc8fe247-171f-4bdf-8922-cb8140839099"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("fdf11998-86b7-47f5-b893-dba5f2f59790"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("0f7e2f66-d984-4c81-8b1b-54b3c53500b3"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("e0a3a8dc-7d32-4a15-9af1-bd18a9a7390c"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("325b7631-19da-4d32-b582-6d288e86c7a2"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("9543ff73-5200-4359-aaba-bb4857c79af6"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("19911048-cd85-4f09-ab22-4dc7987563ba"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            HoleNumber = 9,
                            Length = 330,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("d3670fa8-9c00-4eb7-99e9-c383f328e0f7"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 1,
                            Length = 494,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("4eb0baf1-a92b-4d23-9f15-b20b6510ee99"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 2,
                            Length = 266,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("c542eab8-72c1-4eca-9933-f5ca33e2cad4"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 3,
                            Length = 361,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("914c32d8-2a80-42ab-b8fe-a26b24b4a454"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 4,
                            Length = 367,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("06831ff9-05bd-4f11-ac88-530991538a0e"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 5,
                            Length = 127,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("56a7ef2a-b8b8-458c-a123-530be416bfd8"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 6,
                            Length = 337,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("e8d9dc64-0421-48bd-afbe-6f536d1f7060"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 7,
                            Length = 412,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("374ccee7-89c4-470c-b7e4-423bf71619b6"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
                            HoleNumber = 8,
                            Length = 141,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("fb8a62d4-9c9c-4691-a693-414568dc650d"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
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
                            Id = new Guid("09460a96-315c-4083-a11e-3693f08e5780"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            TeeBox = 52
                        },
                        new
                        {
                            Id = new Guid("b0f90312-e6dc-44e7-8947-a18b72bc8145"),
                            CourseId = new Guid("47e68b14-303b-4a91-bbec-18ed180ae81f"),
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
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            CourseId = new Guid("ce14462d-adb3-48bf-b12f-d0a66d38b9e8"),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Puts = 18,
                            Strokes = 33,
                            UserId = new Guid("76962868-6a8d-4533-b4bb-53305effd5da")
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
                            Id = new Guid("1bd292a0-b64e-4293-aaab-55bab5e7c721"),
                            HoleNumber = 1,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("34b8fe52-2dd2-4fc2-b0b3-5c76a67f03c3"),
                            HoleNumber = 2,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 6
                        },
                        new
                        {
                            Id = new Guid("11f84b9b-ad97-4494-a516-4de21f530883"),
                            HoleNumber = 3,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("e081f5a7-c826-4ce1-a3dd-636016aacbd1"),
                            HoleNumber = 4,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 3
                        },
                        new
                        {
                            Id = new Guid("1cf5793e-aec0-44be-8611-ebd0140c68b1"),
                            HoleNumber = 5,
                            Par = 0,
                            Puts = 1,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("8718ad8d-d104-4699-8f2b-aef35cf9c1f2"),
                            HoleNumber = 6,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 4
                        },
                        new
                        {
                            Id = new Guid("18ed7f64-53d7-43da-b255-413c827355e5"),
                            HoleNumber = 7,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 5
                        },
                        new
                        {
                            Id = new Guid("33fa2a57-95fa-496d-9d96-1a2744d77e74"),
                            HoleNumber = 8,
                            Par = 0,
                            Puts = 2,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
                            Score = 2
                        },
                        new
                        {
                            Id = new Guid("839367e0-8f8e-4bd4-97a4-09cabcd0ad87"),
                            HoleNumber = 9,
                            Par = 0,
                            Puts = 3,
                            RoundId = new Guid("93a8ebfb-48b9-46c0-b2f0-294d8089b207"),
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