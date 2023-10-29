using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    Has18Holes = table.Column<bool>(type: "bit", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Round",
                columns: table => new
                {
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Strokes = table.Column<int>(type: "int", nullable: false),
                    Puts = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Round", x => x.RoundId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseHole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Par = table.Column<int>(type: "int", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseHole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseHole_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeeBoxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeeBox = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeeBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeeBoxes_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoundHole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Puts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundHole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoundHole_Round_RoundId",
                        column: x => x.RoundId,
                        principalTable: "Round",
                        principalColumn: "RoundId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoteText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_CourseHole_HoleId",
                        column: x => x.HoleId,
                        principalTable: "CourseHole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName", "Has18Holes", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), "Krokhol golfklubb description", "Krokhol golfklubb", false, 2606, 0 },
                    { new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), "Grønmo golfklubb description", "Grønmo golfklubb", false, 2870, 0 }
                });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Date", "Puts", "Strokes", "UserId" },
                values: new object[] { new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 33, new Guid("1c77dc02-3a7f-4a03-b386-8fe026ae1872") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("039ef32b-d605-4cc0-95dc-93619bf8ed95"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 1, 494, 5 },
                    { new Guid("0d3af07c-622d-48a2-9390-458e0dad6ec5"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 3, 439, 5 },
                    { new Guid("2bf1d3ea-c04e-481d-8d62-40a6406dae5b"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 6, 227, 4 },
                    { new Guid("325a7135-98f3-4157-b94c-6aa7fa60e287"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 9, 365, 4 },
                    { new Guid("392ff825-4275-4084-a413-ce4013aee8f0"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 8, 298, 4 },
                    { new Guid("63251eb3-495e-483e-b849-3add38906154"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 7, 412, 5 },
                    { new Guid("69425fb8-a2f7-41b0-8a18-1bbec6a3f99d"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 8, 141, 3 },
                    { new Guid("8ab519d9-ceb3-43e1-8097-d9a669048a9f"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 3, 361, 4 },
                    { new Guid("9d12d2d2-c474-4ffe-9027-8c576f1e4f04"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 2, 266, 5 },
                    { new Guid("9f12ba1d-7e10-4b7d-8e2d-24e58e352762"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 5, 127, 3 },
                    { new Guid("ae82b03d-310d-424f-aeeb-39bcc42acf68"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 9, 330, 4 },
                    { new Guid("b4234f63-de81-4099-8cb8-ce400e8268a7"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 6, 337, 4 },
                    { new Guid("ba84d8b9-8a6f-4935-bcc2-b59d1320936e"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 5, 506, 5 },
                    { new Guid("e6e95233-86ac-4887-b774-bb5b2bca6ed9"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 2, 295, 4 },
                    { new Guid("f1e67be3-777e-46a0-9dba-bf94898e79ba"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 4, 367, 4 },
                    { new Guid("fc9871ab-3e74-4581-baba-5e991f09bdc6"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 1, 113, 3 },
                    { new Guid("fd2ebf69-7742-471e-b9cb-122653f03371"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 4, 128, 3 },
                    { new Guid("ff44a73c-e496-4798-931c-2d05dcc362a0"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 7, 270, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "Puts", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("2a721acd-c671-4d7c-a3ec-8f11615e4b71"), 1, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 2 },
                    { new Guid("40d0fc03-4c42-4e23-bc80-bfe4502d32a0"), 3, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 3 },
                    { new Guid("6cfaa537-35d0-45ae-b094-90e2d46151a4"), 8, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 2 },
                    { new Guid("b9615262-f37d-4d76-bd32-8b8da4abaecc"), 2, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 6 },
                    { new Guid("c1ca1463-6c5e-4026-8211-02c82843e48d"), 4, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 3 },
                    { new Guid("dc53d03e-e252-4796-aaee-43a731f04258"), 7, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 5 },
                    { new Guid("e3e62f39-3226-47a5-83d5-e72bd127bf71"), 9, 3, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 4 },
                    { new Guid("ee13d361-4095-41c4-a7d9-b9a069b73d97"), 6, 2, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 4 },
                    { new Guid("f6e4ba48-adb7-4e1d-8b48-29fc78ea2380"), 5, 1, new Guid("73eccf22-c373-48c6-957f-86913d69a9f4"), 4 }
                });

            migrationBuilder.InsertData(
                table: "TeeBoxes",
                columns: new[] { "Id", "CourseId", "TeeBox" },
                values: new object[,]
                {
                    { new Guid("48e71f0c-605d-4e65-8425-ea57269e1f89"), new Guid("78e84de3-f148-4f08-accc-acbf3fc63f34"), 57 },
                    { new Guid("fadcaa3d-32fd-4bb6-ba6b-84e306aedc3e"), new Guid("6a859225-3c13-4ffa-a1e3-304c42385a74"), 52 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseHole_CourseId",
                table: "CourseHole",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_HoleId",
                table: "Note",
                column: "HoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoundHole_RoundId",
                table: "RoundHole",
                column: "RoundId");

            migrationBuilder.CreateIndex(
                name: "IX_TeeBoxes_CourseId",
                table: "TeeBoxes",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "RoundHole");

            migrationBuilder.DropTable(
                name: "TeeBoxes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CourseHole");

            migrationBuilder.DropTable(
                name: "Round");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
