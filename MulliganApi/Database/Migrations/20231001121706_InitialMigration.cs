using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MulliganApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Strokes = table.Column<int>(type: "int", nullable: false)
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "RoundHole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseHoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_CourseHole_CourseHoleId",
                        column: x => x.CourseHoleId,
                        principalTable: "CourseHole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseDescription", "CourseName" },
                values: new object[] { new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), "Krokhol golfklubb description", "Krokhol" });

            migrationBuilder.InsertData(
                table: "Round",
                columns: new[] { "RoundId", "CourseId", "Strokes", "UserId" },
                values: new object[] { new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 45, new Guid("ffafa457-d61b-4e44-939d-ab4f7e3c7bc2") });

            migrationBuilder.InsertData(
                table: "CourseHole",
                columns: new[] { "Id", "CourseId", "HoleNumber", "Length", "Par" },
                values: new object[,]
                {
                    { new Guid("2599f69d-9f20-44a9-9fa3-4cd354181077"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 6, 227, 4 },
                    { new Guid("70c72cd0-432e-4331-a6a9-fe1e996e6dd3"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 8, 298, 4 },
                    { new Guid("71d28ec1-e743-40f8-a190-81b343e4fe41"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 4, 128, 3 },
                    { new Guid("9c005b3a-a2e1-42ea-a468-72d066f8dc30"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 9, 330, 4 },
                    { new Guid("a7212d21-292f-4826-8a11-536d3b47fb15"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 3, 439, 5 },
                    { new Guid("ac722c6a-e41f-489d-b588-b6baf5e692e0"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 5, 506, 5 },
                    { new Guid("bb961991-0245-46a4-9c6a-da525ac21f8d"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 1, 113, 3 },
                    { new Guid("c027e907-0a85-4db2-9bf5-c1068c8304f6"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 7, 270, 4 },
                    { new Guid("f41fb994-81d1-400e-b735-b1bb88d08a8b"), new Guid("ea69ae8b-1b42-4839-a715-a931e0ced386"), 2, 295, 4 }
                });

            migrationBuilder.InsertData(
                table: "RoundHole",
                columns: new[] { "Id", "HoleNumber", "RoundId", "Score" },
                values: new object[,]
                {
                    { new Guid("2b289ac6-e06d-4a0e-ab1a-6f64aa666668"), 4, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 3 },
                    { new Guid("3c18512a-469e-438e-8978-ec68d8c6cc85"), 6, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 4 },
                    { new Guid("4e14450d-8246-4607-bfe2-ac1a46aa0d94"), 3, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 3 },
                    { new Guid("64017a44-fbb7-47eb-b1ce-5b1d83adbd0d"), 8, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 2 },
                    { new Guid("71f7f7c1-e448-4d01-9324-6379e689f867"), 2, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 6 },
                    { new Guid("7418bb15-f284-4777-b384-0639fbc14c54"), 1, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 2 },
                    { new Guid("78575424-9d7d-4112-8e83-3b2d1c361bcf"), 9, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 4 },
                    { new Guid("8ad27faa-ded1-49ac-ae89-63fed88e12b2"), 7, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 5 },
                    { new Guid("c1c3f1b2-9f17-44b7-b2cc-4dae1cf02a5e"), 5, new Guid("bfde4973-5db2-48c3-a1c3-20603e4ef747"), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseHole_CourseId",
                table: "CourseHole",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_CourseHoleId",
                table: "Note",
                column: "CourseHoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoundHole_RoundId",
                table: "RoundHole",
                column: "RoundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "RoundHole");

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
