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
                            Id = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            CourseDescription = "Krokhol golfklubb description",
                            CourseName = "Krokhol golfklubb",
                            Has18Holes = false,
                            Length = 2606,
                            Par = 36
                        },
                        new
                        {
                            Id = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
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
                            Id = new Guid("8a1f1008-c30c-4753-8f2c-25d91a0822c2"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 1,
                            Length = 113,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("2b898959-5ea5-4212-9a33-e0da537918f7"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 2,
                            Length = 295,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("8d5d4033-a475-41f3-8854-c12024cd047b"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 3,
                            Length = 439,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("9fd267c0-bacf-4ae0-9e47-d1d4f6984635"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 4,
                            Length = 128,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("db6ab4ff-43d6-4885-9c43-caab8dd8c52a"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 5,
                            Length = 506,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("d663c8e5-050b-4a3b-8243-334076898aeb"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 6,
                            Length = 227,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("4f57e7e2-50b6-488a-906d-9a732f804afe"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 7,
                            Length = 270,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("ae4274df-444d-45b4-a7e9-5386b2e09e7c"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 8,
                            Length = 298,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("d27a6694-d4a0-4fdc-9f08-769733f1526c"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            HoleNumber = 9,
                            Length = 330,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("768ee4a3-04d2-4e38-937b-164ef1294be4"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 1,
                            Length = 494,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("f797d609-5b09-4717-a71f-ae579d57d71d"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 2,
                            Length = 266,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("f9ac0034-8838-414b-93ba-cfddc65529e9"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 3,
                            Length = 361,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("d47fd485-7c83-4f27-a3d1-fbfc567dcdac"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 4,
                            Length = 367,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("f9c6eb7d-c335-4d43-ab1e-4b36678d435c"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 5,
                            Length = 127,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("79ca5e2f-aa36-43ff-8980-d79f0f837139"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 6,
                            Length = 337,
                            Par = 4
                        },
                        new
                        {
                            Id = new Guid("c74895c6-468f-4354-bf43-6258374fe0a5"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 7,
                            Length = 412,
                            Par = 5
                        },
                        new
                        {
                            Id = new Guid("6877ff95-deb9-4f1d-8c57-6ff4e564b7bf"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
                            HoleNumber = 8,
                            Length = 141,
                            Par = 3
                        },
                        new
                        {
                            Id = new Guid("8cb7a6af-7028-4a32-8902-261356307082"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
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
                            Id = new Guid("66643f26-f198-4098-83c3-857fd41a8f2a"),
                            CourseId = new Guid("6a9373e9-a757-44a4-8737-7e58a6b73214"),
                            TeeBox = 52
                        },
                        new
                        {
                            Id = new Guid("c2dd0724-0025-4dff-b3e4-025ee6e1ebb6"),
                            CourseId = new Guid("5b1ef49b-b406-4bd9-970b-c408e9785745"),
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

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.UserRatings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserRating");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
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

            modelBuilder.Entity("MulliganApi.Database.Models.UserRatings", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.User", "User")
                        .WithMany("UserRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MulliganApi.Database.Models.UserRole", b =>
                {
                    b.HasOne("MulliganApi.Database.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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

            modelBuilder.Entity("MulliganApi.Database.Models.User", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("UserRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
